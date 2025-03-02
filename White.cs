using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A_Final_MagicCardManager
{
    internal class White : Card
    {
        public White(string name, int price) : base(name, price)
        {
        }
        public override void ColorDescription()
        {
            Console.WriteLine("White is one of the five Colors of mana in Magic. It is drawn from the plains and embodies the principles of morality and order.");
        }
    }
}
