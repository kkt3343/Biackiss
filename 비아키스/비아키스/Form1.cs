using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 비아키스
{
    public partial class Form1 : Form
    {
        int i = 0;
        int j = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void R1_CheckedChanged(object sender, EventArgs e)
        {
            //11시인 경우
            mytext.Text = "11시 : ";
            i = 0;
        }

        private void R2_CheckedChanged(object sender, EventArgs e)
        {
            //5시인 경우
            mytext.Text = "5시 : ";
            i = 0;
        }

        private void R3_CheckedChanged(object sender, EventArgs e)
        {
            //7시인 경우
            mytext.Text = "7시 : ";
            i = 0;
        }

        private void redbutton_Click(object sender, EventArgs e)
        {
            //빨강추가
            if(mytext.Text=="없음")
            {
            }
            else
            {
                if (i < 5)
                {
                    mytext.Text = mytext.Text + "빨 ";
                    i++;
                }
            }           
        }

        private void blackbutton_Click(object sender, EventArgs e)
        {
            //검정추가
            if (mytext.Text == "없음")
            {
            }
            else
            {
                if (i < 5)
                {
                    mytext.Text = mytext.Text + "검 ";
                    i++;
                }
            }      
        }
        private void copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(mytext.Text);
        }

        private void fin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void a1_CheckedChanged(object sender, EventArgs e)
        {
            at.Text = "11시 : ";
        }

        private void a2_CheckedChanged(object sender, EventArgs e)
        {
            at.Text = "3시 : ";
        }

        private void a3_CheckedChanged(object sender, EventArgs e)
        {
            at.Text = "7시 : ";
        }

        bool ck = true;
        private void button1_Click(object sender, EventArgs e)
        {
            string p;
            if (a1.Checked == true)
            {
                p = "11시 : ";
                ck = true;
            }
            else if(a2.Checked == true)
            {
                p = "3시 : ";
                ck = true;
            }
            else if(a3.Checked == true)
            {
                p = "7시 : ";
                ck = true;
            }
            else
            {
                p = "없음";
                ck = false;
            }
            if(ck==false)
            {
                at.Text = p;
            }
            else
            {
                at.Text = p + "반접";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string p;
            if (a1.Checked == true)
            {
                p = "11시 : ";
                ck = true;
            }
            else if (a2.Checked == true)
            {
                p = "3시 : ";
                ck = true;
            }
            else if (a3.Checked == true)
            {
                p = "7시 : ";
                ck = true;
            }
            else
            {
                p = "없음";
                ck = false;
            }
            if (ck == false)
            {
                at.Text = p;
            }
            else
            {
                at.Text = p + "접";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string p;
            if (a1.Checked == true)
            {
                p = "11시 : ";
                ck = true;
            }
            else if (a2.Checked == true)
            {
                p = "3시 : ";
                ck = true;
            }
            else if (a3.Checked == true)
            {
                p = "7시 : ";
                ck = true;
            }
            else
            {
                p = "없음";
                ck = false;
            }
            if (ck == false)
            {
                at.Text = p;
            }
            else
            {
                at.Text = p + "핌";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(at.Text);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            if(R1.Checked==true)
            {
                i = 0;
                mytext.Text = "11시 : ";
            }
            else if(R2.Checked==true)
            {
                i = 0;
                mytext.Text = "5시 : ";
            }
            else if(R3.Checked==true)
            {
                i = 0;
                mytext.Text = "7시 : ";
            }
            else { }
        }
    }
}
