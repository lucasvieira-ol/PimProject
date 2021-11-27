using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportReservationTotalData = PimDesktop.Business.Utils.Reservations.ReportReservationTotalData;
using ReportReservationAvgData = PimDesktop.Business.Utils.Reservations.ReportReservationAvgData;
using System.Data.Entity;

namespace PimDesktop.Business.Utils.Reports
{
    public class ReservationRptData
    {
        public List<ReportReservationTotalData> getReservationRpt(int clientId, DateTime dateStart, DateTime dateEnd)
        {
            List<ReportReservationTotalData> result = new List<ReportReservationTotalData>();


            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {
                var lstReservation = (from re in context.reserva
                                      join c in context.hospede on re.id_hospede equals c.id_hospede
                                      join r in context.quarto on re.id_quarto equals r.id_quarto
                                      from uci in context.usuario_sistema.Where(i => re.id_usuarioCheckIn == i.id_usuarioSistema).DefaultIfEmpty()
                                      from uco in context.usuario_sistema.Where(i => re.id_usuarioCheckOut == i.id_usuarioSistema).DefaultIfEmpty()
                                      from uca in context.usuario_sistema.Where(i => re.id_usuarioCadastro == i.id_usuarioSistema).DefaultIfEmpty()
                                      where
                                        re.data_inicio >= dateStart && re.data_inicio <= dateEnd &&
                                        (clientId == 0 || re.id_hospede == clientId)
                                      select new { re, c, r, uci, uco, uca })
                                      .ToList();

                foreach (var item in lstReservation)
                {
                    ReportReservationTotalData addResult = new ReportReservationTotalData();

                    addResult.idReservation = item.re.id_reserva;
                    addResult.clientName = item.c.nome;
                    addResult.clientTypeDocument = item.c.tipo_documento;
                    addResult.clientDocument = item.c.numero_identidade;
                    addResult.roomName = item.r.nome;
                    addResult.dateStart = item.re.data_inicio.ToString("dd'/'MM'/'yyyy");
                    addResult.dateEnd = item.re.data_fim.ToString("dd'/'MM'/'yyyy");
                    addResult.dateCheckIn = item.re.data_checkIn.HasValue ? item.re.data_checkIn.Value.ToString("dd'/'MM'/'yyyy") : "";
                    addResult.userCheckIn = item.uci != null ? item.uci.nome : "";
                    addResult.dateCheckOut = item.re.data_checkOut.HasValue ? item.re.data_checkOut.Value.ToString("dd'/'MM'/'yyyy") : "";
                    addResult.userCheckOut = item.uco != null ? item.uco.nome : "";
                    addResult.dateCancelation = item.re.data_cancelamento.HasValue ? item.re.data_cancelamento.Value.ToString("dd'/'MM'/'yyyy") : "";
                    addResult.roomFullPrice = item.r.valor_diaria;
                    addResult.roomHalfPrice = item.r.valor_meia;
                    addResult.totalpaid = calculateTotalPaid(item.r.valor_diaria, item.r.valor_meia, item.re.data_checkIn, item.re.data_checkOut);
                    addResult.dateCreated = item.re.data_cadastro.ToString("dd'/'MM'/'yyyy");
                    addResult.userCreated = item.uca != null ? item.uca.nome : "";

                    result.Add(addResult);

                }

                return result.OrderBy(i => i.dateStart).ToList();
            }

        }
        public List<ReportReservationAvgData> getAvgReservationRpt(DateTime dateStart, DateTime dateEnd)
        {
            List<ReportReservationAvgData> result = new List<ReportReservationAvgData>();

            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {
                var lstReservation = (from re in context.reserva
                                      join r in context.quarto on re.id_quarto equals r.id_quarto
                                      where
                                        re.ativo && re.data_checkOut.Value != null &&
                                        re.data_checkIn.Value != null &&
                                        re.data_cancelamento.Value == null &&
                                        re.data_checkOut.Value >= dateStart &&
                                        re.data_checkOut.Value <= dateEnd
                                      select new { re, r })
                                      .AsEnumerable()
                                        .OrderByDescending(x => x.re.data_checkOut)
                                        .GroupBy(x => new
                                        {
                                            x.re.data_checkOut.Value.Month,
                                            x.re.data_checkOut.Value.Year,
                                            x.r.nome,
                                            totalpaid = calculateTotalPaid(x.r.valor_diaria, x.r.valor_meia, x.re.data_checkIn.Value, x.re.data_checkOut.Value).Sum(i => i).ToString().Replace(".", ",")
                                        })
                                        .Select(x => new ReportReservationAvgData
                                        {
                                            roomName = x.Key.nome,
                                            dt_period = string.Format("{0}/{1}", x.Key.Month, x.Key.Month),
                                            qtyMonth = Convert.ToInt32(string.Format("{0}", x.Count())),
                                            totalByMonth = x.Key.totalpaid
                                        })
                                        .ToList();

                return lstReservation;
            }
        }

        private string calculateTotalPaid(decimal fullPrice, decimal halfPrice, DateTime? dtCheckIn, DateTime? dtCheckOut)
        {
            try
            {
                decimal result;

                if (dtCheckOut == null || dtCheckIn == null)
                    return "0,00";

                var daysTotal = dtCheckOut.Value - dtCheckIn.Value;

                if (dtCheckOut.Value.Hour < 13)
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
                return result.ToString().Replace(".", ",");
            }
            catch (Exception ex)
            {
                return "0,00";
            }
        }
    }
}
