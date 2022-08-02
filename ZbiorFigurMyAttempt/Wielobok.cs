namespace ZbiorFigurMyAttempt
{
    public class Wielobok : Figura
    {
        protected List<Punkt> Wierzcholki { get; set; } = new List<Punkt>();
        public Wielobok(Punkt punkty) // in UML: (Punkt[] punkty)
        {
            Wierzcholki.Add(punkty);
        }
        public Wielobok() { }
        public void DodajPunkt(Punkt punkt)
        {

        }
        public override string ToString()
        {
            return $"Wierzchołki: {string.Join('\n', Wierzcholki)}";
        }
        public override double Obwod()
        {

        }
        public override void Przesun(double x, double y)
        {

        }
        public override object Clone()
        {
           return new Wielobok();
        }
    }
}