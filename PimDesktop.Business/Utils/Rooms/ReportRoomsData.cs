using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDesktop.Business.Utils.Rooms
{
    public class ReportRoomsData
    {
        public string RoomName { get; set; }
        public int QtyCoupleBeds { get; set; }
        public int QtySingleBeds { get; set; }
        public int RoomFloor { get; set; }
        public int QtyDaysRent { get; set; }
        public decimal RoomProfit { get; set; }
        public bool Enabled { get; set; }
    }
}
