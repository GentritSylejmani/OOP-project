using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public enum ProductCategory
    {
        Veture,
        Teknike

    }

    

    public class Product
    {
        //public Product(string name, string description, double startingPrice, DateTime EndTime, string[] images, Contributor seller)
        //{
        //    Name = name;
        //    Description = description;
        //    StartingPrice = startingPrice;
        //    AuctionEndDateTime = EndTime;
        //    productPicture = images;
        //    sellersUsername = seller;
        //}

        public string ProductID;
        public string Name;
        public string Description;
        public double StartingPrice;
        public double CurrentBidPrice;
        public double SoldPrice;
        public DateTime AuctionStartDateTime;
        public DateTime AuctionEndDateTime;
        public Contributor sellersUsername;
        public Client buyerID;
        public string[] productPicture;

        

    }
}
