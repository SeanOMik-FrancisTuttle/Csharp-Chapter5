using System;
using static System.Console;

namespace DisplayMultiplicationTable {
    class Program {
        static void Main(string[] args) {
            for (int i = 0; i < 11; i++) { 
                for (int z = 0; z < 11; z++) {
                    if (z == 10) {
                        WriteLine(" {0} ", z * i);
                    } else {
                        Write(" {0} ", z * i);
                    }
                }
            }
        }
    }
}
