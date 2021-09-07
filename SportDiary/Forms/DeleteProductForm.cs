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
    public partial class DeleteProductForm : Form
    {
        private List<int> allId = new List<int>();
        public DeleteProductForm()
        {
            InitializeComponent();
            DBProductsConnect connect = new DBProductsConnect();
            List<string>[] products = connect.SelectProducts();
            for (int i = 0; i < products[0].Count; i++)
            {
                listBoxOfProducts.Items.Add(products[1][i] + " " + products[2][i] + "кал.");
                allId.Add(Convert.ToInt32(products[0][i]));
            }
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listBoxOfProducts.CheckedItems.Count == 0)
                MessageBox.Show("Не было выбрано ни одного элемента");
            List<int> checkedId = new List<int>();
            foreach (int c in listBoxOfProducts.CheckedIndices)
                checkedId.Add(allId[c]);
            DBProductsConnect connect = new DBProductsConnect();
            connect.DeleteProduct(checkedId);
            Close();
        }
    }
}
