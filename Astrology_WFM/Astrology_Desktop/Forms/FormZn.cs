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
            string numer = SumDigitsInDateTime();
            label1.Text = "Twoja liczba numerologiczna to: " + numer;
            int let = Convert.ToInt32(numer);
            //int let = int.Parse(label1.Text);
            switch (let)
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
        public string SumDigitsInDateTime()
        {
            // Konwersja DateTime na string
            string dateTimeString = welcome.instance.wybranaData.ToString("yyyyMMdd");

            // Sumowanie wszystkich cyfr w stringu
            int sum = 0;
            foreach (char c in dateTimeString)
            {
                if (char.IsDigit(c))
                {
                    sum += c - '0'; // Konwersja char na int i dodanie do sumy
                }
            }
            int suma = 0;
                while (sum != 0)
                {
                    suma += sum % 10;
                    sum /= 10;
                }
                int sumak = Math.Abs(suma);

            string wynik = sumak.ToString();
            return wynik; // Zwrócenie sumy cyfr
        }

    }
}
