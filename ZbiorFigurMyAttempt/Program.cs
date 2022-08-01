using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            
        }
        public double Odleglosc(Punkt punkt1, Punkt punkt2)
        {
            
        }
        public override object Clone()
        {
            object obj = new Punkt();
        }
        public override void Przesun(double x, double y)
        {

        }
    }
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
    public class Kolo : Figura // : IKonsola // interface implementation
    {
        private double Promien;
        private Punkt Srodek;
        public Punkt Srodek1 // robi to samo co prop?
        {
            get { return Srodek; }
            set { Srodek = value; }
        }
        public double Promien1
        {
            get { return Promien; }
            set { Promien = value; }
        }
        public Kolo() { }
        public Kolo(Punkt punkt, double promien)
        {
            Srodek = punkt;
            Promien = promien;
        }
        public override double Obwod()
        {

        }
        public override string ToString()
        {
            return $"Promien: {Promien}, Środek: {Srodek}";
        }
        public override object Clone()
        {
            object obj = new Kolo();
        }
        public override void Przesun(double x, double y)
        {

        }
        public void Wyswietl()
        {

        }
        public void Wczytaj()
        {

        }
    }
    public interface IKonsola
    {
        public virtual void Wyswietl();
        public virtual void Wczytaj();
    }
    public class Wielobok : Figura
    {
        protected List<Punkt> Wierzcholki { get; set; } = new List<Punkt>();
        public Wielobok(Punkt punkty) // in UML: (Punkt[] punkty)
        {
            Wierzcholki.Add(punkty);
        }
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
            object obj = new Wielobok();
        }
    }
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

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}