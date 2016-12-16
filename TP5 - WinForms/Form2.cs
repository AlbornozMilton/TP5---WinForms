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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = "Desactivado";
            textBox2.Text = "Desactivado";
            textBox3.Text = "Desactivado";
            textBox4.Text = "Desactivado";
            textBox5.Text = "Desactivado";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public TextBox box1
        {
            get{ return textBox1; }
        }
        public TextBox box2
        {
            get { return textBox2; }
        }
        public TextBox box3
        {
            get { return textBox3; }
        }
        public TextBox box4
        {
            get { return textBox4; }
        }
        public TextBox box5
        {
            get { return textBox5; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
