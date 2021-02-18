using System;

namespace Calculator
{
    public class Calculator
    {
        public static int Add(int a, int b) {
            return a + b;
        }

        public static int Subtract(int a, int b) {
            return a - b;
        }

        public static int Multiply(int a, int b) {
            return a * b;
        }

        public static int Divide(int a, int b) {
            return a / b;
        }

        public static int Fib(int idx) {
            int f0 = 0;
            int f1 = 1;
            int f2 = 1;
            for (int i = 0; i < idx; i++) {
                f0 = f1;
                f1 = f2;
                f2 = f0 + f1;
            }
            return f0;
        }

        public static bool Prime(int a) {
            double test = Math.Sqrt(Math.Abs(a)); // a negative number is prime if & only if its positive complement is also prime
            if (test <= 1) return false; // 0 and 1 are not prime
            for (int i = 2; i <= test; i++) {
                if (a % i == 0) return false;
            }
            return true;
        }

        public static bool Balanced(string equation) {
            int unclosed = 0;
            foreach (char ch in equation) {
                if (ch == ')') {
                    unclosed--;
                    if (unclosed < 0) return false;
                }
                else if (ch == '(') {
                    unclosed++;
                }
            }
            return unclosed == 0;
        }
    }
}
