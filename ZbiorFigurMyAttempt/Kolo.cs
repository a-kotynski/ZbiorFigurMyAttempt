﻿namespace ZbiorFigurMyAttempt
{
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
}