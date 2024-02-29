using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBookAnswer
{
    public class Question2_Answer
    {
        public void Answer(int number)
        {
            var rem = number % 6;
            if (rem == 0)
            {
                Console.WriteLine("6の倍数です");
            }
            else
            {
                rem = number % 3;
                if (rem == 0)
                {
                    Console.WriteLine("3の倍数です");
                }
            }
        }

        public void Answer2(int number)
        {
            var rem = number % 6;
            if (rem == 0)
            {
                Console.WriteLine("6の倍数です");
            }
            else
            {
                if (rem == 3)
                {
                    Console.WriteLine("3の倍数です");
                }
            }
        }
    }
}
