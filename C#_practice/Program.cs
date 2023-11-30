using System;
using System.Xml;

namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int number;
            number = 5;
            float totalPrice = 20.5f;
            const int MaxNum = 9;
            char character = 'A';
            string firstname = "Azizul";
            bool isWorking = true;

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            //Implicit type casting
            byte i = 100;
            int j = i;

            //Explivit type casting
            j = 1000;
            byte k = (byte)j;
            Console.WriteLine(k);

            //Type conversion
            var num1 = "1234";
            int num2 = Convert.ToInt32(num1);
            Console.WriteLine(num2);

            //Handling Exception
            try
            {
                var num3 = "2222";
                byte a = Convert.ToByte(num3);
                Console.WriteLine(a);
            }
            catch (Exception ex)
            {
                Console.WriteLine("The number coudn't be converted to byte");
            }   
        }
    }
}
