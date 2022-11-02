using System;
/*
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Windows.Forms;
using System.Media;
//using System.IO;
namespace 项目_数的性质
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.ResourceManager.GetStream("Rick"));
            soundPlayer.Play();
            soundPlayer.PlayLooping();
            
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.ResourceManager.GetStream("musTitleScreen"));
            soundPlayer.Play();
            soundPlayer.PlayLooping();*/
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.ResourceManager.GetStream("musTitleScreen"));
            soundPlayer.PlayLooping();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //taida.Text = "计算中";
            long textshuru = Convert.ToInt64(textbox1.Text);
            if (textshuru < 2147483648)
            {
                //质数
                int zh = Convert.ToInt32(textbox1.Text);
                int t = (int)Math.Sqrt(zh);
                int i;
                for (i = 2; i <= t; i++)
                {
                    if (zh % i == 0)
                    {
                        break;
                    }
                }
                if (zh == 1)
                {
                    shifousushu.Text = zh + "不是素数";
                }
                else if (i <= t)
                {
                    shifousushu.Text = zh + "不是素数";
                }
                else
                {
                    shifousushu.Text = zh + "是素数";
                }
                //质数

                //所有因数
                int jigeyinshue = 1;
                int yinshuhee = 0;
                string yigong = "";
                int text = int.Parse(textbox1.Text);
                int text2 = text - 1;
                for (int j = 1; text2 > j; j += 1)
                {
                    if (text % j == 0)
                    {
                        yigong = yigong + j.ToString() + ",";
                        jigeyinshue = jigeyinshue + 1;
                        yinshuhee = yinshuhee + j;
                    }
                }
                yigong = yigong + text.ToString() + "。";
                yinshuhee = yinshuhee + text;
                if (text == 2)
                {
                    yigong = "1,2。";
                    jigeyinshue = 2;
                    yinshuhee = 3;
                }
                //所有因数

                //素因数分解
                string sysfj = "";
                int io = 2, k, jo, n1;
                double n = double.Parse(textbox1.Text);
                n1 = (int)n;
                if (n == 1)
                    sysfj = "Err";
                else
                {
                    k = (int)Math.Sqrt(n);
                    for (jo = 2; jo <= k; jo++)
                        if (n % jo == 0)
                            break;
                    if (jo > k)
                        sysfj = n + "=" + n;
                    else
                    {
                        sysfj = n + "=";
                        for (io = 1; n != 1; io++)
                        {
                            k = (int)Math.Sqrt(io);
                            for (jo = 2; jo <= k; jo++)
                                if (io % jo == 0)
                                    break;
                            if (jo > k && (int)n % io == 0 && io != 1)
                            {
                                sysfj = sysfj + io;
                                n = (int)n / io;
                                if (n != 1)
                                    sysfj = sysfj + "×";
                                io = 1;
                            }
                        }
                    }
                }
                //素因数分解

                //几个因数
                string jigeyinshuee = jigeyinshue.ToString();
                //几个因数

                //完全数
                if (yinshuhee-text == text)
                {
                    wanquanshu.Text = "是";
                }
                else
                    wanquanshu.Text = "否";
                //完全数

                //显示
                string yinshuheee = yinshuhee.ToString();
                taida.Text = "";
                textlabel.Text = textbox1.Text;
                syys.Text = yigong;
                suyinshu.Text = sysfj;
                jigeyinshu.Text = jigeyinshuee;
                yinshuhe.Text = yinshuheee;
                //显示
                //hh

                //hh
            }
            else
            {
                //taida
                taida.Text = "太大";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            string shuru = textbox1.Text;
        }
        /*
        private void IWM_Click(object sender, EventArgs e)
        {
            bool IWM_zt = true;
            bool Rick_zt = false;
        }
        private void RICKA_Click(object sender, EventArgs e)
        {
            bool IWM_zt = false;
            bool Rick_zt = true;
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            bool IWM_zt = false;
            bool Rick_zt = false;
            
        }*/
    }
}
