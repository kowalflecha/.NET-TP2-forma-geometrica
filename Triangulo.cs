using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Triangulo : FormaGeometrica

    {
        public double ladoa;
        public double ladob;
        public double ladoc;
        public double semip;

        public double CalcularArea()
        {
            //Utilizando la "Fórmula de Herón" conociendo sólo los lados

            semip = (ladoa + ladob + ladoc) / 2;
            double resultado = semip * (semip - ladoa) * (semip - ladob) * (semip - ladoc);
            resultado = Math.Sqrt(resultado);
            return resultado;
        }

        public double CalcularPerimetro()
        {

            double resultado = ladoa + ladob + ladoc;
            return resultado;
        }

    }
}
