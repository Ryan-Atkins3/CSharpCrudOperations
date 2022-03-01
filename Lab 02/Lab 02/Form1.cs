using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //read all new text data
            string newItemName = txtNewItemName.Text;
            string newItemUpc = txtNewItemUPC.Text;
            double newStoreItemPrice = Convert.ToDouble(txtNewItemStorePrice.Text);
            string newItemAccessKey = txtNewItemAccessKey.Text;
            double newItemCostPerCase = Convert.ToDouble(txtNewItemCostPerCase.Text);
            int newItemUnitsPerCase = Convert.ToInt32(txtNewItemUnitsPerCase.Text);
            string newItemDistributor = txtNewItemDistributor.Text;

        }
    }
}
