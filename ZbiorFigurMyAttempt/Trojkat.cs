namespace ZbiorFigurMyAttempt
{
    public class Trojkat : Figura
    {
        private readonly Punkt Punkt1;
        private readonly Punkt Punkt2;
        private readonly Punkt Punkt3;
        public Trojkat() { }
        public Trojkat(Punkt P1, Punkt P2, Punkt P3)
        {
            Punkt1 = P1;
            Punkt2 = P2;
            Punkt3 = P3;
        }
        public override double Obwod()
        {
            
        }
        public override string ToString()
        {
            return $"x1:{Punkt1}, x2: {Punkt2}, x3: {Punkt3}";
        }
        public override object Clone()
        {
            object obj = new Trojkat();
        }
        public override void Przesun(double x, double y)
        {

        }
    }
}