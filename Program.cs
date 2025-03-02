/// Author: Adam Verissismo
/// Course: COMP003A
/// Faculty: Jonathan Cruz
/// Purpose: Final - Magic the Gathering Card Manager
namespace COMP003A_Final_MagicCardManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Card> Cards = new List<Card>();
            // Menu
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("|                                                 |");
                Console.WriteLine("| Welcome to the Magic the Gathering Card Manager |");
                Console.WriteLine("|                                                 |");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("***************************************************");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("|             1. Add a Card.                      |");
                Console.WriteLine("|             2. Display Cards.                   |");
                Console.WriteLine("|             3. Remove a Card.                   |");
                Console.WriteLine("|             4. Edit a Card.                     |");
                Console.WriteLine("|             5. Exit.                            |");
                Console.WriteLine("--------------------------------------------------|");
                Console.WriteLine(""); // line spacing
                Console.Write("Your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    // Add a card
                    case 1:
                        Console.Write("What is the name of the card?: ");
                        // Read input
                        Console.Write("What is the color/colors of the card?: ");
                        // Read input
                        Console.Write("What is the price of the card?: ");
                        // Read input
                        Console.WriteLine("Card has been successfully added!");
                        break;

                    // Display the cards saved
                    case 2:
                        Console.WriteLine($"Display cards");
                        /// <summary>
                        /// Code here to check if there are cards to display. If not shoot error message.
                        /// </summary>
                    break;

                    // Delete a card
                    case 3:
                        Console.Write("What is the name of the card you want to delete: ");
                        // Read input

                        // this line will only execute if all conditions have been met
                        Console.WriteLine("Card successfully deleted!");

                        /// <summary>
                        /// Code here to check if the card exists, if so than set as "".
                        /// </summary>
                        break;

                    // Edit a card.
                    case 4:
                        Console.Write("What is the name of the card you want to edit?: ");
                        // Read input

                        /// <summary>
                        /// Take the user's input and if the input matches a value thats stored, change that value
                        /// to new value. If not found, shoot error message
                        /// </summary>
                        
                        Console.Write("What is the new name of the card?: ");
                        // Read input
                        Console.Write("What is the color/colors of the card you want to edit?: ");
                        // Read input
                        Console.Write("What is the pricer of the card you want to edit?: ");
                        // Read input

                        // This line will only execute when the conditions are all met. If not met than shoot error
                        Console.WriteLine("Card successfully edited");
                        break;

                    // Exit - Ends the loop
                    case 5:
                        Console.WriteLine("Goodbye!");
                    break;
                }
            }
        }
    }
}
