using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly2.Models
{
    public class Tecaj
    {
        public int Id { get; set; }
        public string Valuta { get; set; }
        public string Srednji_tecaj { get; set; }
        public string Drzava { get; set; }
        public string Sifra_Valute { get; set; }
        public string Kupovni_tecaj { get; set; }
        public string Prodajni_tecaj { get; set; }
        public DateTime Datum_primjene { get; set; }
    }
}