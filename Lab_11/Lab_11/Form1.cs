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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About program = new About();
            program.ShowDialog();
        }

        private void beginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Begin program = new Begin();
            program.ShowDialog();
        }

        private void workToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Work program = new Work();
            program.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
