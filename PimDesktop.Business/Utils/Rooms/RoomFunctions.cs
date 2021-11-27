using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDesktop.Business.Utils.Rooms
{
    public class RoomFunctions
    {
        public RoomData getRoom(string room)
        {

            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {
                RoomData resultRoom = new RoomData();

                try
                {
                    var result = context.quarto
                       .Where(i => i.nome == room).FirstOrDefault();


                    resultRoom.roomId = result.id_quarto;
                    resultRoom.roomName = result.nome;
                    resultRoom.roomFloor = result.andar;
                    resultRoom.roomCoupleBeds = result.cama_casal;
                    resultRoom.roomSingleBeds = result.cama_solteiro;
                    resultRoom.roomFullPrice = result.valor_diaria;
                    resultRoom.roomHalfPrice = result.valor_meia;
                    resultRoom.roomEnabled = result.ativo;



                    return resultRoom;
                }
                catch (Exception ex)
                {
                    return resultRoom;
                }
            }
        }
        public bool putRoom(RoomData currentRoom)
        {

            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {
                var updateRoom = context.quarto.Where(i => i.id_quarto == currentRoom.roomId).FirstOrDefault();

                if (context.quarto.AsEnumerable().Where(i => i.nome == currentRoom.roomName && i.id_quarto != currentRoom.roomId).Count() == 0)
                {
                    if (!string.IsNullOrEmpty(currentRoom.roomName))
                        if (currentRoom.roomName != updateRoom.nome)
                            updateRoom.nome = currentRoom.roomName;

                    updateRoom.andar = currentRoom.roomFloor;
                    updateRoom.cama_casal = currentRoom.roomCoupleBeds;
                    updateRoom.cama_solteiro = currentRoom.roomSingleBeds;
                    updateRoom.valor_diaria = currentRoom.roomFullPrice;
                    updateRoom.valor_meia = currentRoom.roomHalfPrice;
                    updateRoom.ativo = currentRoom.roomEnabled;

                    context.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool setRoom(RoomData currentRoom)
        {

            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {

                if (context.quarto.Where(i => i.nome == currentRoom.roomName).Count() == 0)
                {
                    PimDesktop.Data.Server.quarto createRoom = new Data.Server.quarto()
                    {
                        nome = currentRoom.roomName,
                        andar = currentRoom.roomFloor,
                        cama_casal = currentRoom.roomCoupleBeds,
                        cama_solteiro = currentRoom.roomSingleBeds,
                        valor_diaria = currentRoom.roomFullPrice,
                        valor_meia = currentRoom.roomHalfPrice,
                        ativo = currentRoom.roomEnabled,
                    };

                    context.quarto.Add(createRoom);

                    context.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public List<RoomData> getEmptyRooms(DateTime startDate, DateTime endDate)
        {
            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {
                List<RoomData> resultRoom = new List<RoomData>();

                var rooms = context.quarto.Where(i => i.ativo == true).ToList();

                foreach (var item in rooms)
                {
                    var notFound = context.reserva.Where(i => i.data_inicio >= startDate && i.data_fim <= endDate && i.id_quarto == item.id_quarto).FirstOrDefault();

                    if (notFound == null)
                    {
                        RoomData addRoom = new RoomData()
                        {
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
