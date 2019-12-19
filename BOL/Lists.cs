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
        
        }

        public Lists(string name,string surname,string username,string personalno,string password,string email)
        {

        }

       
        #region ProductLists
        public static List<Product> PendingRequests = new List<Product>();
        public static List<Product> ApprovedRequests = new List<Product>();
        public static List<Product> DeniedRequests = new List<Product>();
        public static List<Product> SoldProducts = new List<Product>();

        public List<Product> listings
        {
            get { return ApprovedRequests; }
        }
        #endregion

        #region UserLists
        public static List<Administrator> AdministratorsList = new List<Administrator>();
        public static List<Contributor> ContributorsList = new List<Contributor>();
        public static List<Client> ClientsList = new List<Client>();
        #endregion
    }
}
