using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.FractionCalculator
{
    struct Fraction
    {
        public int Numerator { get; set; }
        private int denominator;

        public Fraction(int numerator, int denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;

            if (Denominator < 0)
            {
                this.Numerator = -this.Numerator;
                this.Denominator = -this.Denominator;
            }
        }

        public int Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator cannot be 0.");
                }
                this.denominator = value;
            }
        }

        public static int DetermineLCM(int a, int b)
        {
            int num1, num2;
            if (a > b)
            {
                num1 = b;
                num2 = a;
            }
            else
            {
                num1 = a;
                num2 = b;
            }

            for (int i = 1; i <= num1; i++)
            {
                if ((num2*i) % num1 == 0)
                {
                    return i*num2;
                }
            }
            return num1;
        }

        public Fraction ToDenominator(int targetDenominator)
        {
            Fraction modifiedFraction = this;

            if (targetDenominator < this.Denominator)
            {
                return modifiedFraction;
            }

            if (targetDenominator % this.Denominator != 0)
            {
                return modifiedFraction;
            }

            if (this.Denominator != targetDenominator)
            {
                int factor = targetDenominator%this.Denominator;
                modifiedFraction.Numerator = targetDenominator;
                modifiedFraction.Denominator *= factor;
            }
            return modifiedFraction;
        }

        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            if (fraction1.Denominator == 0)
            {
                return fraction2;
            }
            if (fraction2.Denominator == 0)
            {
                return fraction1;
            }
            int lcd = DetermineLCM(fraction1.Denominator, fraction2.Denominator);

            fraction1 = fraction1.ToDenominator(lcd);
            fraction2 = fraction2.ToDenominator(lcd);

            return new Fraction(fraction1.Numerator + fraction2.Numerator, lcd);
        }

        public override string ToString()
        {
            return String.Format("{0}\n{1}\n{2}", +(this.Numerator), DetermineLCM(this.Numerator, this.Denominator)+(this.Denominator));
        }
    }
}
