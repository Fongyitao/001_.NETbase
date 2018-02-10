using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_显示实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            I1 i1 = new Person();
            i1.Test();//显示实现接口的函数

            Person p1 = new Person();
            p1.Test();//Person自己的函数
            Console.ReadKey();

        }
    }
    class Person : I1
    {
        void I1.Test()
        {
            Console.WriteLine("显示实现接口的函数");
        }
        public void Test()
        {
            Console.WriteLine("Person自己的函数");
        }
    }
    interface I1
    {
        void Test();
    }
}
