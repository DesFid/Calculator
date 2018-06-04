using System;

namespace Calculator {
    class Program {
        static void Main (string[] args) {
            double memory = 0;
            string input_2 = "";
            Operations oper = new Operations ();
            Console.WriteLine ("Calculator\n\tOptions\nAddition\tA\nSubstracion\tB\nMultiplication\tC\nDivision\tD\nSquare root\tE\nTotal\t\tF\nClear memory\tG\nExit\t\tH");
            Console.Write ("Insert a value: ");
            string input = Console.ReadLine ();
            Console.Write ("Choose a option: ");
            string operation = Console.ReadLine ();
            if (double.TryParse (input, out double number1)) {
                while (operation != "H") {
                    if (operation == "E") {
                        memory = oper.Sqrt (number1);
                        number1 = memory;
                    } else if (operation == "G"){
                        number1 = 0;
                        Console.WriteLine ("Cleaned");
                    } else if (operation != "F"){
                        Console.Write ("Insert other value: ");
                        input_2 = Console.ReadLine ();
                    }
                    if (double.TryParse (input_2, out double number2) && operation != "G") {
                        if (operation == "A") {
                            memory = oper.Addition (number1, number2);
                            number1 = memory;
                        } else if (operation == "B") {
                            memory = oper.Substraction (number1, number2);
                            number1 = memory;
                        } else if (operation == "C") {
                            memory = oper.Multiplication (number1, number2);
                            number1 = memory;
                        } else if (operation == "D") {
                            memory = oper.Division (number1, number2);
                            number1 = memory;
                        }
                    } else {
                            if (operation != "F" && !(operation=="G")) {
                            Console.WriteLine ("ERROR: You can't insert a string");
                            Environment.Exit (0);
                        }
                    }
                    if (operation == "F") {
                        Console.WriteLine ("Total: " + number1);
                    } else if (operation!="G"){
                        Console.WriteLine ("Current total: " + memory);
                    }
                    Console.Write ("Choose a option: ");
                    operation = Console.ReadLine ();
                }
            } else {
                Console.WriteLine ("ERROR: You can't insert a string");
            }
        }
    }
}