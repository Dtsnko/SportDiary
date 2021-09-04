using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportDiary.Forms.AddMeal
{
    public partial class SelectMass : Form
    {
        Product productWithMass;
        public SelectMass(ref Product product)
        {
            productWithMass = product;
            InitializeComponent();
            LabelSelectMass.AutoSize = true;
            LabelSelectMass.Text = $"Укажите массу продукта \n '{productWithMass.Name}'";
            
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {

            productWithMass.mass = UpDownMass.Value;
        }
    }
}
