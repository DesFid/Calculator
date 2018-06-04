using System;

namespace Calculator {
    class Program {
        static void Main (string[] args) {
            double total = 0;
            string input_2 = "";
            Operations oper = new Operations ();
            Console.WriteLine ("Calculator\n\tOptions\nAddition\tA\nSubstracion\tB\nMultiplication\tC\nDivision\tD\nSquare root\tE\nTotal\t\tF\n");
            Console.Write ("Insert a value: ");
            string input = Console.ReadLine ();
            Console.Write ("Choose a option: ");
            string operation = Console.ReadLine ();
            if (double.TryParse (input, out double number1)) {
                while (operation != "F") {
                    if (operation == "E") {
                        total = oper.Sqrt (number1);
                        number1 = total;
                    } else {
                        Console.Write ("Insert other value: ");
                        input_2 = Console.ReadLine ();                        
                    }
                    if (double.TryParse (input_2, out double number2) && operation != "E") {
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
                        if (operation != "E") {
                            Console.WriteLine ("ERROR: You can't insert a string");
                            Environment.Exit (0);
                        }
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