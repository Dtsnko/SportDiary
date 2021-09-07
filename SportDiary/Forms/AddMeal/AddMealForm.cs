using SportDiary.Forms.AddMeal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportDiary.Forms
{
    public partial class AddMealForm : Form
    {
        List<Product> allProd = new List<Product>();
        public AddMealForm()
        {
            InitializeComponent();
            DBProductsConnect connect = new DBProductsConnect();
            for (int i = 0; i < connect.SelectProducts()[0].Count; i++)
            {
                allProd.Add(new Product(Convert.ToInt32(connect.SelectProducts()[0][i]), connect.SelectProducts()[1][i], Convert.ToDecimal(connect.SelectProducts()[2][i]), Convert.ToDecimal(connect.SelectProducts()[3][i]), Convert.ToDecimal(connect.SelectProducts()[4][i]), Convert.ToDecimal(connect.SelectProducts()[5][i])));
                ProductsToAdd.Items.Add(allProd[i].Name + " " + allProd[i].Calories + " кал.");
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            List<int> indexes = new List<int>();
            foreach(string s in ProductsToAdd.Items)
                if (ProductsToAdd.CheckedItems.IndexOf(s) != -1)
                    indexes.Add(ProductsToAdd.Items.IndexOf(s));
            foreach (int i in indexes)
            {
                SelectMass ProdMass = new SelectMass();
                ProdMass.Show();
                
            }

            foreach (int i in indexes)
            {
                ProductsToAdd.Items.Remove(allProd[i].Name + " " + allProd[i].Calories + " кал.");
                AddedProducts.Items.Add(allProd[i].Name + " " + allProd[i].Calories + " кал." + allProd[i].mass);
            }

        }
    }
}
