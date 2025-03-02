using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A_Final_MagicCardManager
{
    internal class Black : Card
    {
        public Black(string name, double price) : base(name, price)
        {
        }
        public override void ColorDescription()
        {
            Console.WriteLine("Black is one of the five Colors of mana in Magic. It is drawn from the power of swamps and embodies the principles of free will and amorality. ");
        }
    }
}
