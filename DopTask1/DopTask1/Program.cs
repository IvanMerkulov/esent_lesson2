using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            User first = new User();
            first.login = "test";
            first.name = "Иван";
            first.surname = "Меркулов";

            first.Show();
            Console.ReadKey();
        }
    }
}
