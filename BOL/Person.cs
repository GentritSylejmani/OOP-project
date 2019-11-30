using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public abstract class Person
    {
        public Person()
        {

        }

        public Person(string name,string surname, string username, string personalno, string password,string email)
        {
            Name = name;
            Surname = surname;
            Username = username;
            PersonalNo = personalno;
            Password = password;
            Email = email;

        }

        public enum usertype
        {
            Administrator = 1,
            Contributor = 2,
            Client = 3

        }

        
        private string _name;
        private string _surname;
        private string _username;
        private string _personalNo;
        private string _phoneNo;
        private string _password;
        private string _email;
        private int _accountNo;
        private double _balance;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string PersonalNo
        {
            get { return _personalNo; }
            set { _personalNo = value; }
        }
        public string PhoneNo
        {
            get { return _phoneNo; }
            set { _phoneNo = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

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


        public usertype UserType;
        


        public virtual bool LogInCheck(string username, string password)
        {
            throw new NotImplementedException();
        }
        public bool SignUp(int ct,string name, string surname,string username,string phoneNo ,string personalNo, string password, string email,usertype usertype,int account,double moneyValue)
        {
            int clienttype = ct;

            Finances f = new Finances();

            int llog = f.AccountNo;
            double vlera = f.Balance;

            if (ct == 2)

            {
                Lists.ClientsList.Add(new Contributor { Name = name, Surname = surname, Username = username, PersonalNo = personalNo, PhoneNo = phoneNo, Password = password, Email = email, UserType = Person.usertype.Client, });
                return true;

                
            }
            else if (ct == 3)
            {
                Lists.ContributorsList.Add(new Contributor { Name = name, Surname = surname, Username = username, PersonalNo = personalNo, PhoneNo = phoneNo, Password = password, Email = email, UserType = Person.usertype.Client});
                return true;
            }

            else return false;
        }

        public virtual Person GetUserInfo(string username)
        {
            throw new NotImplementedException();
        }

        
    }
}
