using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopTask1
{
    class User
    {
        public string login;
        public string name;
        public string surname;
        private DateTime NowDate;
        //методы 
        public void Show()
        {
        Console.WriteLine(login);
        Console.WriteLine(name);
            Console.WriteLine(surname);
            Console.WriteLine(NowDate);
        }

        //конструктор
        public User()
        {
 
            NowDate = DateTime.Now; 
        }

    }
}
