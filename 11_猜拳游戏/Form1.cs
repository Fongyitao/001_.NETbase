using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_猜拳游戏
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void btnStone_MouseClick(object sender, MouseEventArgs e)
        {
            string str = "石头";
            PlayGame(str);
        }

        private void PlayGame(string str)
        {
            Player player = new Player();
            int playerNum = player.ChuQuan(str);
            lblPlayer.Text = str;

            Computer computer = new Computer();
            int computerNum = computer.ChuQuan();
            //将电脑出拳值赋给lblCpu
            lblCpu.Text = computer.Str;

            Judge judge = new Judge();
            Result res = judge.GetResult(playerNum, computerNum);
            lblResult.Text = res.ToString();
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            string str = "剪刀";
            PlayGame(str);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            string str = "布";
            PlayGame(str);
        }
    }
}
