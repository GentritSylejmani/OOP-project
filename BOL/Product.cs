using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{


    public class Product
    {
        public Product()
        {

        }

        public Product(string name, string description, double startingPrice, DateTime EndTime, string[] images, Contributor seller)
        {
            Name = name;
            Description = description;
            StartingPrice = startingPrice;
            AuctionEndDateTime = EndTime;
            productPicture = images;
            sellersUsername = seller;
        }

        private int _productID;
        private string _name;      
        public double _startingPrice;
        public double _currentBidPrice;
        private double _soldPrice;

        public enum Priority
        {
            Ulet,
            Mesem, 
            Larte
        }

        public enum Status
        {
            Pending,
            Active,
            Canceled,
            Ended,
            Sold
        }

        public enum ProductCategory
        {
            Gjenrale,
            Automjet,
            Teknike_e_bardhe,
            Teknologji,
            Agrokulture
        }

        public Status status { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description{get;set;}
        public double StartingPrice { get; set; }    
        public double CurrentBidPrice { get; set; }
        public double SoldPrice { get; set; }
        public ProductCategory Category { get; set; }      
        public DateTime AuctionStartDateTime { get; set; }
        public DateTime AuctionEndDateTime { get; set; }
        public Contributor sellersUsername { get; set; }
        public Person buyerID { get; set; }
        public Person bidder { get; set; }
        public string[] productPicture { get; set; }
        public int ViewCount { get; set; }

        public int GetLastID()
        {
            int maxValue = 0;

            if (Lists.productListings.Count() == 0)
            {
                return 0;
            }
            else
            {
                foreach (var item in Lists.productListings)
                {
                    if (item.ProductID > maxValue)
                    {
                        maxValue = item.ProductID;
                    }
                }

                return maxValue;
            }
        }


    }
}
