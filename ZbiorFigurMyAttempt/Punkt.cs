namespace ZbiorFigurMyAttempt
{
    public class Punkt : Figura
    {
        private double x;
        private double y;
        public double X // robi to samo co prop?
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public Punkt()
        {

        }
        public Punkt(double x1, double y1)
        {
            x = x1;
            y = y1;
        }
        public override double Obwod()
        {
            return 0;
        }
        public override string ToString()
        {
            return $"x:{x}, y: {y}";
        }
        public double Odleglosc(Punkt punkt)
        {
            return 0;
        }
        public double Odleglosc(Punkt punkt1, Punkt punkt2)
        {
            return Math.Sqrt(Math.Pow(punkt2.x - punkt1.x, 2) + Math.Pow(punkt2.y - punkt1.y, 2));
        }
        public override object Clone()
        {
            return new Punkt();
        }
        public override void Przesun(double xShift, double yShift)
        {
            x += xShift;
            y += yShift;
        }
    }
}