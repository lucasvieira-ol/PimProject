using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDesktop.Business.Utils.Employees
{
    public class EmployeeData
    {
        public int employeeId { get; set; }
        public string name { get; set; }
        public string registerNumber { get; set; }
        public string function { get; set; }
        public DateTime registerDate { get; set; }
        public DateTime admissionDate { get; set; }
        public DateTime? demissionDate { get; set; }
        public bool enabled { get; set; }
    }
}
