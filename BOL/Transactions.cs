using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{

    public class Transactions
    {
        public double CreditMoney(double balance, double money)
        {
            return balance + money;
        }

        public double DebitMoney(double balance, double money)
        {
            return balance - money;
        }
    }

}
