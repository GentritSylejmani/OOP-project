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

            //Contributor.Rating rating = new Contributor.Rating();

            string[] images = new string[] { "", "", "", "", "", "", "" };

            Lists.ContributorsList.Add(new Contributor { rejtingu= new Contributor.Rating() { ratings = new List<int>(new int[]{1,2,3 })}, Name = "Alban", Surname = "Sylejmani", Email = "gentrit.sylejmani@riinvest.net", Username = "alban", Password = "Genti.11", UserType = Person.usertype.Contributor, PersonalNo = "1170808050", PhoneNo = "+38345216333", AccountNo = 46373, Credit = 500.00 });
            Lists.ContributorsList.Add(new Contributor { rejtingu = new Contributor.Rating() { ratings = new List<int>(new int[] { 1, 2, 3 }) }, Name = "Gentrit", Surname = "Sylejmani", Email = "gentrit.sylejmani@riinvest.net", Username = "chromogs", Password = "Genti.11", UserType = Person.usertype.Contributor, PersonalNo = "1170808050", PhoneNo = "+38345216333", AccountNo = 46373, Credit = 500.00 });
            Lists.ClientsList.Add(new Client { Name = "Afrim", Surname = "Sylejmani", Email = "gentrit.sylejmani@riinvest.net", Username = "afrim", Password = "Genti.11", UserType = Person.usertype.Client, PersonalNo = "1170808050", PhoneNo = "+38345216333", AccountNo = 46373, Credit = 500.00 });
            Lists.productListings.Add(new Product { ProductID = 1, productPicture= images,Name = "test", Description = "test", StartingPrice = 100, CurrentBidPrice = 100, sellersUsername = new Contributor() { Username = "chromogs" } });
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn());
        }
    }
}
