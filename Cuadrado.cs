using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Cuadrado : FormaGeometrica
    {


        public double lado;

        public double CalcularArea()
        {
            double resultado = lado * lado;
            return resultado;
        }

        public double CalcularPerimetro()
        {

            double resultado = 4 * lado;
            return resultado;
        }

    }
}
