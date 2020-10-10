using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CambioDeMoneda.Class;

namespace CambioDeMoneda.Layout
{
    public partial class Screen1 : Form
    {
        //Importar clase de operaciones.
        Class.Operaciones Operaciones = new Class.Operaciones();
        ScreenCalculadora Sc = new ScreenCalculadora();

        //Variables generales.
        Double cantidad;

        //Inicializar ventana.
        public Screen1()
        {
            InitializeComponent();
        }

        //Lanzar calculadora.
        private void caluladoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sc.Show();
        }

        //Evento click en boton,
        private void ButtConvertir_Click(object sender, EventArgs e)
        {

            //Variables
            String option = null;
            //FIn

            //Revisar que tipo de conversion será
            foreach (RadioButton rb in GroupBoxOption.Controls)
            {
                if (rb.Checked)
                {
                    option = rb.Text;
                }
            }
            //Fin

            //Recojer valores.
            cantidad = Double.Parse(TextBoxCantidad.Text);
            //Fin

            //Validar opcion.
            switch (option)
            {
                case "Pesos a dolares.":
                    Operaciones.CalcularDivisaPtoD(cantidad);
                    TextBoxCambioTotal.Text = Operaciones.cantidadTotal.ToString();
                    break;
                case "Dolares a pesos.":
                    Operaciones.CalcularDivisaDtoP(cantidad);
                    TextBoxCambioTotal.Text = Operaciones.cantidadTotal.ToString();
                    break;

            }
            //Fin
        }
    }
}
