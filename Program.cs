using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WongaSender
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to Wonga Messaging System.\n\n"
                + "Please enter your name:");

            String name = Console.ReadLine();
            Console.WriteLine(name);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Wonga Technologies Copyright 2021 - Powered by Riaz Hlatshwayo");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Read();
        }
    }
}
