using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DetyraFakultet
{                                           //DETYRA 2 Nga Elion Rexhepi dhe Vendim Hyseni
    internal class Program
    {
        class Employee
        {
            public int Id { get; set; }
            public string Emri { get; set; }
            public string Pozita { get; set; }
            public double Rroga { get; set; }

            public virtual double CalculateBonus(double bonus)
            {
                bonus = 50000;
                return bonus;
            }
        }
        class Zhvillues : Employee
        {
            public override double CalculateBonus(double bonus)
            {
                double bonusFiks = 50000;
                double bonusPerqindje = Rroga * 0.2;
                bonus = Math.Max(bonusPerqindje, bonusFiks);
                
                return bonus;
            }
}

        class Menaxher : Employee
        {
            public override double CalculateBonus(double bonus)
            {
                double bonusFiks = 50000;
                double bonusPerqindje = Rroga * 0.25;
                bonus = Math.Max(bonusPerqindje, bonusFiks);

                return bonus;
            }
        }

        class Admin : Employee
        {
            public override double CalculateBonus(double bonus)
            {
                bonus = 50000;
                return bonus;
            }
        }
        static void Main(string[] args)
        {
            //DETYRA 2

            Menaxher puntori1 = new Menaxher { Id = 01, Emri = "Vendim ", Pozita = "Menaxher", Rroga = 250000 };
            Zhvillues puntori2 = new Zhvillues { Id = 02, Emri = "Elion", Pozita = "Zhvillues", Rroga = 300000 };
            Admin puntori3 = new Admin { Id = 03, Emri = "Filani", Pozita = "Admin", Rroga = 60000 };

            double bonusiPuntorit1 = puntori1.CalculateBonus(puntori1.Rroga);
            Console.WriteLine(bonusiPuntorit1);

            double bonusiPuntorit2 = puntori2.CalculateBonus(puntori1.Rroga);
            Console.WriteLine(bonusiPuntorit2);

            double bonusiPuntorit3 = puntori3.CalculateBonus(puntori1.Rroga);
            Console.WriteLine(bonusiPuntorit3);

            Console.ReadKey();
        }
    }
}
