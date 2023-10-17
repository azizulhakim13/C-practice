// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 1;
            byte number = 3;
            int number2 = 11;
            float totlaPrice = 20.5f;
            char character = 'A';
            bool isWorking = true;
            const float pi = 3.14f;

            //Type conversion
            int i = 1;
            byte b = (byte)i;

            //Exception Handling
            try
            {
                string str = "true";
                bool c = Convert.ToBoolean(str);
                Console.WriteLine(c);

                string firstName = "1234";
                byte A = Convert.ToByte(firstName);
                Console.WriteLine(A);
            }
            catch (Exception)
            {
                Console.WriteLine("The number couldn't converted to a byte");
            }

            Console.WriteLine(number2);
            Console.WriteLine(b);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            // Operators
            var x = 11;
            var y = 6;
            var z = 3;
            Console.WriteLine((float)x / (float)y + (float)z);
            Console.WriteLine(x > z && y > z);

            //Practice problem
            int number1 = 7;
            if (number1 % 2 == 0)
            {
                Console.WriteLine("Even");
            } else
            {
                Console.WriteLine("Odd");
            }

        }
    }
}
