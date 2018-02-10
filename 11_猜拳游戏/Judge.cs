using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_猜拳游戏
{
    enum Result
    {
        玩家赢,
        电脑赢,
        平手
    }
    class Judge
    {
        public Result GetResult(int playerNum,int cpuNum)
        {
            if (playerNum - cpuNum == -1 || playerNum-cpuNum==2)
            {
                return Result.玩家赢;
            }
            else if (playerNum - cpuNum == -2 || playerNum - cpuNum == 1)
            {
                return Result.电脑赢;
            }
            else
            {
                return Result.平手;
            }
        }
    }
}
