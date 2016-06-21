using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PICvjecara
{
   public static class ListClass
    {
        public static BindingList<DBClass.Dobavljaci> listaDobavljaca = new BindingList<DBClass.Dobavljaci>();
        public static BindingList<DBClass.Artikli> listaArtikla = new BindingList<DBClass.Artikli>();
        public static BindingList<DBClass.Kupci> listaKlijenta = new BindingList<DBClass.Kupci>();
        public static int iDDovacljaca;
        public static int iDKlijenta;
        public static int iDNarudzbenica;
    }
}
