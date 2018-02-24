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
                question = 0;

                Console.WriteLine("Please hit '1' to start.");
                Console.WriteLine("Once the timer has started you can hit 2 to stop.");
                Console.WriteLine("If you are done, please hit 0.");
                Console.WriteLine("");

                var input = Console.ReadLine();

                Console.WriteLine("");

                try
                {
                    question = Convert.ToInt32(input);

                }
                catch (Exception)
                {
                    Console.WriteLine("That is not an acceptable answer");
                    question = 3;
                   
                }
                switch (question)
                    {
                        case 1:
                            stopwatch.StartTimer();
                            break;
                        case 2:
                            Console.WriteLine();
                            stopwatch.StopTimer();
                            Console.WriteLine();
                            break;
                    case 0:
                        break;

                    }
                } while (question != 0);
        }
    }
}
