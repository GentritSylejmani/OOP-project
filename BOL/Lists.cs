using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Lists
    {
        public Lists()
        {
            AdministratorsList.Add(new Administrator { Name = "Gentrit", Surname = "Sylejmani", Username = "chromgos", PersonalNo = "1170808050", Password = "Genti1234", Email = "gentrit.sylejmani@riinvest.net" });
            ContributorsList.Add(new Contributor { Name = "Kastriot", Surname = "Selmani", Username = "kastro", PersonalNo = "123456789", Password = "kastro1", Email = "kastriot@hotmail.com" });
            ClientsList.Add(new Client { Name = "Benjamin", Surname = "Gecaj", Username = "beni", PersonalNo = "987654321", Password = "beni1", Email = "benjamin@hotmail.com" });


        }
        public Lists(string name,string surname,string username,string personalno,string password,string email)
        {

        }

       
        #region ProductLists
        public List<Product> PendingRequests = new List<Product>();
        public List<Product> ApprovedRequests = new List<Product>();
        public List<Product> DeniedRequests = new List<Product>();
        public List<Product> SoldProducts = new List<Product>();
        #endregion

        #region UserLists
        public static List<Administrator> AdministratorsList = new List<Administrator>();
        public static List<Contributor> ContributorsList = new List<Contributor>();
        public static List<Client> ClientsList = new List<Client>();
        #endregion
    }
}
