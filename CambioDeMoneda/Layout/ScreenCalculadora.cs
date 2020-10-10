using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CambioDeMoneda.Layout
{
    public partial class ScreenCalculadora : Form
    {
        //Variables
        Double P1;
        Double P2;
        String Op = null;

        public ScreenCalculadora()
        {
            InitializeComponent();
        }

        //Control de botones.
        private void But1_Click(object sender, EventArgs e)
        {
            TBScreen.Text = TBScreen.Text + But1.Text;
        }

        private void But2_Click(object sender, EventArgs e)
        {
            TBScreen.Text = TBScreen.Text + But2.Text;
        }

        private void But3_Click(object sender, EventArgs e)
        {
            TBScreen.Text = TBScreen.Text + But3.Text;
        }

        private void But4_Click(object sender, EventArgs e)
        {
            TBScreen.Text = TBScreen.Text + But4.Text;
        }

        private void But5_Click(object sender, EventArgs e)
        {
            TBScreen.Text = TBScreen.Text + But5.Text;
        }

        private void But6_Click(object sender, EventArgs e)
        {
            TBScreen.Text = TBScreen.Text + But6.Text;
        }

        private void But7_Click(object sender, EventArgs e)
        {
            TBScreen.Text = TBScreen.Text + But7.Text;
        }

        private void But8_Click(object sender, EventArgs e)
        {
            TBScreen.Text = TBScreen.Text + But8.Text;
        }

        private void But9_Click(object sender, EventArgs e)
        {
            TBScreen.Text = TBScreen.Text + But9.Text;
        }

        private void But0_Click(object sender, EventArgs e)
        {
            TBScreen.Text = TBScreen.Text + But0.Text;
        }

        private void ButAC_Click(object sender, EventArgs e)
        {
            TBScreen.Text = "";
        }
        //Fin control de botones.

        //Conocer operacion.
        private void ButPlus_Click(object sender, EventArgs e)
        {
            P1 = Double.Parse(TBScreen.Text);
            Op = ButPlus.Text;
            LabelEstado.Text = "sumando";
            TBScreen.Text = "";
        }

        private void ButRest_Click(object sender, EventArgs e)
        {
            P1 = Double.Parse(TBScreen.Text);
            Op = ButRest.Text;
            LabelEstado.Text = "restando";
            TBScreen.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            P1 = Double.Parse(TBScreen.Text);
            Op = ButX.Text;
            LabelEstado.Text = "multiplicando";
            TBScreen.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            P1 = Double.Parse(TBScreen.Text);
            Op = ButDiv.Text;
            LabelEstado.Text = "dividiendo";
            TBScreen.Text = "";
        }
        //Fin para saber la operacion.

        //Calcular el resultado.
        private void ButFin_Click(object sender, EventArgs e)
        {
            //Variables de resultado
            Double Res;
            Double Sum;
            Double Mult;
            Double Div;

            //Segundo valor.
            P2 = Double.Parse(TBScreen.Text);

            switch (Op)
            {
                case "+":
                    Sum = P1 + P2;
                    TBScreen.Text = Sum.ToString();
                    break;
                case "-":
                    Res = P1 - P2;
                    TBScreen.Text = Res.ToString();
                    break;
                case "*":
                    Mult = P1 * P2;
                    TBScreen.Text = Mult.ToString();
                    break;
                case "/":
                    Div = P1 / P2;
                    if (Div != 0)
                    {
                        TBScreen.Text = Div.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir entre 0.");
                    }
                    
                    break;
            }

            LabelEstado.Text = "";
        }
        //Fin

    }

}
