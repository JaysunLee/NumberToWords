using System;

namespace NumberToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberToWords(0));
            Console.WriteLine(NumberToWords(1));
            Console.WriteLine(NumberToWords(8));
        }

        static string NumberToWords(int number)
        {
            return Ones(number);
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
                    return string.Empty;
            }
        }
    }
}
