using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserData = PimDesktop.Business.Utils.Users.UserData;

namespace PimDesktop.Business.Utils.CSV
{
    public class UsersCSV
    {
        public string UsersGenerateFile(List<UserData> lstUsers, DateTime dateFirst, DateTime dateLast)
        {
            try
            {
                string fileName = @"\Usuários Sistema Cadastrados " + dateFirst.ToString("dd.MM.yyyy").TrimEnd() + " - " + dateLast.ToString("dd.MM.yyyy").TrimEnd() + ".csv";

                StringBuilder sb = new StringBuilder();

                sb.Append(
                    "id Usuário Sistema;" +
                    "Usuário;" +
                    "E=mail;" +
                    "Perfil;" +
                    "Qtd Reservas Criadas;" +
                    "Qtd Reservas CheckIn;" +
                    "Qtd Reservas CheckOut;" +
                    "Ativo;" +
                    "\r\n");

                foreach (var item in lstUsers)
                {

                    sb.Append(
                        item.userId + ";"
                        + item.user + ";"
                        + item.emailUser + ";"
                        + item.nameProfile + ";"
                        + item.qtyReservationCreated + ";"
                        + item.qtyReservationCheckIn + ";"
                        + item.qtyReservationCheckOut + ";"
                        + item.enabled + ";"
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
