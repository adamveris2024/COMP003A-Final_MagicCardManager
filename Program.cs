using System.Diagnostics.CodeAnalysis;

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
            while (true)
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
                Console.WriteLine("|             3. Exit.                            |");
                Console.WriteLine("--------------------------------------------------|");
                Console.WriteLine(""); // line spacing
                Console.Write("Your choice: ");
                int choice = int.Parse(Console.ReadLine());
                try 
                {
                    switch (choice)
                    {
                        // Add a card
                        case 1:
                            // Checks if the card list has 50 items, if so it breaks the loop.
                            if (Cards.Count == 50)
                            {
                                Console.WriteLine("Card inventory is full.");
                                break;
                            }
                            Console.WriteLine("What is the color of your card?");
                            Console.WriteLine("");
                            Console.WriteLine("1. Red");
                            Console.WriteLine("2. Green");
                            Console.WriteLine("3. Blue");
                            Console.WriteLine("4. Black");
                            Console.WriteLine("5. White");
                            Console.Write("Your choice: ");
                            // Read input
                            int choice2 = int.Parse(Console.ReadLine());
                            switch (choice2)
                            {
                                // Red - based off the color of the card, it will add it to the list
                                case 1:
                                    Console.Write("What is the name of your card?: ");
                                    string redName = Console.ReadLine();
                                    Console.Write("What is the price of your card?: $");
                                    double redPrice = double.Parse(Console.ReadLine());
                                    Red red = new Red(redName, redPrice);
                                    Cards.Add(red);
                                break;
                                // Green
                                case 2:
                                    Console.Write("What is the name of your card?: ");
                                    string greenName = Console.ReadLine();
                                    Console.Write("What is the price of your card?: $");
                                    double greenPrice = double.Parse(Console.ReadLine());
                                    Green green = new Green(greenName, greenPrice);
                                    Cards.Add(green);
                                break;
                                // Blue
                                case 3:
                                    Console.Write("What is the name of your card?: ");
                                    string blueName = Console.ReadLine();
                                    Console.Write("What is the price of your card?: $");
                                    double bluePrice = double.Parse(Console.ReadLine());
                                    Blue blue = new Blue(blueName, bluePrice);
                                    Cards.Add(blue);
                                break;
                                // Black
                                case 4:
                                    Console.Write("What is the name of your card?: ");
                                    string blackName = Console.ReadLine();
                                    Console.Write("What is the price of your card?: $");
                                    double blackPrice = double.Parse(Console.ReadLine());
                                    Black black = new Black(blackName, blackPrice);
                                    Cards.Add(black);
                                break;
                                // White
                                case 5:
                                    Console.Write("What is the name of your card?: ");
                                    string whiteName = Console.ReadLine();
                                    Console.Write("What is the price of your card?: $");
                                    double whitePrice = double.Parse(Console.ReadLine());
                                    White white = new White(whiteName, whitePrice);
                                    Cards.Add(white);
                                break;
                            }
                            // Catch whether user's input is less than or greater than 1-5.
                            if (choice2 <= 0 || choice2 >= 6)
                            {
                                Console.WriteLine("Your input is invalid. Please try again.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Card has been successfully added!");
                                break;
                            }
                            

                        // Display the cards saved
                        case 2:
                            // This displays the card name and price for each card in the list.
                            foreach (Card card in Cards)
                            {
                                CardUtility.DescribeCard(card.Name, card.Price);
                                card.ColorDescription();
                                Console.WriteLine("");
                            }
                            // this checks if the list is empty, than it shoots a message if true.
                            if (Cards.Count == 0)
                            {
                                Console.WriteLine("There are no cards saved.");
                            }
                            break;

                        // Exit
                        case 3:
                            Console.WriteLine("Thank you for using the MTG Card Manager! Goodbye!");
                        break;
                    }
                    // This ends the loop officially. It cannot be in the while loop because the loop will never end.
                    if (choice == 3)
                    {
                        break;
                    }
                    // This checks if the input it less than or greater than 1-3. If so it shoots an error message.
                    if (choice < 0 || choice >= 4)
                    {
                        Console.WriteLine("Invalid input. Please try again");
                        continue;
                    }
                }
                // this catches any errors in format and shoots an error message.
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR: {ex.Message}. Please try again.\n");
                }
            }
        }
    }
}
