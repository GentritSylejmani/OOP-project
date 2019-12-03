using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Client : Person
    {
        public Client()
        {


        }

        public override bool LogInCheck(string username, string password)
        {
            
                foreach (var user in Lists.ClientsList)
                {
                    if (user.Username==username && user.Password==password)
                        return true;

                }
            return false;
            
        }

        public override Person GetUserInfo(string username)
        {
            
            var person = new Client();          

            foreach(var user in Lists.ClientsList)
            {
                 if(username==user.Username)
                 {
                    person.Name = user.Name;
                    person.Surname = user.Surname;
                    person.PhoneNo = user.PhoneNo;
                    person.Username = user.Username;
                    person.Email = user.Email;
                    person.PersonalNo = user.PersonalNo;
                    person.AccountNo = user.AccountNo;
                    person.Credit = user.Credit;
                 }
                return person;
            }
            return null; ;
        }

        public void PayProduct() { }
        public void BidOnProduct() { }

    }
}
