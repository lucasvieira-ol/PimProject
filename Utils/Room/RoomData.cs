using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDesktop.Utils.Room
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

        public RoomData getRoom(string room)
        {
            using (PimDesktop.Server.db_pim_hmlEntities1 context = new Server.db_pim_hmlEntities1())
            {
                RoomData resultRoom = context.quarto
                    .Where(i => i.nome == room && i.ativo == true)
                    .Select(i => new RoomData() { 
                    roomId = i.id_quarto,
                    roomName = i.nome,
                    roomFloor = i.andar,
                    roomCoupleBeds = i.cama_casal,
                    roomSingleBeds = i.cama_solteiro,
                    roomFullPrice = i.valor_diaria,
                    roomHalfPrice = i.valor_meia,
                    roomEnabled = i.ativo
                })
                    .FirstOrDefault();

                return resultRoom;
            }
        }
        public List<RoomData> getEmptyRooms(DateTime startDate, DateTime endDate)
        {
            using (PimDesktop.Server.db_pim_hmlEntities1 context = new Server.db_pim_hmlEntities1())
            {
                List<RoomData> resultRoom = new List<RoomData>();

                var rooms = context.quarto.Where(i => i.ativo == true).ToList();

                foreach (var item in rooms)
                {
                    var notFound = context.reserva.Where(i => i.data_inicio >= startDate && i.data_fim <= endDate && i.id_quarto == item.id_quarto).FirstOrDefault();

                    if(notFound == null)
                    {
                        RoomData addRoom = new RoomData() {
                            roomId = item.id_quarto,
                            roomEnabled = item.ativo,
                            roomName = item.nome,
                            roomFloor = item.andar,
                            roomSingleBeds = item.cama_solteiro,
                            roomCoupleBeds = item.cama_casal,
                            roomFullPrice = item.valor_diaria,
                            roomHalfPrice = item.valor_meia
                        };

                        resultRoom.Add(addRoom);
                    }

                }

                return resultRoom;
            }
        }
    }
}
