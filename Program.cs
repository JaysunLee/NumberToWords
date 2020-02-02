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
            Console.WriteLine("20 = " + NumberToWords(20));
            Console.WriteLine("33 = " + NumberToWords(33));
            Console.WriteLine("99 = " + NumberToWords(99));
            Console.WriteLine("100 = " + NumberToWords(100));
            Console.WriteLine("101 = " + NumberToWords(101));
            Console.WriteLine("300 = " + NumberToWords(300));
            Console.WriteLine("313 = " + NumberToWords(313));
            Console.WriteLine("999 = " + NumberToWords(999));
        }

        static string NumberToWords(int number)
        {
            string s = string.Empty;

            if (number >= 100)
            {
                int hundreds = number / 100;
                s += Digits(hundreds) + " hundred";
                number = number % 100;
                if (number > 0)
                {
                    s += " and ";
                }
            }

            if (number >= 20)
            {
                int tens = number / 10;
                s += Tens(tens);
                number = number % 10;
                if (number > 0)
                {
                    s += " ";
                }
            }
            else if (number >= 10)
            {
                s += Teens(number);
                return s;
            }

            if (number > 0)
            {
                s += Digits(number);
            }

            return s;
        }

        static string Tens(int num)
        {
            switch (num)
            {
                case 2:
                    return "twenty";
                case 3:
                    return "thirty";
                case 4:
                    return "forty";
                case 5:
                    return "fifty";
                case 6:
                    return "sixty";
                case 7:
                    return "seventy";
                case 8:
                    return "eighty";
                case 9:
                    return "ninety";
                default:
                    return string.Empty;
            }
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

        static string Digits(int num)
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
