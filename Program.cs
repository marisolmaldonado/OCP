using System;

namespace OCPCONSOLE
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de areas ");

           Calculadora calculadora = new Calculadora();

            Refactorizacion.Triangulo triangulo = new Refactorizacion.Triangulo
            {
                Base = 10,
                Altura = 5
            };
            Console.WriteLine("El area del triangulo es{0}", calculadora.CalcularArea(triangulo));

            Refactorizacion.Cuadrado cuadrado = new Refactorizacion.Cuadrado

            {
                Lado = 6,
            };
            Console.WriteLine("El area del cuadrado es{0}", calculadora.CalcularArea(cuadrado));

            Refactorizacion.Circulo circulo = new Refactorizacion.Circulo
            {
                Radio = 5.0


            };
            Console.WriteLine("El area del circulo es{0}", calculadora.CalcularArea(circulo));

            Refactorizacion.Rectangulo rectangulo = new Refactorizacion.Rectangulo
            {
                BaseR = 10,
                AlturaR = 6
            };

            Console.WriteLine("El area del rectangulo es{0}", calculadora.CalcularArea(rectangulo));

            Refactorizacion.Trapecio trapecio = new Refactorizacion.Trapecio
            {
                Altura = 4,
                Base1 = 6,
                Base2 = 3
            };

            Console.WriteLine("El area del trapecio es{0}", calculadora.CalcularArea(trapecio));

            Refactorizacion.Cono cono = new Refactorizacion.Cono
            {
                Base = 4.0,
                Altura = 6.0,
                Radio = 5.0
            };

            Console.WriteLine("El area de un cono es :{0}", calculadora.CalcularArea(cono));
            Refactorizacion.Cilindro cilindro = new Refactorizacion.Cilindro
            {
                Altura = 8.0,
                Radio = 5.0
            };
            Console.WriteLine("El Area del cilindro es :{0}", calculadora.CalcularArea(cilindro));
        }
    }
}
