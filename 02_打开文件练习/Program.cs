using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_打开文件练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要打开的文件所在的路径：");
            string filePath = Console.ReadLine();
            Console.WriteLine("请输入要打开的文件名：");
            string fileName = Console.ReadLine();

            //通过简单工厂模式返回父类
            BaseFile bf = GetFiel(filePath, fileName);
            if (bf != null)
            {
                bf.OpenFile();
            }
        }
        static BaseFile GetFiel(string filePath, string fileName)
        {
            BaseFile bf = null;
            string strExtension = Path.GetExtension(fileName);
            switch (strExtension)
            {
                case ".txt":
                    bf = new TxtFile(filePath, fileName);
                    break;
                default:
                    break;
            }
            return bf;
        }
    }
}
