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

        public List<int> bidProducts = new List<int>();

        public void AddBiddedProduct(int productid)
        {
            bidProducts.Add(productid);
        }

        public void PayProduct(int productid, Person buyer, double payingprice)
        {
            var itemToBePiad = Lists.productListings.FirstOrDefault(x => x.ProductID == productid);
            var buyingClient = Lists.ClientsList.FirstOrDefault(x => x.Username == buyer.Username);
            var buyingContributor = Lists.ContributorsList.FirstOrDefault(x => x.Username == buyer.Username);
            if(itemToBePiad!=null)
            {
                itemToBePiad.status = Product.Status.Sold;
                itemToBePiad.SoldPrice = payingprice;
                itemToBePiad.buyerID = buyer;

                if(buyingClient!=null)
                {
                    buyingClient.Credit -= payingprice;
                }
                if (buyingContributor != null)
                {
                    buyingContributor.Credit -= payingprice;
                }
            }
        }
        public void BidOnProduct(Product product,double bidValue,Person loggedUser)
        {
            var item = Lists.productListings.FirstOrDefault(x => x.ProductID == product.ProductID);
            if (item != null)
            {
                if (item.AuctionEndDateTime - DateTime.Now < TimeSpan.FromSeconds(30))
                {
                    item.AuctionEndDateTime = item.AuctionEndDateTime.AddSeconds(30);
                }
                item.CurrentBidPrice = bidValue;
                item.bidder = loggedUser;

                if (((Client)loggedUser).bidProducts.Contains(product.ProductID) == false)
                {
                    AddBiddedProduct(item.ProductID);
                    
                }
            }
        }

        public void RateUser(int rateValue,Contributor seller)
        {
            seller.rejtingu.AddRating(rateValue, seller);
        }

    }
}
