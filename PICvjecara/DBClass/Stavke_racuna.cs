using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICvjecara.DBClass
{
    public class Stavke_racuna
    {
        public int ID_stavke_racuna { get; set; }
        public int Kolicina { get; set; }
        public float iznos { get; set; }
        public int ID_artikli { get; set; }
        public int ID_nalog_za_prodaju { get; set; }
    }
}
