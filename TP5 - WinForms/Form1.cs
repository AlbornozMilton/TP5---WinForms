using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5___WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            if (checkBox1.Checked)
            {
                form.box4.Text = "activado";
            }
            if (checkBox2.Checked)
            {
                form.box5.Text = "activado";
            }
            if (radioButton1.Checked)
            {
                form.box1.Text = "activado";
            }
            if (radioButton2.Checked)
            {
                form.box2.Text = "activado";
            }
            if (radioButton3.Checked)
            {
                form.box3.Text = "activado";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
