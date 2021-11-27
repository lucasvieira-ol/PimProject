using PimDesktop.Data.Server;
using PimWebApi.Models.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PimWebApi.Models.Reservation
{

    public class reservationData
    {
        public int reservationId { get; set; }
        public int reservationClientId { get; set; }
        public int reservationRoomId { get; set; }
        public int? reservationUserCreateId { get; set; }
        public int? reservationUserIdCheckIn { get; set; }
        public int? reservationUserIdCheckOut { get; set; }
        public int? reservationIdEmployee { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public DateTime? checkInDate { get; set; }
        public DateTime? checkOutDate { get; set; }
        public DateTime? cancelationDate { get; set; }
        public string lastDestination { get; set; }
        public string nextDestination { get; set; }
        public string reasonTravel { get; set; }
        public string transport { get; set; }
        public int qtyCoupleBeds { get; set; }
        public int qtySingleBeds { get; set; }
        public string typePayment { get; set; }
        public int paymentTimes { get; set; }

    }
    public class reservationRpt
    {
        public int idReservation { get; set; }
        public string registerDate { get; set; }
        public string dateStart { get; set; }
        public string dateEnd { get; set; }
        public string dateCheckIn { get; set; }
        public string dateCheckOut { get; set; }
        public string dateCancelation { get; set; }
        public string roomName { get; set; }
        public int clientsCompQty { get; set; }
    }

    public class roomData
    {
        public int idRoom { get; set; }
        public decimal payValue { get; set; }
        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }
    }

    public class reservationFunctions
    {

        #region reservations

        public List<reservationRpt> GetReservationRpts(UserData client)
        {
            using (db_pim_hmlEntities context = new db_pim_hmlEntities())
            {
                List<reservationRpt> result = new List<reservationRpt>();

                try
                {
                    result = (from r in context.reserva
                              join q in context.quarto on r.id_quarto equals q.id_quarto
                              from a in context.acompanhante.Where(i => i.id_reserva == r.id_reserva).DefaultIfEmpty()
                              where
                                 (client.dateStart.Value == null || r.data_inicio >= client.dateStart.Value) &&
                                 (client.dateEnd.Value == null || r.data_fim <= client.dateEnd.Value) &&
                                 r.ativo &&
                                 r.id_hospede == client.clientId
                              select new
                              {
                                  r.id_reserva,
                                  r.data_cadastro,
                                  r.data_inicio,
                                  r.data_fim,
                                  r.data_checkIn,
                                  r.data_checkOut,
                                  r.data_cancelamento,
                                  Quarto = q.nome,
                                  Qtd = a
                              } into g
                              group g by new
                              {
                                  g.id_reserva,
                                  g.data_cadastro,
                                  g.data_inicio,
                                  g.data_fim,
                                  g.data_checkIn,
                                  g.data_checkOut,
                                  g.data_cancelamento,
                                  g.Quarto,
                                  g.Qtd
                              }
                              )
                                   .AsEnumerable()
                                   .Select(i => new reservationRpt()
                                   {
                                       idReservation = i.Key.id_reserva,
                                       registerDate = i.Key.data_cadastro.ToString("dd/MM/yyyy"),
                                       dateStart = i.Key.data_inicio.ToString("dd/MM/yyyy"),
                                       dateEnd = i.Key.data_fim.ToString("dd/MM/yyyy"),
                                       dateCheckIn = i.Key.data_checkIn != null ? i.Key.data_checkIn.Value.ToString("dd/MM/yyyy") : "",
                                       dateCheckOut = i.Key.data_checkOut != null ? i.Key.data_checkOut.Value.ToString("dd/MM/yyyy") : "",
                                       dateCancelation = i.Key.data_cancelamento != null ? i.Key.data_cancelamento.Value.ToString("dd/MM/yyyy") : "",
                                       roomName = i.Key.Quarto,
                                       clientsCompQty = i.Count(x => x.Qtd != null)
                                   }).ToList();
                }
                catch (Exception ex)
                {

                }

                return result;
            }
        }

        public string setReservation(reservationData Reservation)
        {
            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {

                int idRoom = getRoom(Reservation.qtyCoupleBeds, Reservation.qtySingleBeds, Reservation.startDate, Reservation.endDate);

                if (idRoom == 0)
                {
                    return "Não existe quartos disponiveis para criação da reserva no período desejado";
                }
                else
                {
                    PimDesktop.Data.Server.reserva newReservation = new PimDesktop.Data.Server.reserva()
                    {
                        id_quarto = idRoom,
                        id_hospede = Reservation.reservationClientId,
                        id_usuarioCadastro = Reservation.reservationUserCreateId,
                        ultimo_destino = Reservation.lastDestination,
                        proximo_destino = Reservation.nextDestination,
                        motivo_viagem = Reservation.reasonTravel,
                        meio_transporte = Reservation.transport,
                        data_cadastro = DateTime.Now,
                        data_inicio = Reservation.startDate,
                        data_fim = Reservation.endDate,
                        ativo = true
                    };

                    try
                    {
                        context.reserva.Add(newReservation);
                        context.SaveChanges();

                        registro_pagamento createLog = new registro_pagamento()
                        {
                            id_reserva = newReservation.id_reserva,
                            data_cadastro = DateTime.Now,
                            data_pagamento = DateTime.Now,
                            descricao = "Pagamento via app",
                            estorno = false,
                            registro_pago = true,
                            valor = getReservationValue(idRoom, Reservation.startDate, Reservation.endDate),
                            tipo_pagamento = Reservation.typePayment,
                            parcelas = Reservation.paymentTimes
                        };

                        context.registro_pagamento.Add(createLog);

                        context.SaveChanges();
                        return "Reserva Criada com sucesso";
                    }
                    catch
                    {
                        return "Erro ao criar a reserva";
                    }
                }
            }
        }

        public string updateReservation(reservationData Reservation)
        {
            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {
                var reservation = context.reserva.Where(i => i.id_reserva == Reservation.reservationId).FirstOrDefault();

                if (Reservation.cancelationDate != null)
                {
                    reservation.data_cancelamento = Reservation.cancelationDate.Value;

                    var updateLog = context.registro_pagamento.Where(i => i.id_reserva == Reservation.reservationId).FirstOrDefault();

                    updateLog.estorno = true;

                    context.SaveChanges();
                    return "Reserva Cancelada com sucesso";
                }

                int idRoom = getRoom(Reservation.qtyCoupleBeds, Reservation.qtySingleBeds, Reservation.startDate, Reservation.endDate, Reservation.reservationId);

                if (idRoom == 0)
                {
                    return "Não existem quartos disponiveis para criação da reserva no período desejado";
                }
                else
                {

                    reservation.id_quarto = idRoom;
                    reservation.data_inicio = Reservation.startDate;
                    reservation.data_fim = Reservation.endDate;

                    context.SaveChanges();

                    return "Reserva alterada com sucesso";

                }
            }
        }
        private decimal getReservationValue(int idRoom, DateTime dtStart, DateTime dtEnd)
        {
            using (db_pim_hmlEntities context = new db_pim_hmlEntities())
            {
                var RoomInfo = context.quarto.Where(i => i.id_quarto == idRoom).FirstOrDefault();

                decimal fullPrice = RoomInfo.valor_diaria;

                var daysTotal = dtEnd - dtStart;
                decimal result;

                result =
                    (
                        daysTotal.Days * fullPrice
                    );

                return result;

            }
        }

        #endregion

        #region room
        public int getRoom(int qtyCoupleBeds, int qtySingleBeds, DateTime dateStart, DateTime dateEnd, int idReservation = 0)
        {
            using (db_pim_hmlEntities context = new db_pim_hmlEntities())
            {
                var idRooms = context.quarto.Where(i => i.cama_casal == qtyCoupleBeds && i.cama_solteiro == qtySingleBeds && i.ativo).ToList();
                int resultRoom = 0;

                foreach (var item in idRooms)
                {
                    var avaiableRoom = context.reserva
                        .Where(i =>
                    i.ativo &&
                    (i.data_fim >= dateStart &&
                    i.data_fim <= dateEnd) &&
                    i.id_quarto == item.id_quarto &&
                    (idReservation == 0 || i.id_reserva != idReservation))
                        .Count();

                    if (avaiableRoom == 0)
                    {
                        resultRoom = item.id_quarto;
                        break;
                    }
                }

                return resultRoom;
            }
        }
        public roomData getAvailableRoom(int qtyCoupleBeds, int qtySingleBeds, DateTime dateStart, DateTime dateEnd, int idReservation = 0)
        {
            using (db_pim_hmlEntities context = new db_pim_hmlEntities())
            {
                var idRooms = context.quarto.Where(i => i.cama_casal == qtyCoupleBeds && i.cama_solteiro == qtySingleBeds && i.ativo).ToList();

                roomData resultRoom = new roomData()
                {
                    dateStart = dateStart,
                    dateEnd = dateEnd
                };

                foreach (var item in idRooms)
                {
                    var avaiableRoom = context.reserva
                        .Where(i =>
                    i.ativo &&
                    (i.data_fim >= dateStart &&
                    i.data_fim <= dateEnd) &&
                    i.id_quarto == item.id_quarto &&
                    (idReservation == 0 || i.id_reserva != idReservation))
                        .Count();

                    if (avaiableRoom == 0)
                    {
                        resultRoom.idRoom = item.id_quarto;
                        break;
                    }
                }

                if (resultRoom.idRoom != 0)
                {
                    resultRoom.payValue = getReservationValue(resultRoom.idRoom, dateStart, dateEnd);
                }

                return resultRoom;
            }
        }

        #endregion
    }

}
