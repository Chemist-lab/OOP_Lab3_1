using System;
using System.Text;

namespace w1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть рядок: \n");
            string Input = Console.ReadLine();
            BracketsCount(Input);
            DeleteRbrackets(Input);
        }

        static string BracketsCount(string input)
        {
            int checkR1 = 0, checkR2 = 0, checkS1 = 0, checkS2 = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char CheckChar;
                CheckChar = input[i];

                if (CheckChar == '(')
                    {
                        checkR1++;
                    }
                    if (CheckChar == ')')
                    {
                        checkR2++;
                    }

                if (CheckChar == '[')
                    {
                        checkS1++;
                    }
                    if (CheckChar == ']')
                    {
                        checkS2++;
                    }
            }

            Console.WriteLine("Кількіть відкритих круглих дужок - " + checkR1 + "\nКількіть закритих круглих дужок - " + checkR2 +
                    "\n\nКількість відкритих квадратних дужок - " + checkS1 + "\nКількість закритих квадратних дужок - " + checkS1);

            return "";
        }
        
        static string DeleteRbrackets(string input)
        {

            string deleteNext = GetBtwn(input, "(", ")");
            input = input.Replace(deleteNext, "");
            Console.WriteLine("\nКруглі дужки очищенні:\n" + input);
            return "";
        }
        public static string GetBtwn(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                int End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            return "";
        }
    }
}
