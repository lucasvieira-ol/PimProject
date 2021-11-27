using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportRoomsData = PimDesktop.Business.Utils.Rooms.ReportRoomsData;
using ReservationFunctions = PimDesktop.Business.Utils.Reservations.ReservationFunctions;

namespace PimDesktop.Business.Utils.Reports
{
    public class RoomsRptData
    {

        public List<ReportRoomsData> getRoomsRpt(DateTime dateStart, DateTime dateEnd)
        {
            List<ReportRoomsData> lstRoomsReport = new List<ReportRoomsData>();

            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new Data.Server.db_pim_hmlEntities())
            {
                ReservationFunctions function = new ReservationFunctions();

                var dataHandle = (from q in context.quarto
                                  from r in context.reserva.Where(i => i.id_quarto == q.id_quarto && i.data_checkOut != null && i.data_cancelamento == null).DefaultIfEmpty()
                                  select new
                                  {
                                      name_room = q.nome,
                                      id_room = q.id_quarto,
                                      room_floor = q.andar,
                                      qty_bedsCouple = q.cama_casal,
                                      qty_bedsSingle = q.cama_solteiro,
                                      full_price = q.valor_diaria,
                                      half_price = q.valor_meia,
                                      dt_checkin = r.data_checkIn.Value,
                                      dt_checkOut = r.data_checkOut.Value,
                                      enable = r.ativo
                                  })
                                  .Where(i => i.dt_checkOut >= dateStart && i.dt_checkOut <= dateEnd)
                                  .AsEnumerable()
                                  .Select(i => new ReportRoomsData()
                                  {
                                      RoomName = i.name_room,
                                      RoomFloor = i.room_floor,
                                      QtyCoupleBeds = i.qty_bedsCouple,
                                      QtySingleBeds = i.qty_bedsSingle,
                                      RoomProfit = function.valueCalculate(i.full_price, i.half_price, i.dt_checkin, i.dt_checkOut),
                                      QtyDaysRent = calculateDays(i.dt_checkin, i.dt_checkOut),
                                      Enabled = i.enable

                                  })
                                  .ToList();

                var result = dataHandle
                    .GroupBy(i => new
                    {
                        i.QtyCoupleBeds,
                        i.QtySingleBeds,
                        i.RoomFloor,
                        i.RoomName,
                        i.Enabled
                    })
                    .Select(i => new ReportRoomsData()
                    {
                        RoomName = i.Key.RoomName,
                        RoomFloor = i.Key.RoomFloor,
                        QtyCoupleBeds = i.Key.QtyCoupleBeds,
                        QtySingleBeds = i.Key.QtySingleBeds,
                        QtyDaysRent = i.Sum(x => x.QtyDaysRent),
                        RoomProfit = i.Sum(x => x.RoomProfit),
                        Enabled = i.Key.Enabled
                    }).ToList();

                foreach (var item in result)
                {

                    lstRoomsReport.Add(item);
                }

            }

            return lstRoomsReport;
        }

        private int calculateDays(DateTime dateStart, DateTime dateEnd)
        {
            int result = (dateEnd - dateStart).Days;

            return result;
        }
    }
}
