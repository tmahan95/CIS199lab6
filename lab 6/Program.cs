//Timothy Mahan
//Lab 6
//Due 3/5/16
//Section 01
/* This program displays four patterns of stars and spaces.
These patterns are created from nested loops and use the four variables I have listed below.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1; //test var for stopping outer loop
            int q = 1; //test var for stopping inner loop
            int x = 9; //Control Variable for stars and space loops, ensures the loop executes 10 times, counts fro 0-9
            int y = 1; //Control variable for spacing loops in patterns c and d

            Console.WriteLine("Pattern A");//mark pattern

            for (i = 0; i <= x; ++i)//Begin pattern A outer loop, iterates 10 times
            {
                for (q = 0; q <= i; ++q)
                {
                    Console.Write("*");//star inner loop
                }

                Console.WriteLine("");//moves text to next line after one complete outer loop iteration
            }

            Console.WriteLine("");//Space out patterns, for aesthetics

            Console.WriteLine("Pattern B");//mark pattern

            for (i = x; i >= 0; --i) //Begin pattern B outer loop, iterates 10 times
            {
                for (q = 0; q <= i; ++q)
                {
                    Console.Write("*");//star inner loop
                }

                Console.WriteLine("");//moves text to next line after one complete outer loop iteration
            }

            Console.WriteLine("");//space out patterns

            Console.WriteLine("Pattern C");//mark pattern

            for (i = x; i >= 0; --i)//Begin pattern C outer loop, iterates 10 times
            {

                for (q = x-y; q >= i ; --q)//Space inner loop, doesn't insert a space on the first line
                {
                    Console.Write(" ");
                }

                for (q = 0; q <= i; ++q)//Star inner loop
                {
                    Console.Write("*");
                }


                Console.WriteLine("");//moves text to next line after one complete outer loop iteration
            }

            Console.WriteLine("");//space out patterns

            Console.WriteLine("Pattern D");//mark pattern

            for (i = x; i >= 0; --i)//Begin pattern D outer loop, iterate 10 times
            {

                for (q = i-y; q >= 0; --q)//Space inner loop, doesn't insert a space in the last row of stars.
                {
                    Console.Write(" ");
                }

                for (q = x; q >= i; --q)//star inner loop
                {
                    Console.Write("*");
                }

                Console.WriteLine("");//moves text to next line after one complete outer loop iteration
            }
        }
    }
}
