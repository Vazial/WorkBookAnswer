using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBookAnswer
{
    public class Question5_Answer
    {
        public void Answer(int number)
        {
            var div = number / 4;
            Console.WriteLine(number - (div * 4));
        }
    }
}
