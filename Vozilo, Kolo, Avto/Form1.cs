using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vozilo__Kolo__Avto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Vozilo
        {
            public int st_koles;
            public int StKoles
            {
                get
                {
                    return st_koles;
                }
                set
                {
                    if (value > 0) st_koles = value;
                }
            }
            public string ime_lastnika { get; set; }
            public string priimek_lastnika { get; set; }
            public string vrniIme()
            {
                return ime_lastnika + " " + priimek_lastnika;
            }
            public void zamenjajLastnika(string ime, string prii)
            {
                ime_lastnika = ime;
                priimek_lastnika = prii;
            }
            public Vozilo()
            {
                st_koles = 0;
                ime_lastnika = "Janez";
                priimek_lastnika = "Novak";
            }
            public Vozilo(int st)
            {
                st_koles = st;
                ime_lastnika = "Janez";
                priimek_lastnika = "Novak";
            }
            public Vozilo(int st, string ime, string prii)
            {
                st_koles = st;
                ime_lastnika = ime;
                priimek_lastnika = prii;
            }
        }

        class Kolo : Vozilo
        {
            public bool imaBlatnike;
            public int st_prestav;
            public int prestave;
            public int Prestava
            {
                get
                {
                    return prestave;
                }
                set
                {
                    if (value < st_prestav && value > 0) prestave = value;
                }
            }
            public char zensko_mosko;
            public char ZenskoMosko
            {
                get
                {
                    return zensko_mosko;
                }
                set
                {
                    if (value == 'z' || value == 'm') zensko_mosko = value;
                }
            }

            public string pozvoni()
            {
                return "Cin cin!!";
            }
            public void vVisjoPrestavo()
            {
                prestave++;
            }
            public void vNizjoPrestavo()
            {
                prestave--;
            }
            public void izpisiLastnosti()
            {
                MessageBox.Show("Ima blatnike? " + imaBlatnike + " Število prestav " + st_prestav + " Trenutna prestava " + prestave + " Žensko ali moško " + zensko_mosko);
            }
            public Kolo()
            {
                st_koles = 2;
                ime_lastnika = "Janez";
                priimek_lastnika = "Novak";
            }
            public Kolo(string ime, string prii)
            {
                st_koles = 2;
                ime_lastnika = ime;
                priimek_lastnika = prii;
            }
        }

        class Avto : Vozilo
        {
            public int stVrat;
            public int prostornina;
            public int st_prestav;
            public int prestave;
            public char tip_motorja;
            public char TipMotorja
            {
                get
                {
                    return tip_motorja;
                }
                set
                {
                    if (value == 'b' || value == 'd') tip_motorja = value;
                }
            }
            public int Prestava
            {
                get
                {
                    return prestave;
                }
                set
                {
                    if (value < st_prestav && value > 0) prestave = value;
                }
            }
            
            public void vVisjoPrestavo()
            {
                prestave++;
            }
            public void vNizjoPrestavo()
            {
                prestave--;
            }
            public void hupaj()
            {
                MessageBox.Show("Bip Bop!!");
            }
            public void izpisiLastnosti()
            {
                MessageBox.Show("St Vrat " + stVrat + " Število prestav " + st_prestav + " Trenutna prestava " + prestave + " Tip motorja " + tip_motorja + " Prostornina " + prostornina);
            }
            public void zamenjajMotor(int pro, char m)
            {
                prostornina = pro;
                tip_motorja = m;
            }
            public Avto()
            {
                st_koles = 4;
                ime_lastnika = "Janez";
                priimek_lastnika = "Novak";
            }

            public Avto(string ime, string prii)
            {
                st_koles = 4;
                ime_lastnika = ime;
                priimek_lastnika = prii;
            }
        }

        class TerenskiAvto : Avto
        {
            bool pogon4x4;
        }
        class SpotrniAvto : Avto
        {
            double pospesekDo100;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vozilo v4 = new Vozilo();
            v4.StKoles = -3;

            Vozilo v1 = new Vozilo(); //stKoles nastavi na 0, ime na "Janez", priimek na "Novak"
            Vozilo v2 = new Vozilo(4); //stKoles nastavi na podano vrednost
            Vozilo v3 = new Vozilo(2, "Peter", "Klepec"); //stKoles, ime in priimek nastavi na podane vrednosti

            MessageBox.Show("1. St koles: " + v4.StKoles);
            MessageBox.Show("\n Vozilo() " + v1.StKoles + v1.ime_lastnika + v1.priimek_lastnika);
            MessageBox.Show("\n Vozilo(3) " + v2.StKoles + v2.ime_lastnika + v2.priimek_lastnika);
            MessageBox.Show("\n Vozilo(2, \"Peter\", \"Klepec\") " + v3.StKoles + v3.ime_lastnika + v3.priimek_lastnika);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kolo k1 = new Kolo(); //stKoles nastavi na 2, ime na "Janez", priimek na "Novak"
            Kolo k2 = new Kolo("Peter", "Klepec"); //stKoles na 2, ime in priimek nastavi na podane vrednosti

            MessageBox.Show("Kolo()" + k1.ime_lastnika + k1.priimek_lastnika);
            MessageBox.Show("Kolo(\"Peter\", \"Klepec\")" + k2.ime_lastnika + k2.priimek_lastnika);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Avto a1 = new Avto(); //stKoles nastavi na 4, ime na "Janez", priimek na "Novak"
            Avto a2 = new Avto("Peter", "Klepec"); //stKoles na 4, ime in priimek nastavi na podane vrednosti

            MessageBox.Show("Avto() " + a1.StKoles + a1.ime_lastnika + a1.priimek_lastnika);
            MessageBox.Show("Avto(\"Peter\", \"Klepec\") " + a2.StKoles + a2.ime_lastnika + a2.priimek_lastnika);
        }
    }
}
