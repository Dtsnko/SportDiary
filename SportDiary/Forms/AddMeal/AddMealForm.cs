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
        List<Product> selectedProducts = new List<Product>();
        int i = 0;
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
            
            selectedProducts.Add(allProd[ProductsToAdd.SelectedIndex]);
            ProductsToAdd.Enabled = false;
            AddedProducts.Enabled = false;
            AddButton.Enabled = false;
            AcceptButton.Enabled = false;
            label1.Visible = true;
            NumericUpDownMass.Visible = true;
            AddMassButton.Visible = true;

            
            
            

        }

        private void AddMassButton_Click(object sender, EventArgs e)
        {
            selectedProducts[i].mass = NumericUpDownMass.Value;
            AddedProducts.Items.Add(selectedProducts[i].Name + " " + selectedProducts[i].mass + " грамм");
            i++;
            ProductsToAdd.Enabled = true;
            AddedProducts.Enabled = true;
            AddButton.Enabled = true;
            AcceptButton.Enabled = true;
            NumericUpDownMass.Visible = false;
            AddMassButton.Visible = false;
            label1.Visible = false;
            

        }
    }
}
