using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOL;

namespace OOP_project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string[] images = new string[] { "", "", "", "", "", "", "" };

            Lists.ContributorsList.Add(new Contributor {bidProducts = new List<int>(), rejtingu= new Contributor.Rating() { ratings = new List<int>(new int[]{1,2,3 })}, Name = "Alban", Surname = "Zekolli", Email = "alban.zekolli@riinvest.net", Username = "alban", Password = "alban", UserType = Person.usertype.Contributor, PersonalNo = "123456789", PhoneNo = "+38344123456", AccountNo = 46374, Credit = 500.00 });
            Lists.ContributorsList.Add(new Contributor {testPerDispay="fillestar",bidProducts = new List<int>(), rejtingu = new Contributor.Rating() { ratings = new List<int>(new int[]{1, 2, 3 })}, Name = "Gentrit", Surname = "Sylejmani", Email = "gentrit.sylejmani@riinvest.net", Username = "chromogs", Password = "Genti.11", UserType = Person.usertype.Contributor, PersonalNo = "1170808050", PhoneNo = "+38345216333", AccountNo = 46373, Credit = 500.00 });
            Lists.ClientsList.Add(new Client { bidProducts = new List<int>(), Name = "Afrim", Surname = "Sylejmani", Email = "gentrit.sylejmani@riinvest.net", Username = "afrim", Password = "afrim", UserType = Person.usertype.Client, PersonalNo = "987654321", PhoneNo = "+38344654321", AccountNo = 46375, Credit = 500.00 });
            Lists.productListings.Add(new Product { ViewCount = 0, ProductID = 1, productPicture= images,Name = "test", Description = "test",AuctionStartDateTime= DateTime.Now,AuctionEndDateTime = DateTime.Now.AddMinutes(1), StartingPrice = 100, CurrentBidPrice = 100, sellersUsername = new Contributor() { Username = "chromogs" } });
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn());
        }
    }
}
