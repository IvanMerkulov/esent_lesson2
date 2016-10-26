using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter temp = new Converter(0.5, 0.25, 15);
            Console.WriteLine("1 гривен в доларе ="+temp.fromGrivnaToValuta(1,"usd"));
            Console.WriteLine("10 гривен в доларе ="+temp.fromGrivnaToValuta(10,"usd"));
            Console.ReadKey();
        }
    }
}
