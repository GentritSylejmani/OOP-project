using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Product
    {
        public string ProductID;
        public string Name;
        public string Description;
        public double StartingPrice;
        public double currentBidPrice;
        public double SoldPrice;
        public DateTime AuctionStartDateTime;
        public DateTime AuctionEndDateTime;
        public Contributor sellersUsername;
        public Client buyerID;
        string[] roductPicture;

        

    }
}
