using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_动物类继承
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = { new Cat(), new Dog() };
            foreach (var item in animals)
            {
                item.Bark();
                item.Drink();
            }

            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        //抽象成员只能存在于抽象类中
        public abstract void Bark();//父类不确定子类如何实现
        public abstract void Drink();
    }
    class Cat : Animal//一个子类继承了抽象类，那么子类必须全部实现父类中的抽象成员
    {
        public override void Bark()
        {
            Console.WriteLine("猫咪喵喵叫");
        }

        public override void Drink()
        {
            Console.WriteLine("猫咪舔着喝");
        }
    }
    class Dog : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("小狗汪汪叫");
        }

        public override void Drink()
        {
            Console.WriteLine("小狗舔着喝");
        }
    }
}
