using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportRoomsData = PimDesktop.Business.Utils.Rooms.ReportRoomsData;


namespace PimDesktop.Business.Utils.CSV
{
    public class RoomsCSV
    {
        public string RoomsGenerateFile(List<ReportRoomsData> lstRooms, DateTime dateFirst, DateTime dateLast)
        {
            try
            {
                if (lstRooms.Count == 0)
                    return "Não foi possível encontrar dados com o filtro aplicado";

                string fileName = @"\Registros Quartos" + dateFirst.ToString("dd.MM.yyyy").TrimEnd() + " - " + dateLast.ToString("dd.MM.yyyy").TrimEnd() + ".csv";

                StringBuilder sb = new StringBuilder();

                sb.Append(
                    "Quarto;" +
                    "Andar;" +
                    "Camas de Casal;" +
                    "Camas de Solteiro;" +
                    "Dias Usados;" +
                    "Lucro;" +
                    "Ativo;" +
                    "\r\n");


                foreach (var item in lstRooms)
                {
                    sb.Append(
                        item.RoomName + ";"
                        + item.RoomFloor + ";"
                        + item.QtyCoupleBeds + ";"
                        + item.QtySingleBeds + ";"
                        + item.QtyDaysRent + ";"
                        + item.RoomProfit.ToString().Replace(".", ",") + ";"
                        + (item.Enabled ? "Sim" : "Não") + ";"
                        + "\r\n"
                        );
                }

                string PathFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + fileName;
                //Save the file in the given path
                TextWriter sw = new StreamWriter(PathFile, true, Encoding.GetEncoding("UTF-8"));
                sw.Write(sb.ToString());
                sw.Close();
                return "Dados salvos com sucesso em: " + PathFile;

            }
            catch (Exception ex)
            {
                return "Erro ao Salvar os Arquivos";
            }
        }
    }
}
