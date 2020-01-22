using System;
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

        public Contributor(Person person)
        {

        }

        public class Rating
        {
            public Rating()
            {
                if (ratings.Count() == 0)
                {
                    currentRating = 0;
                }
                else
                {
                    currentRating = calculateRating();
                }
            }

            public void AddRating(int value, Contributor contributor)
            {
                var user = Lists.ContributorsList.FirstOrDefault(x => x.Username == contributor.Username);
                
                if(user!=null)
                {
                    user.rejtingu.ratings.Add(value);

                    currentRating = calculateRating();
                }             

            }

            public double currentRating;

            public int ratingCount()
            {
                return ratings.Count;
            }

            public List<int> ratings = new List<int>();

            public double calculateRating(int value)
            {
                double temprating = value;

                for (int i = 0; i < ratings.Count; i++)
                {
                    temprating = temprating + ratings[i];
                }

                return temprating / ratings.Count;
            }

            public double calculateRating()
            {
                double temprating = 0;

                for (int i = 0; i < ratings.Count(); i++)
                {
                    temprating = temprating + ratings[i];
                }

                return temprating / ratings.Count();
            }
        }

        public Rating rejtingu; // { get; set; }
        

        //public List<int> ratings;

        public override bool LogInCheck(string username, string password)
        {
            foreach (var user in Lists.ContributorsList)
            {
                if (user.Username == username && user.Password == password)
                    return true;
            }
            return false;
        }

        //public override Person GetUserInfo(string username)
        //{
        //    var person = new Contributor();

        //    foreach (Person user in Lists.ContributorsList)
        //    {
        //        if (user.Username == username)
        //        {
        //            person.Name = user.Name;
        //            person.Surname = user.Surname;
        //            person.PhoneNo = user.PhoneNo;
        //            person.Username = user.Username;
        //            person.Email = user.Email;
        //            person.PersonalNo = user.PersonalNo;
        //            person.AccountNo = user.AccountNo;
        //            person.Credit = user.Credit;
        //            return person;
        //        }
        //    }
        //    return null;
        //}

        public static new Contributor GetUserInfo(string username)
        {

          var user=  Lists.ContributorsList.FirstOrDefault(x => x.Username.ToLower() == username);

            if(user!=null)
            {
                return user;
            }
            return null;
            
        }

        public void SubmitAuctionRequest(string name, string description, double startingPrice, double currentBidPrice, DateTime auctionEta, string[] images, Contributor seller, Product.Status Status)
        {
            Product p = new Product();

            Lists.productListings.Add(new Product { ProductID = p.GetLastID() + 1, Name = name, Description = description, StartingPrice = startingPrice, CurrentBidPrice = currentBidPrice, AuctionStartDateTime = DateTime.Now, AuctionEndDateTime = auctionEta, productPicture = images, sellersUsername = seller, status = Status});

        }
        public void EditAuction() { }
        public void CancelAuction() { }


    }
}

