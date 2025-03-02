using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A_Final_MagicCardManager
{
    internal class Red : Card 
    {
        public Red(string name, int price) : base(name, price)
        {
        }
        public override void ColorDescription()
        {
            Console.WriteLine("Red is one of the five Colors of mana in Magic. It is drawn from the mountains and embodies the principles of impulse and chaos.");
        }
    }
}
