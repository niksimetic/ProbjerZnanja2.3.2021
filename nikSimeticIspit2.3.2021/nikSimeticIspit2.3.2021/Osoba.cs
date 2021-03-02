using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikSimeticIspit2._3._2021
{
    class Osoba
    {
        string Ime;
        string Prezime;
        string OIB;
        string GodinaRodenja;

        public string Ime1 { get => Ime; set => Ime = value; }
        public string Prezime1 { get => Prezime; set => Prezime = value; }
        public string OIB1 { get => OIB; set => OIB = value; }
        public string GodinaRodenja1 { get => GodinaRodenja; set => GodinaRodenja = value; }

       
        public Osoba(string Ime, string Prezime, string OIB, string GodinaRodenja)
        {
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.OIB = OIB;
            this.GodinaRodenja = GodinaRodenja;

        }
        public override string ToString()
        {
            return Ime + " " + Prezime + " " + OIB + " " + GodinaRodenja;
        }
    }
}
