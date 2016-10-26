using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Employee
    {
        public string Name;
        public string Surname;
        public string Appointment; //начальник отдела. инженер.рабочий
        public double WorkExperience;
        public double oclad;
        public double Nalog;
        //методы
        public void CalcOcladAndNalog()
        {
           // double oclad=0;
            if (Appointment=="начальник отдела")
            {
                this.oclad = 10000;
              
            }
            if (Appointment == "инженер")
            {
                this.oclad = 8000;
            }
            if (Appointment == "рабочий")
            {
                this.oclad = 4000;
            }
             if (WorkExperience>5)
             { oclad = this.oclad * 1.3; }
             
            Nalog = this.oclad*0.13;
             
        }
        public void ShowInfo()
        {
            Console.WriteLine("Имя: "+Name);
            Console.WriteLine("Фамилия: "+Surname);
            Console.WriteLine("Должность: "+Appointment);
            Console.WriteLine("Оклад:"+ oclad);
            Console.WriteLine("НДФЛ="+ Nalog);
        }
        //конструктор
        public Employee(string name1, string surname1)
        {
            this.Name = name1;
            this.Surname = surname1;
        }
    }
}
