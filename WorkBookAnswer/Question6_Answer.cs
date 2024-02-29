using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBookAnswer
{
    public class Question6_Answer
    {
        public void Answer()
        {
            var count = 1;
            var sum = count;
            var max = 11;
            while (true)
            {
                count = count + 1;
                if (count == max)
                {
                    break;
                }
                else
                {
                    sum = sum + count;
                    continue;
                }
            }
            Console.WriteLine(sum);
        }

        public void Answer2()
        {
            int sum = 0;
            for (int ii = 0; ii < 11; ii++)
            {
                sum += ii;
            }
            Console.WriteLine(sum);
        }
    }
}
