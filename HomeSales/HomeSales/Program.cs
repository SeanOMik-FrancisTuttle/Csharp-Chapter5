using System;
using static System.Console;

namespace HomeSales {
    class Program {
        static void Main(string[] args) {
            double dSale = 0;
            double eSale = 0;
            double fSale = 0;

            while (true) {
                Write("Input sales person initial (z to exit): ");
                string initial = ReadLine().ToLower();

                if (initial == "z") {
                    break;
                } else if (initial == "d") {
                    Write("Enter amount of sale for D: ");
                    dSale += Convert.ToDouble(ReadLine());
                } else if (initial == "e") {
                    Write("Enter amount of sale for E: ");
                    eSale += Convert.ToDouble(ReadLine());
                } else if (initial == "f") {
                    Write("Enter amount of sale for F: ");
                    fSale += Convert.ToDouble(ReadLine());
                } else {
                    WriteLine("Error: Input sales person initial - z, d, e, or f!");
                }
            }

            WriteLine("Sales for D: {0}\nSales for E: {1}\nSales for F: {2}", dSale, eSale, fSale);
        }
    }
}
