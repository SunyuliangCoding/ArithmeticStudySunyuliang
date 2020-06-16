using System;
using System.Collections.Generic;

namespace 临时测试
{
    class Program
    {
        static void Main(string[] args)
        {

            var p = new Person() { name = "zhangsan" };
            var cache = new Cache();
            cache.data.Add("person", p);

            p.name = "李四";

            Console.WriteLine((cache.data["person"] as Person).name);


            Console.ReadKey();

        }
    }
    public class Cache
    {
        public Dictionary<string, object> data = new Dictionary<string, object>();
    }

    public class Person
    {
        public string name { get; set; }
    }
}
