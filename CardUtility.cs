using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A_Final_MagicCardManager
{
    internal class CardUtility
    {
        public static void DescribeCard(string name, double price)
        {
            Console.WriteLine($"- Name: {name}");
            Console.WriteLine($"- Price: ${price}");
        }
    }
}
