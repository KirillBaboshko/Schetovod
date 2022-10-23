using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schetovod
{
    public partial class Form1 : Form
    {

        DateTime end;
        public Form1()
        {
            InitializeComponent();
            Text = "END";
            BackColor = Color.Cyan;
            Size = new Size(700, 400);
            StartPosition = FormStartPosition.Manual;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            end= new DateTime(2022, 10, 23,(int)numericUpDown1.Value, (int)numericUpDown2.Value, 0);
            label1.Text ="Hours: "+ (end - DateTime.Now).Hours + " Minutes: " + (end - DateTime.Now).Minutes + " Seconds: " + (end - DateTime.Now).Seconds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
