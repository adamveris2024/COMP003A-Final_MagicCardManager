using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A_Final_MagicCardManager
{
    internal class Blue : Card
    {
        public Blue(string name, int price) : base(name, price)
        {
        }
        public override void ColorDescription()
        {
            Console.WriteLine("Blue is one of the five Colors of mana in Magic. It is drawn from islands and embodies the concepts of logic and technology.[2] The mana symbol for Blue is a drop of water.");
        }
    }
}
