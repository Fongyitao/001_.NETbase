using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_猜拳游戏
{
    class Computer
    {
        Random r = new Random();
        private string _str;

        public string Str { get => _str; set => _str = value; }

        public int ChuQuan()
        {
            int rNum = r.Next(1, 4);
            switch (rNum)
            {
                case 1:this.Str = "石头";
                    break;
                case 2:this.Str = "剪刀";
                    break;
                case 3:this.Str = "布";
                    break;
                default:
                    break;
            }
            return rNum;
        }
    }
}
