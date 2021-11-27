using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeData = PimDesktop.Business.Utils.Employees.EmployeeData;

namespace PimDesktop.Business.Utils.CSV
{
    public class EmployeesCSV
    {
        public string EmployeesGenerateFile(List<EmployeeData> lstEmployees, DateTime dateFirst, DateTime dateLast)
        {
            try
            {
                string fileName = @"\Funcionários Cadastrados " + dateFirst.ToString("dd.MM.yyyy").TrimEnd() + " - " + dateLast.ToString("dd.MM.yyyy").TrimEnd() + ".csv";

                StringBuilder sb = new StringBuilder();

                sb.Append(
                    "Funcionario;" +
                    "Matricula;" +
                    "Funcao;" +
                    "Data_Admissao;" +
                    "Data_Demissao;" +
                    "Data_Cadastro;" +
                    "Ativo;" +
                    "\r\n");

                if (lstEmployees.Count == 0)
                    return "Não foi possível encontrar dados com o filtro aplicado";


                foreach (var item in lstEmployees)
                {
                    sb.Append(
                        item.name + ";"
                        + item.registerNumber + ";"
                        + item.function + ";"
                        + item.admissionDate + ";"
                        + item.demissionDate + ";"
                        + item.registerDate + ";"
                        + (item.enabled? "Sim" : "Não" ) + ";"
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
