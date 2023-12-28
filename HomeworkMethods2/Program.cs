using System;
using System.Diagnostics;

namespace HomeworkMethods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculator(4, 4, "/");

            //Console.WriteLine(FindSymbol("sd#fwdfw#e#sdvd#",'#'));


            //Console.WriteLine(FindWord(" Farid Abdullayev Code Academy "));


            //Console.WriteLine(FindNumberSum(123));


            //Console.WriteLine(FindPower(2,4));


            //int[] datas = { -1, -2, 3, 4, -10};
            //FindPositive(datas);


            //Console.WriteLine(FindViceVersa("salam"));

        }


        //1 Verilmiş iki ədəd üzərində verilmiş operator simvoluna əsasən riyazi əməliyyat aparıb nəticəsini console-da göstərən metod.
        static void Calculator(int n, int m, string opt) 
        {
            int result = 0;
            switch (opt)
            {
                case "+":
                    result = n + m;
                    break;
                    case "-":
                        result = n - m;
                    break;
                    case "*":
                        result = n * m;
                    break;
                    case "/":
                        result = n / m;
                    break;
                default:
                    Console.WriteLine("operatr novu yanlisdir");
                    break;
            }
            Console.WriteLine(result);
        }


        //2 Verilmiş yazıdaki verilmiş simvolların sayını qaytaran metod
        static int FindSymbol(string text ,char symbol)
        {
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == symbol)
                {
                    count++;
                }
            }
            return count;
        }


        //3 Verilmiş yazıdaki sözlərin sayını qaytaran metod (söz dedikdə boşluqlarla ayrılmış bütün yazılar nəzərdə tutulur)
        static int FindWord(string text) 
        {
            int count = 0;
            string nn = "";
            int index = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    count++;
                }
            }
            return count;
        }


        //4 Verilmişdədin rəqəmləri cəmini qaytaran metod
        static int FindNumberSum(int n)
        {
            int remaider = 0;

            int sum = 0;

            while (n != 0)
            {
                remaider = n % 10;

                sum = sum + remaider;

                n = n / 10;
            }
            return sum;
        }


        //5 Verilmiş ədədi verilmiş qüvvətə yüksəldib nəticəsini qaytaran metod
        static int FindPower(int n,int power)
        {
            int result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= n;
            }
            return result;
        }


        //6 Verilmiş ədədlər siyahısının bütün elementlərini  müsbət şəkildə qaytaran metod.
        //Misalçün  metoda {1,-4,9,-8} dəyərləri olan array göndərilsə metod bizə {1,4,9,8} dəyərləri olan array qaytarmalıdır.
        static void FindPositive(int[] nums)
        {
            for (int i = 0;i < nums.Length;i++)
            {
                if (nums[i] < 0)
                {
                    nums[i] = -nums[i];
                }
                Console.WriteLine(nums[i]);
            }
        }
        

        //7 Verilmiş yazını tərs formada qaytaran metod (Misalçün "salam" göndərilsə metoddan "malas" return ediləcək)
        static string FindViceVersa(string text)
        {
            string txt = "";
            for (int i = text.Length -1; i >=0; i--)
            {
                 txt += text[i];
            }
            return txt;
        }
    }
}
