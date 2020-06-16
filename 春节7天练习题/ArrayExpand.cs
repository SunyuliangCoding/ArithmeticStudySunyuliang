/**************************************************************************      
项    目:        春节7天练习题
作    者:        SYL syl
创建时间:        2019/2/19 11:00:18
Copyright (c)    北京迪威特科技有限公司

描    述：
***************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace 春节7天练习题
{
    public class ArrayExpand
    {
        public int[] array = new int[8];
        private int Index = 0;
        public void add(int a)
        {
            if (Index < array.Length)
            {
                array[Index] = a;
                Index++;
            }
            else
            {
                Expansion();
                add(a);
            }
            print();
        }
        private void Expansion()
        {
            var newArray = new int[this.Index * 3];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            this.array = newArray;
            Console.WriteLine($"触发数组扩容，当前容量{Index + 1},扩容后容量{newArray.Length}");
        }
        public void print()
        {
            foreach (var item in array)
            {
                Console.Write(item+",");
            }
            Console.WriteLine();
        }
    }
}
