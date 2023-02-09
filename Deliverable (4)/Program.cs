using System;

namespace Deliverable_4
{
    class Program
{
        static void Main(string[] args)
        {
            int[] fibonacci = new int[25];
            //array of 25 to store the numbers
            
            
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            //first two numbers of the fibonacci sequence


            for (int i = 2; i < 25; i++)
            //for loop to calculate the rest of the numbers
            {  
                
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                //each number is the sum of the previous two
            }
            
            for (int i = 0; i < 25; i++)
            //displays the first 25 numbers in the sequence

            {
                Console.WriteLine("Fibonacci number (" + i + ") = " + fibonacci[i]);
            }
            Console.ReadLine();
        }
    }
}