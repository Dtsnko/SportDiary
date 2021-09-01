using SportDiary.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportDiary
{
    public partial class Main : Form
    {
        public Main()
        {

            InitializeComponent();
        }

        private void AddNewMeat_Click(object sender, EventArgs e)
        {
            AddMealForm addmeat = new AddMealForm();
            addmeat.Show();
        }

        private void AddNewProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addproduct = new AddProductForm();
            addproduct.Show();
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            DeleteProductForm delproduct = new DeleteProductForm();
            delproduct.Show();
            
        }
    }
}
