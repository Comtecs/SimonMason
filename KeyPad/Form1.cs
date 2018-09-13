using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace KeyPad
{
    public partial class Form1 : Form
    {
        private Stopwatch sw = new Stopwatch();
        private int key1charcounter = 0;
        private int key2charcounter = 0;
        private int key3charcounter = 0;
        private int key4charcounter = 0;
        private int key5charcounter = 0;
        private int key6charcounter = 0;
        private int key7charcounter = 0;
        private int key8charcounter = 0;
        private int key9charcounter = 0;
        private int key10charcounter = 0;
        private int key11charcounter = 0;

        public Form1()
        {
            InitializeComponent();

            SetKeys(1,  "" );
            SetKeys(2, "a,b,c");
            SetKeys(3, "d,e,f");
            SetKeys(4, "g,h,i");
            SetKeys(5, "j,k,l");
            SetKeys(6, "m,n,o");
            SetKeys(7, "p,q,r,s");
            SetKeys(8, "t,u,v");
            SetKeys(9, "w,x,y,z");
            SetKeys(10, "");
            SetKeys(11, " ");

            sw.Start();
        }

        private void SetKeys(int keynumber, string assignedletters)
        {
            string[] arrOfassignedletters = assignedletters.Split(',');
            List<string> listOfassignedletters = new List<string>();
            listOfassignedletters = arrOfassignedletters.OfType<string>().ToList();

            switch (keynumber)
            {
                case 1: listOfassignedletters.ForEach((item) => button1.Text += item.ToString());
                    break;
                case 2: listOfassignedletters.ForEach((item) => button2.Text += item.ToString());
                    break;
                case 3: listOfassignedletters.ForEach((item) => button3.Text += item.ToString());
                    break;
                case 4: listOfassignedletters.ForEach((item) => button4.Text += item.ToString());
                    break;
                case 5: listOfassignedletters.ForEach((item) => button5.Text += item.ToString());
                    break;
                case 6: listOfassignedletters.ForEach((item) => button6.Text += item.ToString());
                    break;
                case 7: listOfassignedletters.ForEach((item) => button7.Text += item.ToString());
                    break;
                case 8: listOfassignedletters.ForEach((item) => button8.Text += item.ToString());
                    break;
                case 9: listOfassignedletters.ForEach((item) => button9.Text += item.ToString());
                    break;
                case 10: listOfassignedletters.ForEach((item) => button10.Text += item.ToString());
                    break;
                case 11: listOfassignedletters.ForEach((item) => button11.Text += item.ToString());
                    break;
                default:
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (key1charcounter < button1.Text.ToString().Replace("1 ", "").Length)
            {
                key1charcounter++;
                sw.Reset();
                sw.Restart();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (key2charcounter < button2.Text.ToString().Replace("2 ","").Length)
            {
                key2charcounter++;
                sw.Reset();
                sw.Restart();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (key3charcounter < button3.Text.ToString().Replace("3 ", "").Length)
            {
                key3charcounter++;
                sw.Reset();
                sw.Restart();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (key4charcounter < button4.Text.ToString().Replace("4 ", "").Length)
            {
                key4charcounter++;
                sw.Reset();
                sw.Restart();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (key5charcounter < button5.Text.ToString().Replace("5 ", "").Length)
            {
                key5charcounter++;
                sw.Reset();
                sw.Restart();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (key6charcounter < button6.Text.ToString().Replace("6 ", "").Length)
            {
                key6charcounter++;
                sw.Reset();
                sw.Restart();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (key7charcounter < button7.Text.ToString().Replace("7 ", "").Length)
            {
                key7charcounter++;
                sw.Reset();
                sw.Restart();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (key8charcounter < button8.Text.ToString().Replace("8 ", "").Length)
            {
                key8charcounter++;
                sw.Reset();
                sw.Restart();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (key9charcounter < button9.Text.ToString().Replace("9 ", "").Length)
            {
                key9charcounter++;
                sw.Reset();
                sw.Restart();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (key10charcounter < button10.Text.ToString().Replace("* ", "").Length)
            {
                key2charcounter++;
                sw.Reset();
                sw.Restart();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (key11charcounter < button11.Text.ToString().Replace("0 ", "").Length)
            {
                key11charcounter++;
                sw.Reset();
                sw.Restart();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SendKeys.Send("(#)");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = sw.Elapsed;

            if (key1charcounter > 0 && ts.Milliseconds > 500)
            {
                textBox1.Text += button1.Text.ToString().Substring(key1charcounter + 1, 1);
                sw.Reset();
                sw.Restart();
                key1charcounter = 0;
            }            

            if (key2charcounter > 0 && ts.Milliseconds > 500)
            {
                textBox1.Text += button2.Text.ToString().Substring(key2charcounter + 1, 1);
                sw.Reset();
                sw.Restart();
                key2charcounter = 0;
            }

            if (key3charcounter > 0 && ts.Milliseconds > 500)
            {
                textBox1.Text += button3.Text.ToString().Substring(key3charcounter + 1, 1);
                sw.Reset();
                sw.Restart();
                key3charcounter = 0;
            }

            if (key4charcounter > 0 && ts.Milliseconds > 500)
            {
                textBox1.Text += button4.Text.ToString().Substring(key4charcounter + 1, 1);
                sw.Reset();
                sw.Restart();
                key4charcounter = 0;
            }

            if (key5charcounter > 0 && ts.Milliseconds > 500)
            {
                textBox1.Text += button5.Text.ToString().Substring(key5charcounter + 1, 1);
                sw.Reset();
                sw.Restart();
                key5charcounter = 0;
            }

            if (key6charcounter > 0 && ts.Milliseconds > 500)
            {
                textBox1.Text += button6.Text.ToString().Substring(key6charcounter + 1, 1);
                sw.Reset();
                sw.Restart();
                key6charcounter = 0;
            }

            if (key7charcounter > 0 && ts.Milliseconds > 500)
            {
                textBox1.Text += button7.Text.ToString().Substring(key7charcounter + 1, 1);
                sw.Reset();
                sw.Restart();
                key7charcounter = 0;
            }

            if (key8charcounter > 0 && ts.Milliseconds > 500)
            {
                textBox1.Text += button8.Text.ToString().Substring(key8charcounter + 1, 1);
                sw.Reset();
                sw.Restart();
                key8charcounter = 0;
            }

            if (key9charcounter > 0 && ts.Milliseconds > 500)
            {
                textBox1.Text += button9.Text.ToString().Substring(key9charcounter + 1, 1);
                sw.Reset();
                sw.Restart();
                key9charcounter = 0;
            }

            if (key10charcounter > 0 && ts.Milliseconds > 500)
            {
                textBox1.Text += button10.Text.ToString().Substring(key10charcounter + 1, 1);
                sw.Reset();
                sw.Restart();
                key10charcounter = 0;
            }

            if (key11charcounter > 0 && ts.Milliseconds > 500)
            {
                textBox1.Text += button11.Text.ToString().Substring(key11charcounter + 1, 1);
                sw.Reset();
                sw.Restart();
                key11charcounter = 0;
            }

        }

    }
}
