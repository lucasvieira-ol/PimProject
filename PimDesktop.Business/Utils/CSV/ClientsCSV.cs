using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientData = PimDesktop.Business.Utils.Clients.ClientData;

namespace PimDesktop.Business.Utils.CSV
{
    public class ClientsCSV
    {
        public string ClientsGenerateFile(List<ClientData> lstClients, DateTime dateFirst, DateTime dateLast)
        {
            try
            {
                string fileName = @"\Hospedes Cadastrados " + dateFirst.ToString("dd.MM.yyyy").TrimEnd() + " - " + dateLast.ToString("dd.MM.yyyy").TrimEnd() + ".csv";

                StringBuilder sb = new StringBuilder();

                sb.Append(
                    "idHospede;" +
                    "Hospede;" +
                    "CPF;" +
                    "Tipo Documento;" +
                    "Orgão Expedidor;" +
                    "Documento;" +
                    "Email;" +
                    "Função;" +
                    "Data Nascimento;" +
                    "Data Cadastro;" +
                    "Pais;" +
                    "Estado;" +
                    "Cidade;" +
                    "CEP;" +
                    "Endereço;" +
                    "Complemento;" +
                    "Primeiro Telefone;" +
                    "Segundo Telefone;" +
                    "idUsuário;" +
                    "Data Primeiro Acesso;" +
                    "Data Último Acesso;" +
                    "Data Cadastro Usuário;" +
                    "\r\n");


                if (lstClients.Count == 0)
                    return "Não foi possível encontrar dados com o filtro aplicado";


                foreach (var item in lstClients)
                {

                    sb.Append(
                        item.clientId + ";"
                        + item.clientName + ";"
                        + item.clientCPF + ";"
                        + item.typeDocument + ";"
                        + item.expeditor + ";"
                        + item.clientDocument + ";"
                        + item.emailUser + ";"
                        + item.function + ";"
                        + item.dt_birth.GetValueOrDefault().Date.ToString("dd/MM/yyyy") + ";"
                        + item.dt_createdAt.Date.ToString("dd/MM/yyyy") + ";"
                        + item.country + ";"
                        + item.state + ";"
                        + item.city + ";"
                        + item.zipCode + ";"
                        + item.firstAdress + ";"
                        + item.secondAdress + ";"
                        + item.firstPhone + ";"
                        + item.secondPhone + ";"
                        + item.id_UserClient + ";"
                        + item.dt_firstAccess.GetValueOrDefault().Date.ToString("dd/MM/yyyy") + ";"
                        + item.dt_lastAccess.GetValueOrDefault().Date.ToString("dd/MM/yyyy") + ";"
                        + item.dt_userCreatedAt.GetValueOrDefault().Date.ToString("dd/MM/yyyy") + ";"
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
