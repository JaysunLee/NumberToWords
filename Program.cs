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
            Console.WriteLine("1000 = " + NumberToWords(1000));
            Console.WriteLine("1001 = " + NumberToWords(1001));
            Console.WriteLine("1234 = " + NumberToWords(1234));
            Console.WriteLine("3333 = " + NumberToWords(3333));
            Console.WriteLine("6060 = " + NumberToWords(6060));
            Console.WriteLine("8800 = " + NumberToWords(8800));

            Console.WriteLine("10000 = " + NumberToWords(10000));
            Console.WriteLine("10001 = " + NumberToWords(10001));
            Console.WriteLine("11000 = " + NumberToWords(11000));
            Console.WriteLine("55555 = " + NumberToWords(55555));

            Console.WriteLine("100000 = " + NumberToWords(100000));
            Console.WriteLine("100002 = " + NumberToWords(100002));
            Console.WriteLine("666666 = " + NumberToWords(666666));

            Console.WriteLine("1000000 = " + NumberToWords(1000000));
            Console.WriteLine("1000001 = " + NumberToWords(1000001));
            Console.WriteLine("1234567 = " + NumberToWords(1234567));
            
            Console.WriteLine("12345678 = " + NumberToWords(12345678));
            
            Console.WriteLine("123456789 = " + NumberToWords(123456789));
            
            Console.WriteLine("1,000,000,000 = " + NumberToWords(1000000000));
            
            Console.WriteLine(int.MaxValue.ToString("N0") + " = " + NumberToWords(int.MaxValue));
        }
        
        static string NumberToWords(int number)
        {
            string s = string.Empty;

            s += NumberToWordsSection(ref number, 1000000000, "billion");
            s += NumberToWordsSection(ref number, 1000000, "million");
            s += NumberToWordsSection(ref number, 1000, "thousand");
            s += NumberToWordsInner(number);

            return s;
        }

        static string NumberToWordsSection(ref int number, int section, string sectionLabel)
        {
            string s = string.Empty;

            if (number >= section)
            {
                s += NumberToWordsInner(number / section);
                s += " " + sectionLabel;
                
                number = number % section;
                if (number >= 100)
                {
                    s += ", ";
                }
                else if (number > 0)
                {
                    s += " and ";
                }
            }

            return s;
        }

        static string NumberToWordsInner(int number)
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
