using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDesktop.Business.Utils.Reservations
{
    public class ReservationFunctions
    {
        public List<ReservationData> getReservation(int clientId)
        {
            List<ReservationData> result = new List<ReservationData>();

            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
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
        public ReservationData getReservationById(int reservationId)
        {
            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {
                var result = context.reserva.Where(x => x.id_reserva == reservationId).FirstOrDefault();

                    ReservationData reservation = new ReservationData();
                    reservation.reservationId = result.id_reserva;
                    reservation.reservationClientId = result.id_hospede;
                    reservation.reservationIdEmployee = result.id_funcionario;
                    reservation.reservationRoomId = result.id_quarto;
                    reservation.createdDate = result.data_cadastro;
                    reservation.startDate = result.data_inicio;
                    reservation.endDate = result.data_fim;
                    reservation.checkInDate = result.data_checkIn;
                    reservation.checkOutDate = result.data_checkOut;
                    reservation.reservationUserIdCheckIn = result.id_usuarioCheckIn;
                    reservation.reservationUserIdCheckOut = result.id_usuarioCheckOut;
                    reservation.cancelationDate = result.data_cancelamento;
                    reservation.reservationUserCreateId = result.id_usuarioCadastro;
                    reservation.transport = result.meio_transporte;
                    reservation.nextDestination = result.proximo_destino;
                    reservation.lastDestination = result.ultimo_destino;
                    reservation.reasonTravel = result.motivo_viagem;

                return reservation;
            }
        }

        public bool updateReservation(List<ReservationData> lstReservation)
        {
            bool update = false;
            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
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
            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
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
            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {
                var reservation = context.reserva.Where(i => i.id_reserva == idReservation).FirstOrDefault();
                var room = context.quarto.Where(i => i.id_quarto == reservation.id_quarto).FirstOrDefault();


                reservation.data_checkOut = DateTime.Now;
                reservation.id_usuarioCheckOut = idUser;

                decimal totalPaid = valueCalculate(room.valor_diaria, room.valor_meia, (DateTime)reservation.data_checkIn, (DateTime)reservation.data_checkOut);

                PimDesktop.Data.Server.registro_pagamento paymentLog = new PimDesktop.Data.Server.registro_pagamento()
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
            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {
                PimDesktop.Data.Server.reserva newReservation = new PimDesktop.Data.Server.reserva()
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
