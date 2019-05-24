using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person
            {
                Age = 12,
                Fam = "Petrov",
                Salary = 88000
            };
            Console.WriteLine(a.Age);
            Console.WriteLine(a.Fam);
            Console.WriteLine(a.Salary);
            a.Fam = "Sidorov";
            Console.WriteLine(a.Fam);

            Rational rat1 = new Rational(1, 2);
            Rational.PrintRational(rat1);
            Rational rat2 = new Rational(2, 4);
            Rational.PrintRational(rat2);
            Rational.PrintRational(Rational.Plus(rat1,rat2));
            //Rational.PrintRational(Rational.Minus(rat1, rat2));
            //Rational.PrintRational(Rational.Divide(rat1, rat2));
            //Rational.PrintRational(Rational.Mult(rat1, rat2));
            Random a1 = new Random();
            Random b1 = new Random();
            for (int i = 0; i < 3; i++)
            {
                Rational r = new Rational(b1.Next(10, 20), a1.Next(1, 10));
                Rational.PrintRational(r);
            }
            Rational r1 = new Rational(1, 7), r2 = new Rational(1, 5);
            Console.WriteLine("Сумма чисел: ");
            Rational.PrintRational(r1);
            Rational.PrintRational(r2);
            Console.WriteLine(" = ");
            Rational.PrintRational(Rational.Plus(r1 , r2));

            //Rational.PrintRational();
            //Console.WriteLine($"{r1} + {r2} = " + (r1 + r2));
            //Console.WriteLine($"{r1} + {r2} = " + (r1 - r2));
        }
    }
}
