using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDesktop.Business.Utils.Rooms
{
    public class RoomData
    {
        public int roomId { get; set; }
        public string roomName { get; set; }
        public int roomFloor { get; set; }
        public int roomCoupleBeds { get; set; }
        public int roomSingleBeds { get; set; }
        public decimal roomFullPrice { get; set; }
        public decimal roomHalfPrice { get; set; }
        public bool roomEnabled { get; set; }

    }
}
