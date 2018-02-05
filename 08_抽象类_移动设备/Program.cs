using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_抽象类_移动设备
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer cpu = new Computer();
            cpu.Ms = new MobilDisk();
            cpu.CpuRead();
            cpu.CpuWrite();
            Console.ReadKey();
        }
    }
    abstract class MobileStorage
    {
        public abstract void Read();
        public abstract void Write();
    }

    class Computer
    {
        private MobileStorage _ms;

        internal MobileStorage Ms { get => _ms; set => _ms = value; }

        public void CpuRead()
        {
            Ms.Read();
        }
        public void CpuWrite()
        {
            Ms.Write();
        }
    }

    class UDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("U盘在读数据");
        }

        public override void Write()
        {
            Console.WriteLine("U盘在写数据");
        }
    }
    class MobilDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘在读数据");
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘在写数据");
        }
    }
}
