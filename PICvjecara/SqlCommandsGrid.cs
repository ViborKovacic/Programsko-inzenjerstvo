using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICvjecara
{
    public static class SqlCommandsGrid
    {
        public static int ID_vrsta_artikla;
        public static int ID_narudzbenice;
        

        public static string qNarudzbe = "select n.ID_narudzbenice as 'Broj narudzbenice', n.datum_vrijeme as 'Datum kreiranja narudžbenice',d.Ime as 'Ime dobavljača' from Narudzbenica n, Dobavljaci d where n.ID_dobavljac = d.ID_dobavljac";
        

        
        public static string qDobavljaci = "select d.ID_dobavljac as 'Broj dobavljača', d.Ime as 'Ime Dobavljača',d.OIB as 'OIB',d.Adresa as 'Adresa',d.Telefon from Dobavljaci d";
        public static string qVrstaArtikla = "select vr.ID_vrsta_artikla as 'Broj vrste artikla' , vr.Vrsta as 'Vrsta'  from Vrsta_artikla vr ";
        public static string qKlijenti = "select ID_kupca as 'Broj Klijenta', Ime,Prezime,Email,Telefon,OIB,Adresa from Kupci";
        public static string qVrstaRezervacije = "select ID_tip_rezervacije as 'Broj vreste rezervacije', Vrsta from Tip_rezervacije";
        public static string qPrikazRezervacije = "select r.ID_rezervacije as 'Broj rezervacije',  sr.Datum_izvrsavanja as 'Datum održavanja',k.Ime as 'Klijent' from Kupci k, Rezervacija r , Stavke_rezervacije sr, Nalog_za_prodaju nzp where r.ID_rezervacije = sr.ID_rezervacija and k.ID_kupca = nzp.ID_kupci and nzp.ID_nalog_za_prodaju = sr.ID_nalog_za_prodaju";
        
        



    }



}
