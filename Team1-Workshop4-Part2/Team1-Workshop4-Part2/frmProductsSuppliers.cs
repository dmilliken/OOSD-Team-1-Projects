using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team1_Workshop4_Part2
{
    public partial class frmProductsSuppliers : Form
    {
        public frmProductsSuppliers()
        {
            InitializeComponent();
        }


        private void btnFindProducts_Click(object sender, EventArgs e)
        {
            // DM: this is the event handler for the "Find Products" button on the Products Tab

            // No need to validate since we are using a combobox

            // Call GetProductID method

            // Call DisplayProductInfo method

            // Call DisplaySupplierInfo method to display the supplier info on the next tab

            // Enable the Modify/Delete Buttons when the combo box is set
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // DM: This button allows the user to add a new product

            // Open Auxillary Form
            frmAddProduct addProductForm = new frmAddProduct();
            DialogResult result = addProductForm.ShowDialog();
            // create a new product object

            // Store textbox data in the product object

            // Display the new product


        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            // DM: This button allows the user to edit an existing product
            // Enabled when the productID combo box has a value

            // No Auxillary form, just enable the Product name text box

            // grab the product object from the main form

            // Display the product object information
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            // DM: Allows the user to delete a product
            // once a product object has been found, this button becomes enabled

            // Confirmation Message
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If yes, try to delete it

            // If the try fails, show an error message

            // else = success, then clear the form and disable the modify and delete buttons 
        }
    }
}
