using System;
using static System.Console;

namespace MultiplicationTable {
    class Program {
        static void Main(string[] args) {
            Write("Enter number: ");

            int number = Convert.ToInt32(ReadLine());
            for (int i = 0; i < number+1; i++) {
                if (i == number) {
                    Write("and {0}x{1}={2}.", i, number, i * number);
                } else {
                    Write("{0}x{1}={2}, ", i, number, i * number);
                }
                
            }
        }
    }
}
