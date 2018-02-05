using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_静态类和静态成员
{
    class Program
    {
        //不是所有的静态成员都必须写在静态类中
        static void Main(string[] args)
        {
            Person zsPerson = new Person
            {
                Name = "张三",
                Age = 18,
                Email = "zsPerson@Google.com"
            };

            //在程序任何地方访问该静态成员,都是访问同一块内存,所以一个地方值改变,所有都改变
            Person.Plant = "地球";

            Person lsPerson = new Person
            {
                Name = "李四",
                Age = 12,
                Email = "lsPerson@qq.com"
            };


        }
    }
    static class MyClass
    {
        //静态类中只能放静态成员
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        
        //静态成员是属于"类"的,不是属于具体对象,
        //所以访问静态成员的时候不能通过对象访问,只能通过类名来访问
        public static string Plant { get; set; }
    }
}
