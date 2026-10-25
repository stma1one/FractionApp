using System;
using System.Collections.Generic;
using System.Text;

namespace FractionApp
{
    public class Fraction : ICalculatable,IComparable
    {
        public int Numerator { get; set; }
        private int denominator;
        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value != 0)
                {        
                    denominator = value;
                }
            }
        }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public object Add(object other)
        {
            if(!(other is Fraction b))
                return null;

            //Fraction b = (Fraction)other;
            int newDenominator = this.Denominator * b.Denominator;
            int newNumerator = (this.Numerator * b.Denominator) + (b.Numerator * this.Denominator);
            return new Fraction(newNumerator, newDenominator);
        }
        public object Minus(object other)
        {
            Fraction b= other as Fraction;
            if (b == null)
                return null;
            int newDenominator = this.Denominator * b.Denominator;
            int newNumerator = (this.Numerator * b.Denominator) - (b.Numerator * this.Denominator);
            return new Fraction(newNumerator, newDenominator);
        }

       
        
#region Comparison
public int CompareTo(object? obj)
{
   if (obj == null) return 1;
   if (!(obj is Fraction other))
       return -2;

   double result = (double)this.Numerator / this.Denominator - (double)other.Numerator / other.Denominator;

            if (result < 0) return -1;
            if (result > 0) return 1;
            return 0;
        }
#endregion

    }
}
