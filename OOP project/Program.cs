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
            Lists.ContributorsList.Add(new Contributor { Name = "Alban", Surname = "Sylejmani", Email = "gentrit.sylejmani@riinvest.net", Username = "alban", Password = "Genti.11", UserType = Person.usertype.Contributor, PersonalNo = "1170808050", PhoneNo = "+38345216333", AccountNo = 46373, Credit = 500.00 });
            Lists.ContributorsList.Add(new Contributor { Name = "Gentrit", Surname = "Sylejmani", Email = "gentrit.sylejmani@riinvest.net",Username="chromogs" , Password = "Genti.11", UserType = Person.usertype.Contributor, PersonalNo = "1170808050", PhoneNo = "+38345216333", AccountNo = 46373, Credit = 500.00 });
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn());
        }
    }
}
