using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1_prodaljenie
{
    class Program
    {
        static double vremetovsekyndi(double chasove, double minyti , double sekyndi)
        {
            double vremetosekyndi = chasove * 3600 + minyti * 60 + sekyndi;
            return vremetosekyndi;
        }
        static double vremetovchasove(double chasove, double minyti, double sekyndi)
        {
           double  vremetochasove = sekyndi / 3600 + minyti / 60 + chasove;
            return vremetochasove;
        }
         static double metrivmili(double metri)
        {
            double metrimili = metri / 1609.344;
            return metrimili;
        }
        static double metrivkilometri(double metri)
        {
            double metrikilometri = metri / 1000;
            return metrikilometri;
        }
        static void Main(string[] args)
        {
            double metri = double.Parse(Console.ReadLine());
            double chasove = double.Parse(Console.ReadLine());
            double minyti = double.Parse(Console.ReadLine());
            double sekyndi = double.Parse(Console.ReadLine());
            
           
            Console.WriteLine("vremeto v sekyndi " + vremetovsekyndi(chasove, minyti , sekyndi));
            
            Console.WriteLine("vremeto v chasove " + vremetovchasove(chasove, minyti, sekyndi));
            
            Console.WriteLine("metrite v mili" + metrivmili(metri));
         
            Console.WriteLine("metrite v kilometri" + metrivkilometri(metri));
            double ms = 0;
            double kmh = 0;
            double milih = 0;
            ms = metri / vremetovsekyndi(chasove,minyti,sekyndi);
            kmh = metrivkilometri(metri) / vremetovchasove(chasove,minyti,sekyndi);
            milih = metrivmili(metri) / vremetovchasove(chasove, minyti, sekyndi);
            Console.WriteLine("m/s = " + ms);
            Console.WriteLine("km/h = " + kmh);
            Console.WriteLine("mili/h = " + milih);
        }
    }      
}
