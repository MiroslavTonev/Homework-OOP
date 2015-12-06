using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2FractionCalculator
{
    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get
            {
                return this.numerator;
            }
            private set
            {
                if(value > long.MaxValue || value < long.MinValue)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Denumerator must be in range [{0}- {1}]", long.MinValue, long.MaxValue));
                }
                this.numerator = value;
            }
        }
        public long Denominator
        {
            get
            {
                return this.denominator;
            }
            private set
            {
                if(value == 0)
                {
                    throw new ArgumentException("Denominator cannot be 0");
                }
                else if(value > long.MaxValue || value < long.MinValue)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Denumerator must be in range [{0}- {1}]", long.MinValue, long.MaxValue));
                }
                this.denominator = value;
            }
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            var newNumerator = (a.numerator * b.denominator) + (a.denominator * b.numerator);
            var newDenumerator = (a.denominator * b.denominator);
            return new Fraction(newNumerator, newDenumerator);
        }
        
        public static  Fraction operator -(Fraction a, Fraction b)
        {
            var newNumerator = (a.numerator * b.denominator) - (a.denominator * b.numerator);
            var newDenumerator = (a.denominator * b.denominator);
            return new Fraction(newNumerator, newDenumerator);
        }

        public override string ToString()
        {
            return (Numerator / (decimal)Denominator).ToString();
        }
    }
}
