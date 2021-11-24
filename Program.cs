// See https://aka.ms/new-console-template for more information
using System;
    namespace loop
    {
        class program
        {
            static void Main(string [] args)
            {
                for(int i=0;i<5;i++)
                {
                    for(int j=0;j<=i;j++)
                            Console.WriteLine("*");
                }
            }
        }
    }
