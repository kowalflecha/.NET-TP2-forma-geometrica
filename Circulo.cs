using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Circulo : FormaGeometrica

    {
        public double radio;
        double pi = Math.PI;

        public double CalcularArea()
        {
            double resultado = radio * radio;
            resultado = (pi * resultado);
            return resultado;
        }

        public double CalcularPerimetro()
        {
            
            double resultado = (2 * pi) * radio;
            return resultado;
        }

    }
}
