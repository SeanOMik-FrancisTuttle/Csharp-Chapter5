using System;
using static System.Console;

namespace SumInts {
    class Program {
        static void Main(string[] args) {
            WriteLine("Enter number to get the sum, enter 999 to stop");

            int sum = 0;
            while (true) {
                int number = Convert.ToInt32(ReadLine());

                if (number == 999) {
                    break;
                }

                sum += number;
            }

            WriteLine("Sum of numbers: {0}", sum);
        }
    }
}
