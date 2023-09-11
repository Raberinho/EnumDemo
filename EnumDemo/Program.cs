using System.Threading.Channels;

namespace EnumDemo
{


    enum Beverage
    {
        Coffee,
        Tea,
        Water,
        Soda,
        Juice,

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the awsome vendig machine");
            Console.WriteLine("Which bevrage do you prefer? (Coffee, Tea, Water, Soda, Juice");
            String userInput = Console.ReadLine();

            switch (userInput.ToLower())

            {

                case "coffee":
                  Respond(Beverage.Coffee);
                    break;
                case "tea":
                    Respond(Beverage.Tea);  
                    break;
                case "water":
                    Respond(Beverage.Water);
                    break;
                case "soda":
                    Respond(Beverage.Soda);
                    break;
                case "Juice":
                    Respond(Beverage.Juice);
                    break;
                
             default:
                    Console.WriteLine("Invalid input, ths drink dos not exist");
                    break;
            }


        }  
        static void Respond(Beverage drink)
        {
            switch (drink)
            {
                case Beverage.Coffee:
                    Console.WriteLine("You ordered kaffe latte");
                    break;
                case Beverage.Tea:
                    Console.WriteLine("You ordered Tea, jukky");
                    break;
                case Beverage.Water:
                    Console.WriteLine("You ordered Water");
                    break;
                case Beverage.Soda:
                    Console.WriteLine("Nice choice");
                    break;
                case Beverage.Juice:
                    Console.WriteLine("Order juice");
                    break;
            }

        }

        }
    }

