using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportDiary
{
    public class Product
    {
        private string name;
        public string Name {
            get { return name; } 
            set { 
                if (value == null)
                    MessageBox.Show("Не правильно задано имя");
                else 
                    name = value; 
            } 
        }
        private decimal calories;
        public decimal Calories
        {
            get { return calories; }
            set
            {
                if (value > 0)
                    calories = value;
            }
        }
        private decimal proteins;
        public decimal Proteins
        {
            get { return proteins; }
            set
            {
                if (value > 0)
                    proteins = value;
            }
        }
        private decimal fats;
        public decimal Fats
        {
            get { return fats; }
            set
            {
                if (value > 0)
                    fats = value;
            }
        }
        private decimal carbohydrates;
        public decimal Carbohydrates
        {
            get { return carbohydrates; }
            set
            {
                if (value > 0)
                    carbohydrates = value;
            }
        }
        public decimal controlBit;
        public Product(string name, decimal calories, decimal proteins, decimal fats, decimal carbohydrates)
        {
            Name = name;
            Calories = calories;
            Fats = fats;
            Proteins = proteins;
            Carbohydrates = carbohydrates;
            controlBit = calories + proteins + fats + carbohydrates;
            
        }

    }
}
