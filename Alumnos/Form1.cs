using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Ejemplo añadir funcionalidad

        int AñadirFuncionalidad(int numero)
        {
            int resultado = 0;
            int i = 0;

            while (i < numero)
            {
                resultado += 2;
            }

            return resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            AñadirFuncionalidad(numero);
            MessageBox.Show("Funcionalidad añadida al proyecto");
        }
    }
}
