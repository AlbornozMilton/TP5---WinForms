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
    public partial class CirculoForm : Form
    {
        Circulo iCirculo;
        FacadeFormas iFFormas = new FacadeFormas(); //fachada
        public CirculoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double iX = Convert.ToDouble(textBox1.Text);
            double iY = Convert.ToDouble(textBox2.Text);
            double iRadio = Convert.ToDouble(textBox2.Text);
            iCirculo = iFFormas.CrearCirculo(iX, iY, iRadio);
            MessageBox.Show("Area: " + iFFormas.AreaCirculo(iCirculo) + 
                "        Perimetro: " + iFFormas.PerimetroCirculo(iCirculo));
        }
    }
}
