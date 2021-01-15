using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_2020_01_HW02_9A713023.Properties;

namespace WP_2020_01_HW02_9A713023
{
    public partial class Form1 : Form
    {
        List<Image> list = new List<Image>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list.Add(Resources._001);
            list.Add(Resources._002);
            list.Add(Resources._003);
            list.Add(Resources._004);
            list.Add(Resources._2C);
            list.Add(Resources._2D);
            list.Add(Resources._2H);
            list.Add(Resources._2S);
            list.Add(Resources._3C);
            list.Add(Resources._3D);
            list.Add(Resources._3H);
            list.Add(Resources._3S);
            list.Add(Resources._4C);
            list.Add(Resources._4D);
            list.Add(Resources._4H);
            list.Add(Resources._4S);
            list.Add(Resources._5C);
            list.Add(Resources._5D);
            list.Add(Resources._5H);
            list.Add(Resources._5S);
            list.Add(Resources._6C);
            list.Add(Resources._6D);
            list.Add(Resources._6H);
            list.Add(Resources._6S);
            list.Add(Resources._7C);
            list.Add(Resources._7D);
            list.Add(Resources._7H);
            list.Add(Resources._7S);
            list.Add(Resources._8C);
            list.Add(Resources._8D);
            list.Add(Resources._8H);
            list.Add(Resources._8S);
            list.Add(Resources._9C);
            list.Add(Resources._9D);
            list.Add(Resources._9H);
            list.Add(Resources._9S);
            list.Add(Resources._10C);
            list.Add(Resources._10D);
            list.Add(Resources._10H);
            list.Add(Resources._10S);
            list.Add(Resources.JC);
            list.Add(Resources.JD);
            list.Add(Resources.JH);
            list.Add(Resources.JS);
            list.Add(Resources.QC);
            list.Add(Resources.QD);
            list.Add(Resources.QH);
            list.Add(Resources.QS);
            list.Add(Resources.KC);
            list.Add(Resources.KD);
            list.Add(Resources.KH);
            list.Add(Resources.KS);
      
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            poker poker1 = new poker();
            List<int> poker = poker1.GetPoker(52);

            string msg = "";
            for (int i = 0; i < poker.Count; i++)
            {
                msg += $"{poker[i]} ,";
            }
            picResult.Image = list[poker[0]];
           
        }

        
        private void pokerBox_Click(object sender, EventArgs e)
        {

        }
    }
}
