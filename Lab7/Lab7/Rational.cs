using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Rational
    {
        public int numerator { get; set; }
        public int denominator { get; set; }
        public int delitleldivider;
        public int Delitleldivider
        {
            get
            {
                return delitleldivider;
            }
        }
        static readonly int one = 1;
        static readonly int zero = 0;

        public Rational()
        {
            delitleldivider = FindDeliteldivider(this.numerator, this.denominator);
        }
        public Rational(int n, int m)
        {
            numerator = n;
            denominator = m;
            delitleldivider = FindDeliteldivider(this.numerator, this.denominator);
        }
        private Rational(int a, int b, string t)
        {
            numerator = a; denominator = b;
            delitleldivider = FindDeliteldivider(this.numerator, this.denominator);
        }

        public static int FindDeliteldivider(int m, int n)
        {
            int min = (m <= n) ? m+1 : n+1;
            int end = 0;
            int i = 1;
            while (i < min)
            {
                if (m % i == 0 && n % i == 0)
                {
                    end = i;
                }
                i++;
            }
            return end;
        }
        public static void PrintRational(Rational obj)
        {
            Console.Write(obj.numerator + "/" + obj.denominator + " Общий делитель: ");
            if (obj.denominator != 0)
                Console.Write(obj.delitleldivider);
            else
                Console.Write("Деление на ноль");
            Console.WriteLine();
        }

        public static Rational operator +(Rational c1, Rational c2)
        {
            return new Rational {
                numerator = c1.numerator + c2.numerator,
                denominator = c2.denominator,
                delitleldivider = FindDeliteldivider(c1.numerator + c2.numerator, c2.denominator)

            };
        }
        public static Rational operator -(Rational c1, Rational c2)
        {
            return new Rational
            {
                numerator = c1.numerator - c2.numerator,
                denominator = c2.denominator,
                delitleldivider = FindDeliteldivider(c1.numerator - c2.numerator, c2.denominator)
            };
        }
        public static Rational operator /(Rational c1, Rational c2)
        {
            return new Rational
            {
                numerator = c1.numerator * c2.denominator,
                denominator = c1.denominator * c2.numerator,
                delitleldivider = FindDeliteldivider(c1.numerator * c2.denominator, c2.denominator)
            };
        }
        public static Rational operator *(Rational c1, Rational c2)
        {
            return new Rational
            {
                numerator = c1.numerator * c2.numerator,
                denominator = c1.denominator * c2.denominator,
                delitleldivider = FindDeliteldivider(c1.numerator * c2.numerator, c2.denominator)
            };
        }

        public static Rational Plus(Rational rat1, Rational rat2)
        {
            int a = rat1.denominator;
            int b = rat2.denominator;
            rat1.numerator *= b;
            rat1.denominator *= b;
            rat2.numerator *= a;
            rat2.denominator *= a;
            return  rat1 + rat2; 
        }
        public static Rational Minus(Rational rat1, Rational rat2)
        {
            int a = rat1.denominator;
            int b = rat2.denominator;
            rat1.numerator *= b;
            rat1.denominator *= b;
            rat2.numerator *= a;
            rat2.denominator *= a;
            return rat1 - rat2;
        }
        public static Rational Divide(Rational rat1, Rational rat2)
        {
            return rat1 / rat2;
        }
        public static Rational Mult(Rational rat1, Rational rat2)
        {
            return rat1 * rat2;
        }
        public static bool operator >(Rational a, Rational b)
        {
            if (a.numerator == b.numerator) return a.denominator > b.denominator;
            return ((double)a.denominator / (double)a.numerator) > ((double)b.denominator / (double)b.numerator);
        }
        public static bool operator >(Rational a, int b)
        {
            return ((double)a.denominator / (double)a.numerator) > b;
        }
        public static bool operator >(int b, Rational a)
        {
            return ((double)a.denominator / (double)a.numerator) > b;
        }
        public static bool operator <(Rational a, Rational b)
        {
            if (a.numerator == b.numerator) return a.denominator < b.denominator;
            return ((double)a.denominator / (double)a.numerator) < ((double)a.denominator / (double)a.numerator);
        }
        public static bool operator <(Rational a, int b)
        {
            return ((double)a.denominator / (double)a.numerator) < b;
        }
        public static bool operator <(int b, Rational a)
        {
            return ((double)a.denominator / (double)a.numerator) < b;
        }
    }
}
