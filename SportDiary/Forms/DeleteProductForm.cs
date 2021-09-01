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
        public DeleteProductForm()
        {
            InitializeComponent();
            DBConnect connect = new DBConnect();
            List<string>[] products = connect.Select();
            for (int i = 0; i < products[0].Count; i++)
                listBoxOfProducts.Items.Add(products[0][i] + " " + products[1][i] + " " + products[2][i] + "кал.");
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
  
            if (listBoxOfProducts.CheckedItems.Count != 0)
            {
                List<int> id = new List<int>();
                for (int x = 0; x < listBoxOfProducts.CheckedItems.Count; x++)
                {
                    string str = listBoxOfProducts.CheckedItems[x].ToString();
                    int index = str.IndexOf(" ");
                    id.Add(Convert.ToInt32(listBoxOfProducts.CheckedItems[x].ToString().Substring(0, index)));
                     
                }
                DBConnect connect = new DBConnect();
                connect.Delete(id);
                MessageBox.Show("Успешно удалено");
                Close();
            }
            else
                MessageBox.Show("Не было выбрано ни одного элемента");

        }
    }
}
