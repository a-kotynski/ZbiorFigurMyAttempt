namespace ZbiorFigurMyAttempt
{
    public class Trojkat2 : Wielobok
    {
        public Trojkat2(Punkt x1, Punkt x2, Punkt x3)
        {
            Wierzcholki.Add(x1);
            Wierzcholki.Add(x2);
            Wierzcholki.Add(x3);
        }
        public override string ToString()
        {
            return $"Wierzchołki: {string.Join('\n', Wierzcholki)}";
        }
        public override double Obwod()
        {

        }
    }
}