using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR
{
    public class Employees
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? EmployedDate { get; set; }
        public decimal Wage { get; set; }
        public string Employeed { get; set; }
        public DateTime? DismissedDate { get; set; }
        public int GroupId { get; set; }
    }
}
