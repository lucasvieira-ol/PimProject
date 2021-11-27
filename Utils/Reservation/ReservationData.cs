using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDesktop.Utils.Reservation
{
    public class ReservationData
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


        public List<reservationRptData> getReservationRpt(int clientId, DateTime dateStart, DateTime dateEnd)
        {
            List<reservationRptData> result = new List<reservationRptData>();

            using (PimDesktop.Server.db_pim_hmlEntities1 context = new Server.db_pim_hmlEntities1())
            {
                var lstReservation = (from re in context.reserva
                                      join c in context.hospede on re.id_hospede equals c.id_hospede
                                      join r in context.quarto on re.id_quarto equals r.id_quarto
                                      where
                                        (clientId == 0 || re.id_hospede == clientId) &&
                                        re.data_inicio >= dateStart && re.data_inicio <= dateEnd
                                      select new { re, c, r })
                                      .AsEnumerable()
                                      .Select(i => new reservationRptData()
                                      {
                                          idReservation = i.re.id_reserva,
                                          clientName = i.c.nome,
                                          clientDocument = i.c.numero_identidade,
                                          roomName = i.r.nome,
                                          dateStart = i.re.data_inicio.ToString("dd'/'MM'/'yyyy"),
                                          dateEnd = i.re.data_fim.ToString("dd'/'MM'/'yyyy"),
                                          dateCheckIn = i.re.data_checkIn.HasValue ? i.re.data_checkIn.Value.ToString("dd'/'MM'/'yyyy") : "",
                                          dateCheckOut = i.re.data_checkOut.HasValue ? i.re.data_checkOut.Value.ToString("dd'/'MM'/'yyyy") : "",
                                          dateCancelation = i.re.data_cancelamento.HasValue ? i.re.data_cancelamento.Value.ToString("dd'/'MM'/'yyyy") : ""
                                      })
                                      .OrderBy(i => i.dateStart);




                foreach (var item in lstReservation)
                {
                    reservationRptData reservation = new reservationRptData();
                    reservation.idReservation = item.idReservation;
                    reservation.clientName = item.clientName;
                    reservation.clientDocument = item.clientDocument;
                    reservation.roomName = item.roomName;
                    reservation.dateStart = item.dateStart;
                    reservation.dateEnd = item.dateEnd;
                    reservation.dateCheckIn = item.dateCheckIn;
                    reservation.dateCheckOut = item.dateCheckOut;
                    reservation.dateCancelation = item.dateCancelation;

                    result.Add(reservation);
                }

            }

            return result;
        }
        public List<ReservationData> getReservation(int clientId)
        {
            List<ReservationData> result = new List<ReservationData>();

            using (PimDesktop.Server.db_pim_hmlEntities1 context = new Server.db_pim_hmlEntities1())
            {
                var lstReservation = context.reserva.Where(x => x.id_reserva == clientId).ToList();

                foreach (var item in lstReservation)
                {
                    ReservationData reservation = new ReservationData();
                    reservation.reservationId = item.id_reserva;
                    reservation.reservationClientId = item.id_hospede;
                    reservation.reservationIdEmployee = item.id_funcionario;
                    reservation.reservationRoomId = item.id_quarto;
                    reservation.createdDate = item.data_cadastro;
                    reservation.startDate = item.data_inicio;
                    reservation.endDate = item.data_fim;
                    reservation.checkInDate = item.data_checkIn;
                    reservation.checkOutDate = item.data_checkOut;
                    reservation.reservationUserIdCheckIn = item.id_usuarioCheckIn;
                    reservation.reservationUserIdCheckOut = item.id_usuarioCheckOut;
                    reservation.cancelationDate = item.data_cancelamento;
                    reservation.reservationUserCreateId = item.id_usuarioCadastro;
                    reservation.transport = item.meio_transporte;
                    reservation.nextDestination = item.proximo_destino;
                    reservation.lastDestination = item.ultimo_destino;
                    reservation.reasonTravel = item.motivo_viagem;

                    result.Add(reservation);
                }
            }

            return result;
        }

        public bool updateReservation(List<ReservationData> lstReservation)
        {
            bool update = false;
            using (PimDesktop.Server.db_pim_hmlEntities1 context = new Server.db_pim_hmlEntities1())
            {
                foreach (var item in lstReservation)
                {
                    var reservation = context.reserva.Where(i => i.id_reserva == item.reservationId).FirstOrDefault();

                    reservation.data_inicio = item.startDate != null ? item.startDate : reservation.data_inicio;
                    reservation.data_fim = item.endDate != null ? item.endDate : reservation.data_fim;
                    reservation.data_cancelamento = item.cancelationDate ?? reservation.data_cancelamento;
                    reservation.id_quarto = item.reservationRoomId != null ? item.reservationRoomId : reservation.id_quarto;

                    context.SaveChanges();
                    update = true;
                }
            }
            return update;
        }
        public bool CheckInReservation(int idReservation, int idUser)
        {
            using (PimDesktop.Server.db_pim_hmlEntities1 context = new Server.db_pim_hmlEntities1())
            {
                var reservation = context.reserva.Where(i => i.id_reserva == idReservation).FirstOrDefault();

                if (reservation.data_checkIn == null)
                {
                    reservation.data_checkIn = DateTime.Now;
                    reservation.id_usuarioCheckIn = idUser;

                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void CheckOutReservation(int idReservation, int idUser, int paymentTimes, string paymentType)
        {
            using (PimDesktop.Server.db_pim_hmlEntities1 context = new Server.db_pim_hmlEntities1())
            {
                var reservation = context.reserva.Where(i => i.id_reserva == idReservation).FirstOrDefault();
                var room = context.quarto.Where(i => i.id_quarto == reservation.id_quarto).FirstOrDefault();


                reservation.data_checkOut = DateTime.Now;
                reservation.id_usuarioCheckOut = idUser;

                decimal totalPaid = valueCalculate(room.valor_diaria, room.valor_meia, (DateTime)reservation.data_checkIn, (DateTime)reservation.data_checkOut);

                PimDesktop.Server.registro_pagamento paymentLog = new Server.registro_pagamento()
                {
                    id_reserva = reservation.id_reserva,
                    descricao = "Pagamento Local",
                    valor = totalPaid,
                    tipo_pagamento = paymentType,
                    registro_pago = true,
                    data_pagamento = DateTime.Now,
                    data_cadastro = DateTime.Now,
                    estorno = false,
                    parcelas = paymentTimes
                };

                context.registro_pagamento.Add(paymentLog);
                context.SaveChanges();
            }
        }
        public decimal valueCalculate(decimal fullPrice, decimal halfPrice, DateTime dtCheckIn, DateTime dtCheckOut)
        {
            var daysTotal = dtCheckOut - dtCheckIn;
            decimal result;

            if (dtCheckOut.Hour < 13)
            {
                daysTotal = daysTotal.Add(new TimeSpan(-1, 0, 0));

                result =
                    (
                        daysTotal.Days * fullPrice + halfPrice
                    );

            }
            else
            {
                result =
                    (
                          daysTotal.Days * fullPrice
                    );
            }
            return result;
        }
        public bool setReservation(ReservationData Reservation)
        {
            using (PimDesktop.Server.db_pim_hmlEntities1 context = new Server.db_pim_hmlEntities1())
            {
                PimDesktop.Server.reserva newReservation = new Server.reserva()
                {
                    id_quarto = Reservation.reservationRoomId,
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

                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }

}

