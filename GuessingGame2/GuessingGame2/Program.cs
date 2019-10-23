using System;
using static System.Console;

namespace GuessingGame2 {
    class Program {
        static void Main(string[] args) {
            Random randomNumberGen = new Random();
            int randomNumber = randomNumberGen.Next(1, 11);

            bool lastGuessLow = false;
            bool lastGuessHigh = false;
            while (true) {
                WriteLine("Guess the random number: ");
                int guessed = Convert.ToInt32(ReadLine());
                if (guessed == randomNumber) {
                    WriteLine("Correct");
                    break;
                }
                else if (guessed > randomNumber) {
                    if (lastGuessHigh) {
                        WriteLine("Thats a terrible guess, why go higher?!");
                    } else {
                        WriteLine("Too high");
                    }

                    lastGuessLow = false;
                    lastGuessHigh = true;
                }
                else if (guessed < randomNumber) {
                    if (lastGuessLow) {
                        WriteLine("Thats a terrible guess, why go lower?!");
                    } else {
                        WriteLine("Too low");
                    }

                    lastGuessLow = true;
                    lastGuessHigh = false;
                }
            }
        }
    }
}
