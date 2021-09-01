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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {

            InitializeComponent();
        }

        private void ButtonAcceptNewProduct_Click(object sender, EventArgs e)
        {
                Product newProduct = new Product(textBoxProductName.Text, numericUpDownCalories.Value, numericUpDownProteins.Value, numericUpDownFats.Value, numericUpDownCarbohydrates.Value);
                DBProductsConnect db = new DBProductsConnect();
                db.InsertProduct(newProduct);
                Close();
                
        }
    }
}
