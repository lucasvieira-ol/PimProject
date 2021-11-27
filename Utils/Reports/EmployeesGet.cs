using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDesktop.Utils.Reports
{
    public class EmployeesGet
    {
        public string name { get; set; }
        public string registerNumber { get; set; }
        public string function { get; set; }
        public DateTime registerDate { get; set; }
        public DateTime admissionDate { get; set; }
        public DateTime? demissionDate { get; set; }
        public string enabled { get; set; }

        public List<EmployeesGet> EmployeesExport(DateTime firstDate, DateTime lastDate)
        {
            using (PimDesktop.Server.db_pim_hmlEntities1 context = new Server.db_pim_hmlEntities1())
            {
                var result = context.funcionario.Where(i => i.data_cadastro >= firstDate && i.data_cadastro <= lastDate).OrderBy(i => i.nome);

                List<EmployeesGet> ListEmployees = result.AsEnumerable().Select(x => new EmployeesGet()
                {
                    name = x.nome,
                    registerNumber = x.matricula,
                    function = x.funcao,
                    registerDate = x.data_cadastro,
                    admissionDate = x.data_admissao,
                    demissionDate = x.data_demissao,
                    enabled = (x.ativo == true ? "Sim" : "Não"),
                }).ToList(); ;

                return ListEmployees;
            }
        }
    }

}
