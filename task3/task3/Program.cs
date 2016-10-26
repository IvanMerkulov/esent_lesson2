using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Employee first = new Employee("Иван", "Меркулов");
            first.Appointment = "начальник отдела";
            first.CalcOcladAndNalog();
            first.ShowInfo();
            Console.ReadKey();

        }
    }
}
