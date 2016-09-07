using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;
            double perimetro;

            //Circulo
            Console.WriteLine("Ingrese el radio del círculo: ");
            int radio = Convert.ToInt32(Console.ReadLine());
   
            Circulo circ = new Circulo();
            circ.radio = radio;
            area = circ.CalcularArea();
            perimetro = circ.CalcularPerimetro();

            Console.WriteLine("El resultado del area del círculo es " + area + " al cuadrado");
            Console.WriteLine("Y el perímetro es: " + perimetro + "\n");

            //Triángulo
            Console.WriteLine("Ingrese el lado 'a' del triángulo: ");
            int ladoa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el lado 'b' del triángulo: ");
            int ladob = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el lado 'c' del triángulo: ");
            int ladoc = Convert.ToInt32(Console.ReadLine());

            Triangulo triang = new Triangulo();
            triang.ladoa = ladoa;
            triang.ladob = ladob;
            triang.ladoc = ladoc;
            area = triang.CalcularArea();
            perimetro = triang.CalcularPerimetro();

            Console.WriteLine("El resultado del area del triángulo es " + area + " al cuadrado");
            Console.WriteLine("Y el perímetro es: " + perimetro + "\n");

            //Cuadrado
            Console.WriteLine("Ingrese un lado del cuadrado: ");
            int lado = Convert.ToInt32(Console.ReadLine());

            Cuadrado cuad = new Cuadrado();
            cuad.lado = lado;
            area = cuad.CalcularArea();
            perimetro = cuad.CalcularPerimetro();

            Console.WriteLine("El resultado del area del cuadrado es " + area + " al cuadrado");
            Console.WriteLine("Y el perímetro es: " + perimetro);


            Console.ReadKey();

        }
    }
}
