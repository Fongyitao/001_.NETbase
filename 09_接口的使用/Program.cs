using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_接口的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //实现多态
            IPlayBasketballable p1 = new Teacher();
            p1.PlayBasketball();
            Console.ReadKey();
        }
    }
    class Person
    {
        public void SayHi()
        {
            Console.WriteLine("我是Person");
        }
    }
    class Teacher : Person, IPlayBasketballable
    {
        public void PlayBasketball()
        {
            Console.WriteLine("Teacher会打篮球");
        }
    }
    class NBAPlayer : Person, IPlayBasketballable
    {
        public void PlayBasketball()
        {
            Console.WriteLine("NBAPlayer会打篮球");
        }
    }
    class Student : Teacher
    {
        
    }
    interface IPlayBasketballable
    {
        void PlayBasketball();
    }

}
