namespace ZbiorFigurMyAttempt
{
    public abstract class Figura
    {
        protected string Nazwa { get; set; }
        public Figura(){ }
        public Figura(string nazwa)
        {
            Nazwa = nazwa;
        }
        public abstract double Obwod();
        public string ToString()
        {
            return Nazwa;
        }
        public abstract object Clone();
        public abstract void Przesun(double x, double y);
        public bool Operator(Figura a, Figura b)
        {
            //?
        }
        public bool Operator(Figura a, Figura b)
        {
            //?
        }
    }
}