using core_lib;
using System;

namespace native_netcore_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert Json!");

            var user1 = new User { Name = "Frank", Age = 18 };
            var json1 = user1.ToJson();
            Console.WriteLine(json1);
            var back1 = json1.FromJson<User>();
            Console.WriteLine(back1.ToString());

            Console.ReadKey();
        }
    }

    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
