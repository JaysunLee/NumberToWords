using System;

namespace NumberToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0 = " + NumberToWords(0));
            Console.WriteLine("1 = " + NumberToWords(1));
            Console.WriteLine("8 = " + NumberToWords(8));
            Console.WriteLine("10 = " + NumberToWords(10));
            Console.WriteLine("19 = " + NumberToWords(19));
        }

        static string NumberToWords(int number)
        {
            if (number < 10)
            {
                return Ones(number);
            }
            else if (number < 20)
            {
                return Teens(number);
            }

            return "";
        }

        static string Teens(int num)
        {
            switch (num)
            {
                case 10:
                    return "ten";
                case 11:
                    return "eleven";
                case 12:
                    return "twelve";
                case 13:
                    return "thirteen";
                case 14:
                    return "fourteen";
                case 15:
                    return "fifteen";
                case 16:
                    return "sixteen";
                case 17:
                    return "seventeen";
                case 18:
                    return "eighteen";
                case 19:
                    return "nineteen";
                default:
                    throw new ArgumentException();
            }
        }

        static string Ones(int num)
        {
            switch (num)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    throw new ArgumentException();
            }
        }
    }
}
