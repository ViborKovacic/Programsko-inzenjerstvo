using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;

namespace PICvjecara
{
    public class Korisnici
    {
        static int id_korisnika;
        public  int ID_korisnik {
            get
            {
                return id_korisnika;
            }
            set
            {
                if (id_korisnika != value)
                {
                    id_korisnika = value;
                }
            }
        }

        static string ime;
        public  string Ime {
            get
            {
                return ime;
            }
            set
            {
                if (ime != value)
                {
                    ime = value;
                }
            }
        }

        static string prezime;
        public  string Prezime {
            get
            {
                return prezime;
            }
            set
            {
                if (prezime != value)
                {
                    prezime = value;
                }
            }
        }



        static string username;
        public  string Username {
            get
            {
                return username;
            }
            set
            {
                if (username != value)
                {
                    username = value;
                }
            }
        }

        static string password;
        public  string Password {
            get
            {
                return password;
            }
            set
            {
                if (password != value)
                {
                    password = value;
                }
            }
        }

        static string email;
        public  string Email {
            get
            {
                return email;
            }
            set
            {
                if (email != value)
                {
                    email = value;
                }
            }
        }

        static string grad;
        public  string Grad {
            get
            {
                return grad;
            }
            set
            {
                if (grad != value)
                {
                    grad = value;
                }
            }
        }

        static string adresa;
        public  string Adresa {
            get
            {
                return adresa;
            }
            set
            {
                if (adresa != value)
                {
                    adresa = value;
                }
            }
        }

        static string telefon;
        public  string Telefon {
            get
            {
                return telefon;
            }
            set
            {
                if (telefon != value)
                {
                    telefon = value;
                }
            }
        }

        static int id_tip_korisnika;
        public  int ID_tip_korisnika {
            get
            {
                return id_tip_korisnika;
            }
            set
            {
                if (id_tip_korisnika != value)
                {
                    id_tip_korisnika = value;
                }
            }
        }

        public Korisnici(){}

        //public Korisnici(DbDataReader dr)
        //{
        //    if (dr != null)
        //    {
        //        ID_korisnik = int.Parse(dr["ID_korisnik"].ToString());
        //        Ime = dr["ime"].ToString();
        //        Prezime = dr["Prezime"].ToString();
        //        Username = dr["Username"].ToString();
        //        Password = dr["Password"].ToString();
        //        Email = dr["Email"].ToString();
        //        Grad = dr["Grad"].ToString();
        //        Adresa = dr["Adresa"].ToString();
        //        Telefon = dr["Telefon"].ToString();
        //        ID_tip_korisnika = int.Parse(dr["ID_tip_korisnika"].ToString());             
        //    }
        //}

        public int UnosRegistracija()
        {
            string sqlUpit = "";
            sqlUpit = "INSERT INTO Korisnici(ime,Prezime,Username,Password,Email,Grad,Adresa,Telefon,ID_tip_korisnika) VALUES ('" + Ime + "','" + Prezime + "','" + Username + "','" + Password + "','" + Email + "','" + Grad + "','" + Adresa  + "','" + Telefon + "','" + ID_tip_korisnika + "')";
           
            return DatabaseConnection.Instance.IzvirsiUput(sqlUpit);
        }

        public int brojac = 0;
        public string korisnickoIme = "";
        public string korisnickaLozinka = "";
        public int ProvjeraPrijave(string korIme)
        {
            string sqlUpit = "SELECT count(*), Username, Password FROM Korisnici WHERE Username='" + korIme + "' GROUP BY Username, Password";
            brojac = Convert.ToInt32(DatabaseConnection.Instance.DohvatiVrijednosti(sqlUpit));
            DbDataReader read = DatabaseConnection.Instance.DohvatiDataReader(sqlUpit);
            while (read.Read())
            {
                korisnickoIme = read["Username"].ToString();
                korisnickaLozinka = read["Password"].ToString();
            }
            read.Close();
            return DatabaseConnection.Instance.IzvirsiUput(sqlUpit);
        }

        public static string TrenutnoAktivan { get; set; }
        //public void AktivanKorisnik()
        //{
        
        //    string sqlUpit = "select * from Korisnici where Username='" + TrenutnoAkrivan + "'";
        //    DbDataReader read = DatabaseConnection.Instance.DohvatiDataReader(sqlUpit);
        //    while (read.Read())
        //    {
        //        ID_korisnik = Convert.ToInt32(read[0].ToString());
        //        Ime = read["Ime"].ToString();
        //        Prezime = read["Prezime"].ToString();
        //        Email = read["Email"].ToString();
        //        Grad = read["Grad"].ToString();
        //        Adresa = read["Adresa"].ToString();
        //        Telefon = read["Telefon"].ToString();
        //    }
        //    read.Close();
        //}
    }
}
