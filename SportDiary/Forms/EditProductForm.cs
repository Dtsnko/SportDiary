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
    public partial class EditProductForm : Form
    {
        int prodId;
        public EditProductForm(int id)
        {
            prodId = id;
            InitializeComponent();
            
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            Product newProd = new Product(0, "newProduct", UpDownCalories.Value, UpDownProteins.Value, UpDownFats.Value, UpDownCarbohydrates.Value);
            DBProductsConnect connect = new DBProductsConnect();
            connect.UpdateCalories(prodId, newProd);
            Close();
        }
    }
}
