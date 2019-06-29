using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    class Program
    {
        static void Main(string[] args)
        {

            StartScreen();
        }

        public static void StartScreen()
        {
            do
            {
                Console.WriteLine("Please type 1 to input data, 2 for syntetic data or 3 for exit");

                int action;
                string str = Console.ReadLine();

                bool success = Int32.TryParse(str, out action);

                if (success)
                {
                    switch (action)
                    {
                        case 1:
                            Console.WriteLine("Not implemented yet.");
                            break;
                        case 2:
                            Console.WriteLine("Printing syntetic data...\n");
                            Repository.PrintSyntheticData();
                            break;
                        case 3:
                            return;
                        default:
                            Console.WriteLine("Wrong Input, please retype!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong Input, please retype!");
                }
            } while (true);
        }
    }
}
