using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Finances //transactions
    {
        public Finances()
        {

        }

        public Finances(int accountno, double balance)
        {
            _accountNo = accountno;
            _balance = balance;
        }

        private int _accountNo;
        private double _balance;

        public int AccountNo
        {
            get { return _accountNo; }
            set { value = _accountNo; }
        }

        public double Balance
        {
            get { return _balance; }
            set { value = _balance; }

        }

        private void AddCredit(double value)
        {
            _balance += value;
        }

        private void DebitCredit(double value)
        {
            _balance -= value;
        }


    }

}
