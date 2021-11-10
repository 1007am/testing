using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4lab
{
    class Program
    {
        static double? _A;
        static double? _B;

        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Menu();
            }
        }

        private static bool Menu()
        {
            Console.Clear();
            if (_A == null) Console.WriteLine(" 1. Enter A");
            else Console.WriteLine($" 1. Enter A ({_A})");
            if (_B == null) Console.WriteLine(" 2. Enter B");
            else Console.WriteLine($" 2. Enter B ({_B})");
            Console.WriteLine(" 3. Perform addition (+)");
            Console.WriteLine(" 4. Perform subtraction (-)");
            Console.WriteLine(" 5. Perform multiplication (*)");
            Console.WriteLine(" 6. Perform division (/)");
            Console.WriteLine(" 7. Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    SetA();
                    return true;
                case "2":
                    SetB();
                    return true;
                case "3":
                    Add(_A, _B);
                    return true;
                case "4":
                    Subtract(_A, _B);
                    return true;
                case "5":
                    Multiply(_A, _B);
                    return true;
                case "6":
                    Divide(_A, _B);
                    return true;
                case "7":
                    return false;
                default:
                    return true;
            }
        }

    }
}
