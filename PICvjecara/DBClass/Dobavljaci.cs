using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICvjecara.DBClass
{
   public class Dobavljaci
    {
        public int ID_dobavljac { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int OIB { get; set; }
        public string Adresa { get; set; }
    }
}
