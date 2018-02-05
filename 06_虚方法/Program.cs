using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_虚方法
{
    class Program
    {
        static void Main(string[] args)
        {
            // 员工9点打卡,经理11点打卡,程序员不打卡
            Employee[] employees = { new Employee(), new Manage(), new Programer() };
            foreach (var item in employees)
            {
                item.DaKa();
            }
            /*
            员工9点打卡
            经理11点打卡
            员工9点打卡
            */

            Programer zsProgramer = new Programer();
            zsProgramer.DaKa();//程序员不打卡

            Console.ReadKey();
        }
    }
    class Employee
    {
        public virtual void DaKa()
        {
            Console.WriteLine("员工9点打卡");
        }
    }
    class Manage:Employee
    {
        public override void DaKa()
        {
            Console.WriteLine("经理11点打卡");
        }
    }
    class Programer : Employee
    {
        //通过new关键字隐藏父类的DaKa方法
        public new void DaKa()
        {
            Console.WriteLine("程序员不打卡");
        }
    }
}
