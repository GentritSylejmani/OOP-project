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

        private string _productID;
        private string _name;      
        public double _startingPrice;
        public double _currentBidPrice;
        private double _soldPrice;
        public enum ProductCategory
        {
            Gjeneral,
            Automjet,
            Teknike_e_bardhe,
            Teknologji

        }

        public string ProductID { get; set; }
        public string Name { get; set; }
        public string Description{get;set;}
        public double StartingPrice { get; set; }    
        public double CurrentBidPrice { get; set; }
        public double SoldPrice { get; set; }
        public ProductCategory Category { get; set; }      
        public DateTime AuctionStartDateTime { get; set; }
        public DateTime AuctionEndDateTime { get; set; }
        public Contributor sellersUsername { get; set; }
        public Client buyerID { get; set; }
        public string[] productPicture { get; set; }




    }
}
