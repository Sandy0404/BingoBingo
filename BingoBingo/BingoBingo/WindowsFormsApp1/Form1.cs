using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.Timers;
using Timer = System.Windows.Forms.Timer;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Label> listLabels = new List<Label>();
        List<Label> listLabels2 = new List<Label>();
        List<string> listOutput = new List<string>();
        List<int> listOutput2 = new List<int>();
        List<int> listOutput3 = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listLabels.Add(lbl亂數1);
            listLabels.Add(lbl亂數2);
            listLabels.Add(lbl亂數3);

            listLabels2.Add(label8);
            listLabels2.Add(label7);
            listLabels2.Add(label6);
        }
        private void 產生亂數_Click(object sender, EventArgs e)
        {
            HashSet<int> myRandomNumbers = new HashSet<int>();
            Random rand = new Random();
            int index = 0;

            while (myRandomNumbers.Count < 3)
            {
                int newRandomNumber = rand.Next(1, 81);
                myRandomNumbers.Add(newRandomNumber);
            }

            List<int> myRandomNumbersList = myRandomNumbers.ToList();
            myRandomNumbersList.Sort();

            foreach (int num in myRandomNumbersList)
            {
                listLabels[index].Text = num.ToString();
                txtOutpute.Text += num.ToString() + "  ";
                index++;
            }
            txtOutpute.Text += "\r\n";
        }

        private void btn兌獎_Click(object sender, EventArgs e)
        {//是否為空進行判斷
            HashSet<string> numbers = new HashSet<string> { txt樂透1.Text, txt樂透2.Text, txt樂透3.Text };

            if (numbers.Count == 3)
            {
                if (numbers.Contains(label6.Text) && numbers.Contains(label7.Text) && numbers.Contains(label8.Text))
                {
                    lbl1回應訊息.Text = "中頭獎";
                }
                else if (numbers.Contains(label7.Text) && (numbers.Contains(label6.Text) || numbers.Contains(label8.Text)) || numbers.Contains(label6.Text) && numbers.Contains(label8.Text))
                {
                    lbl1回應訊息.Text = "中2";
                }
                else if (numbers.Contains(label6.Text) || numbers.Contains(label7.Text) || numbers.Contains(label8.Text))
                {
                    lbl1回應訊息.Text = "中1";
                }
                else
                {
                    lbl1回應訊息.Text = "沒中";
                }
            }
            else
            {
                MessageBox.Show("請輸入數值");
                txt樂透1.Clear();
                txt樂透2.Clear();
                txt樂透3.Clear();
            }
        }

        //包牌
        private void btn產生號碼_Click(object sender, EventArgs e)
        {
            Random myRandom = new Random();
            int myRandNum = 0;
            String r3 = "";
            int i, j = 1;
            if (textBox包牌.Text != "")
            {
                int inputA = int.Parse(textBox包牌.Text);
                for (i = 1; i <= inputA; i++)
                {
                    for (j = 1; j <= 3; j++)
                    {
                        myRandNum = myRandom.Next(1, 81);
                        r3 += myRandNum + "  ";
                    }
                 if (myRandNum == myRandNum)
                 {
                    myRandNum = myRandom.Next(1, 81);
                 }
                     r3 += "\r\n";
                     r3.ToList();
                }
            }
            else
            {
                MessageBox.Show("請輸入包牌數量");
            }
            lbl產生號碼.Text = $"{r3}";
        }

        private void btn開獎結果_Click(object sender, EventArgs e)
        {
            HashSet<int> myRandomNumbers = new HashSet<int>();
            Random rand = new Random();

            while (myRandomNumbers.Count < 3)
            {
                int newRandomNumber = rand.Next(1, 81);
                myRandomNumbers.Add(newRandomNumber);
            }

            List<int> myRandomNumbersList = myRandomNumbers.ToList();
            myRandomNumbersList.Sort();

            int index = 0;
            foreach (int num in myRandomNumbersList)
            {
                listLabels2[index].Text = num.ToString();
                index++;
            }
        }

        private void Timer(object sender, EventArgs e)
        {
            HashSet<int> myRandomNumbers = new HashSet<int>();
            Random rand = new Random();
            int index = 0;

            while (myRandomNumbers.Count < 3)
            {
                int newRandomNumber = rand.Next(1, 81);
                myRandomNumbers.Add(newRandomNumber);
            }

            List<int> myRandomNumbersList = myRandomNumbers.ToList();
            myRandomNumbersList.Sort();

            foreach (int num in myRandomNumbersList)
            {
                listLabels[index].Text = num.ToString();
                txtOutpute.Text += num.ToString() + "  ";
                index++;
            }
            txtOutpute.Text += "\r\n";
        }

        private void btn停止產生號碼_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
        }

        private void btn5秒產生一組_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000 ;
            timer1.Enabled = true;
            timer1.Start();
        }
    }
}