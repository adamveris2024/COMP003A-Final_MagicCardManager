using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A_Final_MagicCardManager
{
    abstract internal class Card
    {
        private string _name;
        private double _price;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Card name is empty.");
                }
                _name = value;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (double.IsNegative(value))
                {
                    throw new ArgumentException("Card price is below 0.");
                }
                _price = value;
            }
        }

        public Card(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public abstract void ColorDescription();


    }
}
