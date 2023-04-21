using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR
{
    public class EmployeeAddEventArgs : EventArgs
    {
        public List<Employees> Employees { get; private set; }

        public EmployeeAddEventArgs(List<Employees> employees)
        {
            Employees = employees;
        }
    }
}
