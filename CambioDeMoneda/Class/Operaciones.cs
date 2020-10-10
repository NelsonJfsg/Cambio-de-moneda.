using CambioDeMoneda.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace CambioDeMoneda.Class
{
    class Operaciones
    {
        //Valor del dolar
        Double dolar = 21.13;
        public Double cantidadTotal;

        //Metodo para calcular la conversion de pesos a dolares.
        public void CalcularDivisaPtoD(Double cantidad)
        {
            cantidadTotal = cantidad / dolar;
        }

        public void CalcularDivisaDtoP(Double cantidad)
        {
            cantidadTotal = cantidad * dolar;
        }


    }

}
