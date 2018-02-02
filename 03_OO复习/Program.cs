using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OO复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Person zsPerson = new Person("张三", -5, '春');
            zsPerson.SayHi();
            Console.ReadKey();
        }
    }
    class Person
    {
        //字段、属性、函数、构造
        //字段：存储数据
        //属性：保护字段get set
        //函数：描述对象行为
        //构造函数：初始化对象

        private string _name;

        public string GetName()
        {
            return _name;
        }

        public void SetName(string value)
        {
            _name = value;
        }
        private int _age;

        public int GetAge()
        {
            return _age;
        }

        public void SetAge(int value)
        {
            if (value < 0 || value >200)
            {
                value = 0;
            }
            _age = value;
        }
        public char Gender{ get; set; }

        public Person(string name, int age, char gender)
        {
            SetName(name);
            SetAge(age);
            if (gender != '男' && gender != '女')
            {
                gender = '男';
            }
            Gender = gender;
        }

        public Person()
        {
        }

        public void SayHi()
        {
            Console.WriteLine("大家好，我的名字叫{0}，我今年{1}岁了，我是{2}生。",GetName(),GetAge(),Gender);
        }

    }
}
