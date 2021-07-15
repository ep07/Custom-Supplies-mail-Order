using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Suppliies_mail_order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Show();
            label3.Show();
            label5.Text = "Tricia Mills"; 
            label5.Refresh();
            label4.Text = "500-1111";
            label4.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Show();
            label3.Show();
            label5.Text = "Michelle Riggner";
            label5.Refresh();
            label4.Text = "500-2222";
            label4.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Show();
            label3.Show();
            label5.Text = "Kenna Devoss";
            label5.Refresh();
            label4.Text = "500-3333";
            label4.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Show();
            label3.Show();
            label5.Text = "Eric Andrews";
            label5.Refresh();
            label4.Text = "500-4444";
            label4.Refresh();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
