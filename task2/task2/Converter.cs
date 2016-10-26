using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Converter
    {
        
        //поля
        public double usd1;//1             1гривна = 0,5
        public double eur1;//2             1 евро=0,25
        public double rub1;//30            1 рублей = 15 гривекн
        //методы
        public double fromGrivnaToValuta(double kolgrivna,string valuta)
        {
            double tmp = 0;
            if (valuta=="usd")
            {
                tmp = kolgrivna * usd1;
            }
            if (valuta == "eur")
            {
                tmp = kolgrivna * eur1 ;
            }
            if (valuta == "rub")
            {
                tmp = kolgrivna * rub1;
            }
            
            return tmp;
        }
        public double fromValutaToGrivna(string valuta,double kolvaluta)
        {
            double kolgrivna=0;

            if (valuta=="usd")
            {
                kolgrivna = kolvaluta / usd1;   
            }

            if (valuta=="eur")
            {
                kolgrivna = kolvaluta / eur1;
            }

            if (valuta=="rub")
            {
                kolgrivna = kolvaluta / rub1;
            }
            return kolgrivna;
        }
        
        //конструктор
        public Converter(double usd, double eur, double rub)
        {
            usd1 = usd;
            eur1 = eur;
            rub1 = rub;
        }
    }
}
