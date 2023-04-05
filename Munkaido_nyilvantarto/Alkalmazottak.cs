using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Munkaido_nyilvantarto
{
    internal class Alkalmazott
    {

        string nev;
        int id;
        string nem;
        string cim;
        string pozicio;
        DateTime szuletesidatum;
        string telefonszam;
        int napifizetese;
        public string Nev { get => nev; set => nev = value; }
        public int Id { get => id; set => id = value; }
        public string Nem { get => nem; set => nem = value; }
        public string Cim { get => cim; set => cim = value; }
        public string Pozicio { get => pozicio; set => pozicio = value; }
        public DateTime Szuletesidatum { get => szuletesidatum; set => szuletesidatum = value; }
        public string Telefonszam { get => telefonszam; set => telefonszam = value; }
        public int Napifizetese { get => napifizetese; set => napifizetese = value; }

          

        public Alkalmazott(string nev,int id,string nem,string cim, string pozicio, DateTime szuletesidatum,string telefonszam,int napifizetese)
        {
           this.Nev = nev;
            this.Id = id;
            this.Nem = nem;
            this.Cim = cim;    
            this.Pozicio = pozicio;
            this.Szuletesidatum = szuletesidatum;
            this.Telefonszam = telefonszam;
            this.Napifizetese = napifizetese;
        }

        public override string ToString()
        {
            return nev;
        }
    }
}
