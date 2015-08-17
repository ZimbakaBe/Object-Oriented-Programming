using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankOfKurtovoKonare
{
    internal interface IAcount
    {
        Customer Customer { get; set; }
        decimal Balance { get; set; }
        decimal InterestRate { get; set; }

        void DepositMoney(decimal money);

        decimal CalculateInterest(int months);
    }
}
