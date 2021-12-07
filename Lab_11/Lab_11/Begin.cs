using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_11
{
    public partial class Begin : Form
    {
        public Begin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Work wk = new Work();
            EWork ewk = new EWork();
            string RB = this.textBox1.Text;
            int flag = 0;
            if (radioButton1.Checked)
            {
                for (int i = 0; i < RB.Length; i++)
                {
                    char ch = RB[i];
                    if (Char.IsLetter(ch) == false)
                    {
                        flag++;
                    }
                }

                if(flag >= 1)
                {
                    ewk.ShowDialog();
                }
                else
                {
                    wk.textBox1.Text = RB.ToUpper();
                    wk.ShowDialog();
                }
            }

            if (radioButton2.Checked)
            {
                flag = 0;
                for(int i = 0;i<RB.Length;i++)
                {
                    char ch = RB[i];
                    if (Char.IsLetter(ch) == false)
                    {
                        flag++;
                    }
                }
                if (flag >= 1)
                {
                    ewk.ShowDialog();
                }
                else
                {
                    string s2;
                    for (int i = RB.Length - 1; i >= 0; i--)
                    {
                        wk.textBox1.Text += s2 = RB[i].ToString();
                    }


                    //wk.textBox1.Text = RB.ToLower();
                    wk.ShowDialog();
                }
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
