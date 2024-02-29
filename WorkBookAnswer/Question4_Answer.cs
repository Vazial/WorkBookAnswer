using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBookAnswer
{
    public class Question4_Answer
    {
        public void Answer(int year)
        {
            var leapYear = year % 400;
            if (leapYear == 0)
            {
                Console.WriteLine("うるう年です");
            }
            else
            {
                if ((leapYear % 100) == 0)
                {
                    Console.WriteLine("うるう年ではありません");
                }
                else
                {
                    if ((leapYear % 4) == 0)
                    {
                        Console.WriteLine("うるう年です");
                    }
                    else
                    {
                        Console.WriteLine("うるう年ではありません");
                    }
                }
            }
        }
    }
}
