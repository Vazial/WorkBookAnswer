using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBookAnswer
{
    public class Question3_Answer
    {
        public void Answer(int year)
        {
            var a = year - 1;
            var b = a / 100;
            var c = b + 1;
            Console.WriteLine($"{c}世紀です");
        }

        public void Answer2(int year)
        {
            var century = ((year - 1) / 100) + 1;
            Console.WriteLine($"{century}世紀です");
        }
    }
}
