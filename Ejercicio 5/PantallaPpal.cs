using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5
{
    public partial class PantallaPpal : Form
    {
        public PantallaPpal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                CirculoForm CForm = new CirculoForm();
                CForm.Show();
            }
            else
            {
                TrianguloForm TForm = new TrianguloForm();
                TForm.Show();
            }
        }
    }
}
