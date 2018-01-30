using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_打开文件练习
{
    class BaseFile
    {
        // 字段、属性、构造函数、函数、索引器
        private string _filePath;

        public string FilePath  // Ctrl+r+e
        {
            get
            {
                return _filePath;
            }

            set
            {
                _filePath = value;
            }
        }

        //自动属性 prop + 两下tab
        public string FileName { get; set; }

        //public BaseFile() { }
        public BaseFile(string filePath, string fileName)
        {
            this.FilePath = filePath;
            this.FileName = fileName;
        }

        //设计一个函数  用来打开指定文件
        public void OpenFile()
        {
            ProcessStartInfo psi = new ProcessStartInfo(this.FilePath + "\\" + this.FileName);
            Process pro = new Process();
            pro.StartInfo = psi;
            pro.Start();

        }
    }
}
