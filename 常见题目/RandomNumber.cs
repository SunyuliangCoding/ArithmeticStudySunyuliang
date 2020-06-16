using System;
using System.Collections.Generic;
using System.Text;

namespace 常见题目
{
    public class RandomNumber
    {
        public void RN()
        {
            var numbers = new int[100];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }
            var m = 99;
            Random r = new Random();
            while (m >= 0)
            {
                var n = r.Next(0, 99);
                var x = numbers[m];
                numbers[m] = numbers[n];
                numbers[n] = x;
                m--;
            }
            foreach (var item in numbers)
            {
                Console.Write(item + ",");
            }
        }
    }
}
