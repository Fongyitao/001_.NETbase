using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_猜拳游戏
{
    class Player
    {
        public int ChuQuan(string str)//石头 剪刀 布
        {
            int res = 0;
            switch (str)
            {
                case "石头":res=1;
                    break;
                case "剪刀":res = 2;
                    break;
                case "布":res = 3;
                    break;
                default:
                    break;
            }
            return res;
        }
    }
}
