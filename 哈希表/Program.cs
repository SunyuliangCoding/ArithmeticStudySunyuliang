using System;
using System.Security.Cryptography;
using System.Text;

namespace 哈希表
{
    class Program
    {
        static void Main(string[] args)
        {
            var zhangsan = new Person() { Id = 1, Age = 18, Name = "张三", key = new PersonKey() { Id = "zhangsan" } };
            var lisi = new Person() { Id = 233, Age = 25, Name = "李四", key = new PersonKey() { Id = "lisi" } };
            var wangwu = new Person() { Id = 3, Age = 255, Name = "王五", key = new PersonKey() { Id = "wangwu" } };


            HashTable<PersonKey, Person> hashTable = new HashTable<PersonKey, Person>();
            hashTable.Add(zhangsan.key, zhangsan);
            hashTable.Add(lisi.key, lisi);
            hashTable.Add(wangwu.key, wangwu);


            var key = new PersonKey() { Id = "wangwu" };
            var user = hashTable.Get(key);
            user.Print();


            Console.ReadKey();
        }
    }
    public class Person
    {
        public PersonKey key { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Print()
        {
            Console.WriteLine($"姓名为:{Name}==年龄为:{Age}");
        }
    }

    public class PersonKey
    {
        public string Id { get; set; }

        public override int GetHashCode()
        {
            var id = string.Empty;
            //模拟哈希冲突
            if (this.Id.Contains("a"))
            {
                id = "a";
            }
            else
            {
                id = this.Id;
            }
            return hashCode(id);

        }
        public override bool Equals(object obj)
        {
            var key = obj as PersonKey;
            return key.Id == this.Id;
        }
        private int hashCode(string str)
        {
            int hash = 0;
            int h = 0;
            var value = str.ToCharArray();
            if (h == 0 && value.Length > 0)
            {
                char[] val = value;
                for (int i = 0; i < value.Length; i++)
                {
                    h = 31 * h + val[i];
                }
                hash = h;
            }
            return h;
        }

    }
}
