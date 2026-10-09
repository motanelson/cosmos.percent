using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Sys = Cosmos.System;

namespace Cosmospercent
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            Console.BackgroundColor=ConsoleColor.White;
            Console.ForegroundColor=ConsoleColor.Black;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            while (true)
            {
                for (int i = 0; i < 100; i++)
                {
                    string s = i.ToString() + "%......";
                    Console.Write(s.Substring(0,6));

                    for (int j = 0;j<i/2;j++) 
                    {
                        Console.Write(" ");
                    }
                    Console.Write("\r");
                    Thread.Sleep(100);

                }
                Console.WriteLine("");

            }
        }
    }
}
