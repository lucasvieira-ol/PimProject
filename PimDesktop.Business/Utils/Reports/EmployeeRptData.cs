using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeData = PimDesktop.Business.Utils.Employees.EmployeeData;

namespace PimDesktop.Business.Utils.Reports
{
    public class EmployeeRptData
    {
        public List<EmployeeData> getEmployeeRptData(DateTime firstDate, DateTime lastDate)
        {
            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {
                var result = context.funcionario.Where(i => i.data_cadastro >= firstDate && i.data_cadastro <= lastDate).OrderBy(i => i.nome);

                List<EmployeeData> ListEmployees = result
                    .Select(x => new EmployeeData()
                    {
                        name = x.nome,
                        registerNumber = x.matricula,
                        function = x.funcao,
                        registerDate = x.data_cadastro,
                        admissionDate = x.data_admissao,
                        demissionDate = x.data_demissao,
                        enabled = x.ativo,
                    }).ToList(); ;

                return ListEmployees;
            }
        }
    }
}
