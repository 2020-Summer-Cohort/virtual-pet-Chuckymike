using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet newPet = new Pet();

            Console.WriteLine("Hello! Welcome to Virtual Pets");
            Console.WriteLine("1. Feed");
            Console.WriteLine("2. Play");
            Console.WriteLine("3. Take to Doctor");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    {
                        newPet.Feed();
                        Console.WriteLine("You've fed your Pet");
                        break;

                    }

            }
        }

    }
}
