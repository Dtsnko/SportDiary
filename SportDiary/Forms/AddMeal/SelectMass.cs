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
        Product prodWithMass;
        public SelectMass(ref Product prodToAddMass)
        {
            InitializeComponent();
            LabelSelectMass.AutoSize = true;
            LabelSelectMass.Text = $"Укажите массу \n '{prodToAddMass.Name}'";
            prodWithMass = prodToAddMass;
            
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {

            prodWithMass.mass = UpDownMass.Value;
            
        }
    }
}
