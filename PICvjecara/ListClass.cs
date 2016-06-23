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
        public static BindingList<DBClass.Dobavljac> listaDobavljaca = new BindingList<DBClass.Dobavljac>();
        public static BindingList<DBClass.Artikl> listaArtikla = new BindingList<DBClass.Artikl>();
        public static BindingList<DBClass.Kupac> listaKlijenta = new BindingList<DBClass.Kupac>();
        public static int iDDovacljaca;
        public static int iDKlijenta;
        public static int iDNarudzbenica;
    }
}
