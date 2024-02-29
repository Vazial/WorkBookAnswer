using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace WorkBookAnswer
{
    public class Program_Answer
    {
        public static void Main(string[] questionNumber)
        {
            while (true)
            {
                Console.Write("実行する小問の番号を入力してください。(1～6) : ");
                int args = 0;
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("値を入力してください。: ");
                        if (Int32.TryParse(Console.ReadLine(), out args) == false)
                        {
                            Console.WriteLine("有効な数字を入力してください。");
                            break;
                        }
                        new Question1_Answer().Answer(args);
                        break;
                    case "2":
                        Console.Write("値を入力してください。: ");
                        if (Int32.TryParse(Console.ReadLine(), out args) == false)
                        {
                            Console.WriteLine("有効な数字を入力してください。");
                            break;
                        }
                        new Question2_Answer().Answer(args);
                        break;
                    case "3":
                        Console.Write("値を入力してください。: ");
                        if (Int32.TryParse(Console.ReadLine(), out args) == false)
                        {
                            Console.WriteLine("有効な数字を入力してください。");
                            break;
                        }
                        new Question3_Answer().Answer(args);
                        break;
                    case "4":
                        Console.Write("値を入力してください。: ");
                        if (Int32.TryParse(Console.ReadLine(), out args) == false)
                        {
                            Console.WriteLine("有効な数字を入力してください。");
                            break;
                        }
                        new Question4_Answer().Answer(args);
                        break;
                    case "5":
                        Console.Write("値を入力してください。: ");
                        if (Int32.TryParse(Console.ReadLine(), out args) == false)
                        {
                            Console.WriteLine("有効な数字を入力してください。");
                            break;
                        }
                        new Question5_Answer().Answer(args);
                        break;
                    case "6":
                        new Question6_Answer().Answer();
                        break;
                    default:
                        Console.WriteLine("有効な数字を入力してください。");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
