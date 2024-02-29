using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBookAnswer
{
    public class Question1_Answer
    {
        public void Answer(int number)
        {
            var a = number % 3;
            if (a == 0)
            {
                Console.WriteLine("3の倍数です");
            }
            else
            {
                Console.WriteLine("3の倍数ではありません");
            }
        }
    }
}
