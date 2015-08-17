using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.InterestCalculator
{

    class InterestCalculator
    {
        private decimal money;
        private decimal interest;
        private int years;
        public decimal Result { get; set; }

        public InterestCalculator(decimal money, decimal interest, int years,
            Func<decimal, decimal, int, decimal> result)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.Result = result(money, interest, years);
        }

        public decimal Money
        {
            get {return this.money;}
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Total money cannot be negative.");
                }
                this.money = value;
            }
        }

        public decimal Interest
        {
            get { return this.interest; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Interest should have positive value.");
                }
                this.interest = value;
            }
        }

        public int Years
        {
            get { return this.years; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Number of years cannot be negative.");
                }
                this.years = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Money: {0}\nInterest: {1}%\nYears:{2}\nResult: {3:F4}", this.Money, this.Interest, this.Years, this.Result);
        }
    }
}
