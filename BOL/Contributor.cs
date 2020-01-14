﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Contributor : Client
    {
        public Contributor()
        {

           
        }

        public double Rating { get; set; }

        public override bool LogInCheck(string username, string password)
        {
            foreach (var user in Lists.ContributorsList)
            {
                if (user.Username == username && user.Password == password)
                    return true;
               

            }
            return false;
        }

        public override Person GetUserInfo(string username)
        {
            var person = new Contributor();

            foreach (Person user in Lists.ContributorsList)
            {
                if (user.Username ==username)
                {
                    person.Name = user.Name;
                    person.Surname = user.Surname;
                    person.PhoneNo = user.PhoneNo;
                    person.Username = user.Username;
                    person.Email = user.Email;
                    person.PersonalNo = user.PersonalNo;
                    person.AccountNo = user.AccountNo;
                    person.Credit = user.Credit;
                    return person;
                }               
            }
            return null;
        }

        public void SubmitAuctionRequest() { }
        public void EditAuction() { }
        public void CancelAuction() { }

    }
}
