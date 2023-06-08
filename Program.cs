
namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Write a first number");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("write an operator");
            ConsoleKey consoleKey = Console.ReadKey().Key;
            Console.WriteLine(' ');
            Console.WriteLine("Write a second number");
            float b = Convert.ToSingle(Console.ReadLine());
            float c = 0;
            bool d = false;
            while (consoleKey != ConsoleKey.F2)
            {
            switch (consoleKey)
            {
                case ConsoleKey.OemPlus:
                    if (d == true)
                    {
                        c = c + b;
                    }
                    else
                    {
                    c = a + b;
                    }
                    break;

                case ConsoleKey.OemMinus:
                    if (d == true)
                    {
                        c = c - b;
                    }
                    else
                    {
                    c = a - b;
                    }
                    break;

                case ConsoleKey.D8:
                    if (d == true)
                    {
                        c = c * b;
                    }
                    else
                    {
                    c = a * b;
                    }
                    break;

                case ConsoleKey.Oem2:
                    if (d == true)
                    {
                        c = c / b;
                    }
                    else
                    {
                    c = a / b;
                    }
                    break;
                
                case ConsoleKey.D5:
                    if (d == true)
                    {
                        c = c % b;
                    }
                    else
                    {
                    c = a % b;
                    }
                    break;
                case ConsoleKey.F2:
                    return;

                default:
                    Console.WriteLine("Invalid operation key.");
                    break;
            }
            d = false;
            Console.WriteLine("1.if you want to exit press F2");
            Console.WriteLine("2.if you want to erase your number press F4");
            Console.WriteLine("3.if you want to continue with your result write an operator");
            
            Console.WriteLine("Result: " + c);
            consoleKey = Console.ReadKey().Key;
            Console.WriteLine(' ');

            switch (consoleKey)
                {
                case ConsoleKey.F2:
                    Console.WriteLine("F2");
                    return;

                case ConsoleKey.F4:
                    Console.WriteLine("F4");
                    d = false;
                    c = 0;
                    Console.WriteLine("Write a first number");
                    a = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("write an operator");
                    consoleKey = Console.ReadKey().Key;
                    Console.ReadLine();
                    Console.WriteLine("Write a second number");
                    b = Convert.ToSingle(Console.ReadLine());
                    break;
                
                default:
                    d = true;
                    Console.WriteLine("Write a second number");
                    b = Convert.ToSingle(Console.ReadLine());
                    break;
                }
            }
        }
    }
}