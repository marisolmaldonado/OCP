using System;

namespace OCPCONSOLE.Refactorizacion
{
    internal class Cuadrado: IArea
    {
       

        public int Lado { get; internal set; }

        public double Area()
        {
            return Math.Pow(this.Lado, 2);
        }
    }
}