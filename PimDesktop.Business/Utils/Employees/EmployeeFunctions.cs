using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDesktop.Business.Utils.Employees
{
    public class EmployeeFunctions
    {
        public EmployeeData getEmployee(string registerNumber)
        {

            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {
                EmployeeData functionFound = new EmployeeData();

                try
                {
                    functionFound = context.funcionario
                        .Where(i => i.matricula == registerNumber)
                        .Select(x => new EmployeeData()
                        {
                            name = x.nome,
                            registerNumber = x.matricula,
                            function = x.funcao,
                            registerDate = x.data_cadastro,
                            admissionDate = x.data_admissao,
                            demissionDate = x.data_demissao,
                            enabled = x.ativo,
                        })
                        .FirstOrDefault();

                    return functionFound;
                }
                catch (Exception ex)
                {
                    return functionFound;
                }
            }
        }

        public bool putEmployee(EmployeeData currentEmployee)
        {
            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {
                var updateEmployee = context.funcionario.Where(i => i.id_funcionario == currentEmployee.employeeId).FirstOrDefault();


                if (context.funcionario.AsEnumerable().Where(i => i.matricula == currentEmployee.registerNumber && i.id_funcionario != currentEmployee.employeeId).Count() == 0)
                {
                    if (currentEmployee.registerNumber != updateEmployee.matricula)
                        updateEmployee.matricula = currentEmployee.registerNumber;


                    if (!string.IsNullOrEmpty(currentEmployee.name))
                        updateEmployee.nome = currentEmployee.name;

                    if (currentEmployee.admissionDate != null)
                        updateEmployee.data_admissao = currentEmployee.admissionDate;

                    if (!string.IsNullOrEmpty(currentEmployee.function))
                        updateEmployee.funcao = currentEmployee.function;


                    if (currentEmployee.demissionDate != null)
                        updateEmployee.data_demissao = currentEmployee.demissionDate;

                    updateEmployee.ativo = currentEmployee.enabled;


                    context.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool setEmployee(EmployeeData currentEmployee)
        {

            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {

                if (context.funcionario.Where(i => i.matricula == currentEmployee.registerNumber).Count() == 0)
                {
                    PimDesktop.Data.Server.funcionario createEmployee = new Data.Server.funcionario()
                    {
                        nome = currentEmployee.name,
                        matricula = currentEmployee.registerNumber,
                        funcao = currentEmployee.function,
                        data_cadastro = DateTime.Now,
                        data_admissao = currentEmployee.admissionDate,
                        data_demissao = currentEmployee.demissionDate,
                        ativo = currentEmployee.enabled,
                    };

                    context.funcionario.Add(createEmployee);

                    context.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }

}
