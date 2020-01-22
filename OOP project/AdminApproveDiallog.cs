using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOL;
namespace OOP_project
{
    public partial class AdminApproveDialog : Form
    {
        public AdminApproveDialog()
        {
            //InitializeComponent();
        }

        public AdminApproveDialog(Product product)
        {
            InitializeComponent();
            lbl_ProductIDValue.Text = product.ProductID.ToString();

            Product = product;
        }

        Product Product = null;

        private void AdminApproveDialog_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Deny_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Approve_Click(object sender, EventArgs e)
        {
            var itemToBeApproved = Lists.productListings.SingleOrDefault(x => x.ProductID == Product.ProductID);

            if (itemToBeApproved != null)
            {
                itemToBeApproved.status = Product.Status.Active;
            }

            this.Close();
        }

        
    }
}
