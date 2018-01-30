using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_进程
{
    class Program
    {
        static void Main(string[] args)
        {
            //存储着我们计算机当前正在运行的进程
            //Process[] pro =  Process.GetProcesses();
            //foreach (var item in pro)
            //{
            //    //item.Kill();
            //    Console.WriteLine(item.ProcessName);
            //}

            //使用进程来打开应用程序
            //Process.Start("notepad");//打开记事本
            //Process.Start("mspaint");//打开画图工具
            //Process.Start("Chrome", "http://www.baidu.com");//用谷歌浏览器打开百度
            //Process.Start("calc");//打开计算器

            //使用进程来打开文件

            //封装我们要打开的文件，但是并不去打开这个文件
            ProcessStartInfo psi = new ProcessStartInfo(@"D:\C#\2016传智播客.NET第24期就业班\01 基础加强六天\2015-04-14基础加强1\资料\资料\0413.Net就业班第一天.txt");
            // 创建进程对象
            Process pro = new Process();
            //告诉进程要打开的文件信息
            pro.StartInfo = psi;
            //调用函数打开
            pro.Start();

            Console.ReadKey();
        }
    }
}
