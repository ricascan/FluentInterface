using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Address = "Calle";
            employee.FullName = "Pepe";
            employee.DateOfBirth = new DateTime(1910, 1, 1);
            employee.Department = "Departamento";

            Console.WriteLine(employee);

            var fluentEmployee = new FluentEmployee()
                .WithName("Pepe")
                .LivesAt("Calle")
                .BornOn("01/01/1910")
                .WorkingAt("Departamento");

            Console.WriteLine(fluentEmployee);

            Console.ReadLine();
        }
    }
}
