using MySql.Data.MySqlClient;
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
    public partial class UpdateProductForm : Form
    {
        private List<int> allId = new List<int>();
        private Dictionary<string, int> idNamePairs = new Dictionary<string, int>();
        public UpdateProductForm()
        {
            
            InitializeComponent();
            DBProductsConnect connect = new DBProductsConnect();
            List<string>[] products = connect.SelectAllProducts();
            for (int i = 0; i < products[0].Count; i++)
            {
                listBoxProductsToUpdate.Items.Add(products[1][i] + " " + products[2][i] + "кал.");
                allId.Add(Convert.ToInt32(products[0][i]));
                idNamePairs.Add(products[1][i], Convert.ToInt32(products[0][i]));
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            listBoxProductsToUpdate.Items.Clear();
            DBProductsConnect connect = new DBProductsConnect();
            List<string>[] selectedItem = connect.SelectSeveralProducts(textBoxSearch.Text);
            for (int i = 0; i < selectedItem[0].Count; i++)
            {
                listBoxProductsToUpdate.Items.Add(selectedItem[1][i] + " " + selectedItem[2][i] + "кал.");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (listBoxProductsToUpdate.SelectedIndex == null)
                return;
            int id = allId[listBoxProductsToUpdate.SelectedIndex];
            EditProductForm edpr = new EditProductForm(id);
            edpr.Show();
        }
    }
}
