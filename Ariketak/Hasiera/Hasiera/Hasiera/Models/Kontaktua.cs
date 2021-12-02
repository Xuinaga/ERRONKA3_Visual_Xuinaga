using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hasiera.Models
{
    public class Kontaktua
    {
        public Kontaktua(string nan, string izena, string abizena)
        {
            Nan = nan;
            Izena = izena;
            Abizena = abizena;
        }
        public string Nan { get; set; }
        public string Izena { get; set; }
        public string Abizena { get; set; }
        public virtual string Emaila { get; set; }
        public string IzenOsoa
        { get { return Izena + " " + Abizena; } }

        public virtual string Gorde()
        {
            return "Kontaktua ondo gorde da";
        }

    }
}
