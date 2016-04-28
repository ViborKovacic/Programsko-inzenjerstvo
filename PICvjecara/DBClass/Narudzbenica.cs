using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICvjecara.DBClass
{
   public class Narudzbenica
    {
        public int ID_narudzbenica { get; set; }
        public DateTime Datum_vrijeme { get; set; }
        public int ID_dobavljac { get; set; }
        public int ID_korisnici { get; set; }

    }
}
