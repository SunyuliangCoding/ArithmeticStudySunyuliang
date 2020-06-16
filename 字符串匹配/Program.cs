using System;

namespace 字符串匹配
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("llo");

            Console.WriteLine(BruteForce("Hello World!", "Hello World!"));
            Console.ReadKey();
        }
        public static bool BruteForce(string mainStr, string modelStr)
        {
            for (int i = 0; i < mainStr.Length - modelStr.Length + 1; i++)
            {
                var result = true;
                for (int j = 0; j < modelStr.Length; j++)
                {
                    if (mainStr[i + j] != modelStr[j])
                    {
                        result = false;
                        break;
                    }
                }
                if (result)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool RK(string mainStr, string modelStr)
        {
            return true;
        }

        public static string letterIndex = "abcdefghijklmnopqrstuvwxyz";
        public static double GetHashCode(string str)
        {
            double hashCode = 0;
            for (int i = 0; i < str.Length; i++)
            {
                hashCode += letterIndex.IndexOf(str[i]) * Math.Pow(26, str.Length - i);
            }
            return hashCode;
        }

    }
}
