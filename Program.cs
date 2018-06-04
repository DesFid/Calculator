using System;

namespace Calculator {
    class Program {
        static void Main (string[] args) {
            float total = 0;
            Operations oper = new Operations ();
            Console.WriteLine ("Calculator\n\tOptions\nAddition\tA\nSubstracion\tB\nMultiplication\tC\nDivision\tD\nTotal\t\tE\n");
            Console.Write ("Insert a value: ");
            string input = Console.ReadLine ();
            Console.Write ("Choose a option: ");
            string operation = Console.ReadLine ();
            if (float.TryParse (input, out float number1)) {
                while (operation != "E") {
                    Console.Write ("Insert other value: ");
                    string input_2 = Console.ReadLine ();
                    if (float.TryParse (input_2, out float number2)) {
                        if (operation == "A") {
                            total = oper.Addition (number1, number2);
                            number1 = total;
                        } else if (operation == "B") {
                            total = oper.Substraction (number1, number2);
                            number1 = total;
                        } else if (operation == "C") {
                            total = oper.Multiplication (number1, number2);
                            number1 = total;
                        } else if (operation == "D") {
                            total = oper.Division (number1, number2);
                            number1 = total;
                        }
                    } else {
                        Console.WriteLine ("ERROR: You can't insert a string");
                        Environment.Exit(0);
                    }
                    Console.Write ("Choose a option: ");
                    operation = Console.ReadLine ();
                    
                }
                Console.WriteLine ("Total: " + number1);
            } else {
                Console.WriteLine ("ERROR: You can't insert a string");
            }
        }
    }
}