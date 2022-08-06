using System;

namespace Methods01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Hello-What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Welcome {userName} My First question is, What is your favorite Color?");
            var Color = Console.ReadLine();

            Console.WriteLine($"Oh Wow {Color} So {userName} My second question is, What is your favorite Animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great! My third question is ,what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine("That's Awesome! My last question is ,what is your favorite place to visit for vacation?");
            var placetovisit = Console.ReadLine();

            Console.WriteLine($"Thank you,{userName}! Check this!");


            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"favorite Color: {Color}");
            Console.WriteLine($"favorite Animal: {animal}");
            Console.WriteLine($"favorite band: {band}");
            Console.WriteLine($"favorite placetovisit: {placetovisit}");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sun is:(sum)");

            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to  multiply  to the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is: {product}");
        }
            public static int Sum(params int[] list)
            {
                int sum = 0;
                for  (int i = 0; i < list.Length; i++)
                {
                    sum = sum + list[i];
                }
                return sum;
            }

            public static int Multiply(int x, int y)

            {
                return x * y;


            }
        }
    }


