namespace OCPCONSOLE.Refactorizacion
{
    internal class Trapecio : IArea
    {
        public int Altura { get; internal set; }
        public int Base1 { get; internal set; }
        public int Base2 { get; internal set; }

        public double Area()
        {
            return (Base1 + Base2) * Altura / 2;
        }
    }
}