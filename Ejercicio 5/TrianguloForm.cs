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
    public partial class TrianguloForm : Form
    {
        Triangulo iTriangulo;
        FacadeFormas iFFormas = new FacadeFormas(); //fachada
        public TrianguloForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Punto punto1 = iFFormas.CrearPunto(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            Punto punto2 = iFFormas.CrearPunto(Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
            Punto punto3 = iFFormas.CrearPunto(Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text));
            iTriangulo = iFFormas.CrearTriangulo(punto1, punto2, punto3);
            MessageBox.Show("Area: " + iFFormas.AreaTriangulo(iTriangulo) +
                "        Perimetro: " + iFFormas.PerimetroTriangulo(iTriangulo));
        }
    }
}
