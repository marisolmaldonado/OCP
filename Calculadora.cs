using System;
using System.Collections.Generic;

namespace OCPCONSOLE.Refactorizacion
{

    class Calculadora
    {
        public double CalcularArea(IArea figura)
        {

            return figura.Area();


        }

        public double CalcularArea(List<IArea> figuras)
        {
            double area = 0;


            for (int i = 0; i < figuras.Count; i++)
            {
                area += figuras[1].Area();
            }
            return area;
        }
    }
}



