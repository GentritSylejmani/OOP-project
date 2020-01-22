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

        public static new Client GetUserInfo(string username)
        {

            var user = Lists.ClientsList.FirstOrDefault(x => x.Username.ToLower() == username);

            if (user != null)
            {
                return user;
            }
            return null;
        }

        public void PayProduct() { }
        public void BidOnProduct(Product product,double bidValue,Person loggedUser)
        {
            var item = Lists.productListings.FirstOrDefault(x => x.ProductID == product.ProductID);
            if (item != null)
            {
                item.CurrentBidPrice = bidValue;
                item.bidder = loggedUser;
            }
        }

        public void RateUser(int rateValue,Contributor seller)
        {
            seller.rejtingu.AddRating(rateValue, seller);
        }

    }
}
