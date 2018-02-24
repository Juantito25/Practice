using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer stopwatch = new Timer();
            Console.WriteLine("Welcome to the timer");
            Console.WriteLine();

            int question;

            do
            {
                question = 100;

                Console.WriteLine("Please hit '1' to start. Once the timer has started you can hit 2 to stop. If you are done, please hit 0.");
                var input = Console.ReadLine();

                try
                {
                    question = Convert.ToInt32(input);

                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not an acceptable answer");
                    
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("this is not an acceptable asnwer");
                }
                

                
                    switch (question)
                    {
                        case 1:
                            stopwatch.StartTimer();
                            break;
                        case 2:
                            stopwatch.StopTimer();
                            break;
                    case 0:
                        break;


                        default:
                            Console.WriteLine("This is not a valid Answer");
                            break;
                    }
                } while (question != 0);
        }
    }
}
