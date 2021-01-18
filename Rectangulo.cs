namespace OCPCONSOLE.Refactorizacion
{
    internal class Rectangulo: IArea
    {
        public int BaseR { get; internal set; }
        public int AlturaR { get; internal set; }

        public double Area()
        {
            return this.BaseR * this.AlturaR;
        }
    }
}

