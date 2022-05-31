using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterface
{
    public class FluentEmployee
    {
        private readonly Employee _employee = new();

        public FluentEmployee WithName(string fullName)
        {
            _employee.FullName = fullName;
            return this;
        }

        public FluentEmployee BornOn(string dateOfBirth)
        {
            _employee.DateOfBirth = Convert.ToDateTime(dateOfBirth);
            return this;
        }

        public FluentEmployee WorkingAt(string department)
        {
            _employee.Department = department;
            return this;
        }

        public FluentEmployee LivesAt(string address)
        {
            _employee.Address = address;
            return this;
        }

        public override string ToString()
        {
            return _employee?.ToString() ?? String.Empty;
        }
    }
}
