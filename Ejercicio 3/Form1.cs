using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("UNO");
            comboBox1.Items.Add("DOS");
            comboBox1.Items.Add("TRES");
            comboBox1.Items.Add("CUATRO");
            comboBox1.Items.Add("CINCO");
            comboBox1.Items.Add("SEIS");
            comboBox1.Items.Add("SIETE");
            comboBox1.Items.Add("OCHO");
            comboBox1.Items.Add("NUEVE");
            comboBox1.Items.Add("DIEZ");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case ("UNO"):
                    {
                        label3.Text = "ONE";
                        break;
                    }
                case ("DOS"):
                    {
                        label3.Text = "TWO";
                        break;
                    }
                case ("TRES"):
                    {
                        label3.Text = "THREE";
                        break;
                    }
                case ("CUATRO"):
                    {
                        label3.Text = "FOUR";
                        break;
                    }
                case ("CINCO"):
                    {
                        label3.Text = "FIVE";
                        break;
                    }
                case ("SEIS"):
                    {
                        label3.Text = "SIX";
                        break;
                    }
                case ("SIETE"):
                    {
                        label3.Text = "SEVEN";
                        break;
                    }
                case ("OCHO"):
                    {
                        label3.Text = "EIGHT";
                        break;
                    }
                case ("NUEVE"):
                    {
                        label3.Text = "NINE";
                        break;
                    }
                case ("DIEZ"):
                    {
                        label3.Text = "TEN";
                        break;
                    }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}
