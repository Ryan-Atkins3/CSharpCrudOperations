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

        List<Item> products = new List<Item>();
        int foundPosition;
    public Form1()
        {
            InitializeComponent();

            Item bottleRockets = new Item();
            bottleRockets.Name = "Bottle Rockets";
            bottleRockets.Upc = "1235-8978";
            bottleRockets.StorePrice = 15.00;
            bottleRockets.CostPerCase = 100.00;
            bottleRockets.UnitCount = 50;
            bottleRockets.Distributor = "Black Cat";
            products.Add(bottleRockets);

            Item romanCandles = new Item();
            romanCandles.Name = "Roman Candles";
            romanCandles.Upc = "9875-4321";
            romanCandles.StorePrice = 20;
            romanCandles.CostPerCase = 150;
            bottleRockets.UnitCount = 80;
            romanCandles.Distributor = "Black Cat";
            products.Add(romanCandles);

            Item tnt = new Item();
            tnt.Name = "TNT";
            tnt.Upc = "1000-1000";
            tnt.StorePrice = 100;
            tnt.CostPerCase = 90;
            tnt.UnitCount = 1;
            tnt.Distributor = "Acme";
            products.Add(tnt);

            Item firecrackers = new Item();
            firecrackers.Name = "Firecrackers";
            firecrackers.Upc = "1738-1738";
            firecrackers.StorePrice = 25;
            firecrackers.CostPerCase = 30;
            firecrackers.UnitCount = 25;
            firecrackers.Distributor = "Acme";
            products.Add(firecrackers);

            Item sparklers = new Item();
            sparklers.Name = "Sparklers";
            sparklers.Upc = "4321-1234";
            sparklers.StorePrice = 5;
            sparklers.CostPerCase = 50;
            sparklers.UnitCount = 100;
            sparklers.Distributor = "Black Cat";
            products.Add(sparklers);
            

            }       


    private void btnNameSearch_Click(object sender, EventArgs e)
        {
            string nameSearch = txtNameSearch.Text.ToLower();
            bool found = false;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Name.ToLower().Contains(nameSearch))
                {
                    found = true;
                    lblName.Text = products[i].Name;
                    lblStorePrice.Text = $"{products[i].StorePrice:c}";
                    lblUPC.Text = products[i].Upc;
                    lblCostPerCase.Text = $"{ products[i].CostPerCase:C}";
                    lblUnitsPerCase.Text = products[i].UnitCount.ToString();
                    lblDistributor.Text = products[i].Distributor.ToString();
                    foundPosition = i;

                }
            }
            if (!found)
            {
                lblName.Text = "Item Not Found";
                lblStorePrice.Text = "Item Not Found";
                lblUPC.Text = "Item Not Found";
                lblCostPerCase.Text = "Item Not Found";
                lblUnitsPerCase.Text = "Item Not Found";
                lblDistributor.Text = "Item Not Found";
            }
        }

        private void btnUPCSearch_Click(object sender, EventArgs e)
        {
            string UpcSearch = txtUPCSearch.Text;
            bool found = false;
            for (int i = 0; i < products.Count; i++)
            {
                if (UpcSearch == products[i].Upc)
                {
                    found = true;
                    lblName.Text = products[i].Name;
                    lblStorePrice.Text = $"{products[i].StorePrice:c}";
                    lblUPC.Text = products[i].Upc;
                    lblCostPerCase.Text = $"{ products[i].CostPerCase:C}";
                    lblUnitsPerCase.Text = products[i].UnitCount.ToString();
                    lblDistributor.Text = products[i].Distributor.ToString();
                    foundPosition = i;
                }
            }

            if (!found)
            {
                lblName.Text = "Item Not Found";
                lblStorePrice.Text = "Item Not Found";
                lblUPC.Text = "Item Not Found";
                lblCostPerCase.Text = "Item Not Found";
                lblUnitsPerCase.Text = "Item Not Found";
                lblDistributor.Text = "Item Not Found";
            }

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


            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Upc != newItemUpc)
                {
                    if (newItemAccessKey == "1234")
                    {
                        products.Add(new Item()
                        {
                            Name = newItemName,
                            Upc = newItemUpc,
                            StorePrice = newStoreItemPrice,
                            AccessKey = newItemAccessKey,
                            CostPerCase = newItemCostPerCase,
                            UnitCount = newItemUnitsPerCase,
                            Distributor = newItemDistributor,
                        });
                        txtNewItemAccessKey.Text = "";
                        txtNewItemCostPerCase.Text = "";
                        txtNewItemDistributor.Text = "";
                        txtNewItemName.Text = "";
                        txtNewItemStorePrice.Text = "";
                        txtNewItemUnitsPerCase.Text = "";
                        txtNewItemUPC.Text = "";
                    }

                    else
                    {
                        lblAddItemAccessErrorMessage.Text = "Access Key Incorrect";
                    }
                }
                else
                {
                    lblAddItemAccessErrorMessage.Text = "UPC is duplicated!";
                }
            }
            
        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            if (txtChangePriceAccessKey.Text == "1234")
            {
                products[foundPosition].StorePrice = Convert.ToDouble(txtNewPrice);
            }
            else
            {
                lblChangePriceAccessKeyError.Text = "Access Key Incorrect";
            }
        }
    }
}
