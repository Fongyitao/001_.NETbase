using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            里氏转换：
			1、子类可以赋值给父类
            2、如果父类中装的是子类对象，则可以将这个父类转换为对应的子类对象
            */

            Person zsPerson = new Student();
            zsPerson.PSayHi();//我是Person

            /* 关键字
                 1、is：返回bool类型，指示是否可以做这个转换
                 2、as：如果转换成功，则返回对象，否则返回null
             作用：我们可以将所有的子类都当做是父类来看，针对父类进行编程，写出通用的代码，适应需求的不断改变。	
             */
            if (zsPerson is Teacher)
            {
                Teacher zsTeacher = (Teacher)zsPerson;
                zsTeacher.TSayHi();//我是Teacher
            }
            else
            {
                Console.WriteLine("转换失败");
            }

            Student zsStudent = zsPerson as Student;
            if (zsStudent != null)
            {
                Console.WriteLine("转换成功");
                zsStudent.SSayHi();//我是Student
            }
            else
            {
                Console.WriteLine("转换失败");
            }

            Console.ReadKey();
            /*结果:
            我是Person
            我是Teacher
            转换成功
            我是Student
            */
        }
    }
    class Person
    {
        public void PSayHi()
        {
            Console.WriteLine("我是Person");
        }
    }
    class Teacher : Person
    {
        public void TSayHi()
        {
            Console.WriteLine("我是Teacher");
        }
    }
    class Student : Teacher
    {
        public void SSayHi()
        {
            Console.WriteLine("我是Student");
        }
    }

}
