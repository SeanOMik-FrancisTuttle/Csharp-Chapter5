using System;
using static System.Console;

namespace TippingTable3 {
    class Program {
        const double TIPSTEP = 0.05;
        static void Main(string[] args) {
            double dinnerPrice = 10.00;
            double tipRate;
            double tip;

            Write("Lowest Tip Rate: ");
            double LOWRATE = Convert.ToDouble(ReadLine());
            Write("Max Tip Rate: ");
            double MAXRATE = Convert.ToDouble(ReadLine());
            Write("Cheapest Dinner: ");
            double DINNERSTEP = Convert.ToDouble(ReadLine());
            Write("Most Expensive Dinner: ");
            double MAXDINNER = Convert.ToDouble(ReadLine());
            

            Write("Price");
            for (tipRate = LOWRATE; tipRate <= MAXRATE; tipRate += TIPSTEP) {
                Write("{0, 8}", tipRate.ToString("F"));
            }
            WriteLine();
            for (int i = 0; i < 40; i++) {
                Write("-");
            }
            WriteLine();
            tipRate = LOWRATE;

            do {
                Write("{0, 8}", dinnerPrice.ToString("C"));
                while (tipRate <= MAXRATE) {
                    tip = dinnerPrice * tipRate;
                    Write("{0, 8}", tip.ToString("F"));
                    tipRate += TIPSTEP;
                }
                dinnerPrice += DINNERSTEP;
                tipRate = LOWRATE;
                WriteLine();
            } while (dinnerPrice <= MAXDINNER);
        }
    }
}
