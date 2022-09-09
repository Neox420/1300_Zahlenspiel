using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser2._0
{
    internal class Haupt
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndNumber = rnd.Next(1, 101);
            bool theGuess = false;
            int allowedTries = 8;
            int numberOfTries = 0;

            Console.WriteLine("Eine Zahl von 1-100 wurde erstellt, erraten Sie sie in unter 8 Versuchen!");

            
                while (!theGuess)
                {
                    int guess = Convert.ToInt32(Console.ReadLine());

                    if (numberOfTries == allowedTries)
                    {
                        Console.WriteLine("Sie haben keine Versuche übrig");
                        break;
                    }
                    
                    else if (guess < rndNumber)
                    {
                        numberOfTries++;
                        Console.WriteLine("Zahl ist grösser.");
                    }

                    else if (guess > rndNumber)
                    {
                        numberOfTries++;
                        Console.WriteLine("Zahl ist kleiner.");
                    }

                    else if (guess < 1 || guess > 100)
                    {
                        numberOfTries++;
                        Console.WriteLine("Nur Zahlen von 1-100 eingeben");
                    }

                    else
                    {
                        theGuess = true;
                        Console.WriteLine("Richtige Zahl erraten!");
                    }
                }

                Console.ReadKey();
        }
    }
}
