using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;

namespace Astrology_Desktop.Forms
{
    public partial class FormZn : Form
    {
        public FormZn()
        {
            InitializeComponent();
            int var = ObliczLiczbeNumerologiczna(welcome.instance.wybranaData);
            label1.Text = "Twoja liczba numerologiczna to: " + var;
            int let = Convert.ToInt32(var);
            switch (var)
            {
                case 1:
                    pictureBox1.Image = zodiac._1;
                    labelOpis.Text = "Symbolizuje przywództwo i niezależność. Osoby o tej liczbie często wykazują silną wolę i determinację.";
                    break;
                 case 2:
                    pictureBox1.Image = zodiac._2;
                    labelOpis.Text = "Reprezentuje harmonię i partnerstwo. Charakteryzuje się empatią i zdolnością do współpracy.";
                    break;
                case 3:
                    pictureBox1.Image = zodiac._3;
                    labelOpis.Text = "Oznacza kreatywność i komunikatywność. Jest to liczba optymistów, którzy łatwo nawiązują kontakty.";
                    break;
                case 4:
                    pictureBox1.Image = zodiac._4;
                    labelOpis.Text = "Stoi za stabilnością i solidnością. Osoby z tą liczbą są praktyczne i dobrze zorganizowane.";
                    break;
                case 5:
                    pictureBox1.Image = zodiac._5;
                    labelOpis.Text = "Symbolizuje wolność i zmianę. Ludzie o tej wibracji są ciekawi świata i nie boją się ryzyka.";
                    break;
                case 6:
                    pictureBox1.Image = zodiac._6;
                    labelOpis.Text = "Reprezentuje odpowiedzialność i opiekę. Charakteryzuje się silnym poczuciem obowiązku i troską o innych.";
                    break;
                case 7:
                    pictureBox1.Image = zodiac._7;
                    labelOpis.Text = "Oznacza głębokie myślenie i duchowość. Osoby o tej liczbie często poszukują wiedzy i prawdy.";
                    break;
                case 8:
                    pictureBox1.Image = zodiac._8;
                    labelOpis.Text = "Symbolizuje sukces i władzę materialną. Jest to liczba ambitnych i zorientowanych na cel osób.";
                    break;
                case 9:
                    pictureBox1.Image = zodiac._9;
                    labelOpis.Text = "Reprezentuje humanitaryzm i altruizm. Ludzie z tą liczbą mają silne poczucie sprawiedliwości i chęć pomocy innym.";
                    break;
                default:
                    labelOpis.Text = "Cos poszlo nietak ";
                    pictureBox1.Image = Properties.Resources.astrology_logo_small;
                    break;
            }
        }
        public int ObliczLiczbeNumerologiczna(DateTime data)
        {
            int suma = data.Day + data.Month + data.Year;
            while (suma > 9)
            {
                suma = suma.ToString().Sum(c => c - '0');
            }
            return suma;
        }

    }
}
