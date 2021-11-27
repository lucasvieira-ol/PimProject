using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportReservationTotalData = PimDesktop.Business.Utils.Reservations.ReportReservationTotalData;
using ReservationAvgRptData = PimDesktop.Business.Utils.Reservations.ReportReservationAvgData;

namespace PimDesktop.Business.Utils.CSV
{
    public class ReservationsCSV
    {

        public string ReservationsGenerateFile(List<ReportReservationTotalData> lstReservations, DateTime dateFirst, DateTime dateLast)
        {
            try
            {
                string fileName = @"\Total Reservas " + dateFirst.ToString("dd.MM.yyyy").TrimEnd() + " - " + dateLast.ToString("dd.MM.yyyy").TrimEnd() + ".csv";

                StringBuilder sb = new StringBuilder();

                sb.Append(
                    "idReserva;" +
                    "Hospede;" +
                    "Tipo Documento;" +
                    "Documento;" +
                    "Quarto;" +
                    "Preço Diária;" +
                    "Preço Meia;" +
                    "Data Inicio;" +
                    "Data Fim;" +
                    "Data CheckIn;" +
                    "Usuário CheckIn;" +
                    "Data CheckOut;" +
                    "Usuário CheckOut;" +
                    "Data Cancelamento;" +
                    "Total Pago;" +
                    "Data Cadastro;" +
                    "Usuário Cadastro;" +
                    "\r\n");

                if (lstReservations.Count == 0)
                    return "Não foi possível encontrar dados com o filtro aplicado";

                foreach (var item in lstReservations)
                {
                    sb.Append(
                        item.idReservation + ";"
                        + item.clientName + ";"
                        + item.clientTypeDocument + ";"
                        + item.clientDocument + ";"
                        + item.roomName + ";"
                        + item.dateStart + ";"
                        + item.dateEnd + ";"
                        + item.dateCheckIn + ";"
                        + item.userCheckIn + ";"
                        + item.dateCheckOut + ";"
                        + item.userCheckOut + ";"
                        + item.dateCancelation + ";"
                        + item.roomFullPrice + ";"
                        + item.roomHalfPrice + ";"
                        + item.totalpaid + ";"
                        + item.dateCreated + ";"
                        + item.userCreated + ";"
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
        public string ReservationsAvgGenerateFile(List<ReservationAvgRptData> lstReservations, DateTime dateFirst, DateTime dateLast)
        {
            try
            {
                string fileName = @"\Médias Reservas " + dateFirst.ToString("dd.MM.yyyy").TrimEnd() + " - " + dateLast.ToString("dd.MM.yyyy").TrimEnd() + ".csv";

                StringBuilder sb = new StringBuilder();

                sb.Append(
                    "Periodo;" +
                    "Quarto;" +
                    "Qtd Reservas;" +
                    "Total;" +
                    "\r\n");

                if (lstReservations.Count == 0)
                    return "Não foi possível encontrar dados com o filtro aplicado";

                foreach (var item in lstReservations)
                {
                    sb.Append(
                        item.dt_period + ";"
                        + item.roomName + ";"
                        + item.qtyMonth + ";"
                        + item.totalByMonth + ";"
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

