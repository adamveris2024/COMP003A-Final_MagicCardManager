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
        private int _price;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                // Use the value parameter instead of Name property to prevent recursion.
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Card name is empty.");
                }
            }
        }
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                // Use the value parameter instead of Name property to prevent recursion.
                if (int.IsNegative(value))
                {
                    throw new ArgumentException("Card price is below 0.");
                }
            }
        }
    }
}
