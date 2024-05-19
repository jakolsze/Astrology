using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astrology_Desktop.Forms
{
    public partial class FormL : Form
    {
        private DateTime dataZodiak = welcome.instance.wybranaData;
        public FormL()
        {
            InitializeComponent();
            switch (dataZodiak.Month, dataZodiak.Day)
            {
                case (3, >= 21) or (4, <= 19):
                    pictureGood1.Image = zodiac.leo;
                    pictureGood2.Image = zodiac.sagitarius;
                    pictureGood3.Image = zodiac.libra;
                    pictureBad1.Image = zodiac.cancer;
                    pictureBad2.Image = zodiac.capricorn;
                    labelGood2.Text = "Lew";
                    labelGood3.Text = "Strzelec";
                    labelGood1.Text = "Waga";
                    labelBad1.Text = "Rak";
                    labelBad2.Text = "Koziorożec";
                    break;
                case (4, >= 20) or (5, <= 20):
                    pictureGood1.Image = zodiac.virgo;
                    pictureGood2.Image = zodiac.capricorn;
                    pictureGood3.Image = zodiac.cancer;
                    pictureBad1.Image = zodiac.leo;
                    pictureBad2.Image = zodiac.aquarius;
                    labelGood2.Text = "Panna";
                    labelGood3.Text = "Koziorożec";
                    labelGood1.Text = "Rak";
                    labelBad1.Text = "Lew";
                    labelBad2.Text = "Wodnik";
                    break;
                case (5, >= 21) or (6, <= 21):
                    pictureGood1.Image = zodiac.libra;
                    pictureGood2.Image = zodiac.aquarius;
                    pictureGood3.Image = zodiac.sagitarius;
                    pictureBad1.Image = zodiac.virgo;
                    pictureBad2.Image = zodiac.pisces;
                    labelGood2.Text = "Waga";
                    labelGood3.Text = "Wodnik";
                    labelGood1.Text = "Strzelec";
                    labelBad1.Text = "Panna";
                    labelBad2.Text = "Ryby";
                    break;
                case (6, >= 22) or (7, <= 22):
                    pictureGood1.Image = zodiac.taurus;
                    pictureGood2.Image = zodiac.virgo;
                    pictureGood3.Image = zodiac.pisces;
                    pictureBad1.Image = zodiac.aries;
                    pictureBad2.Image = zodiac.libra;
                    labelGood2.Text = "Byk";
                    labelGood3.Text = "Panna";
                    labelGood1.Text = "Ryby";
                    labelBad1.Text = "Baran";
                    labelBad2.Text = "Waga";
                    break;
                case (7, >= 23) or (8, <= 22):
                    pictureGood1.Image = zodiac.aries;
                    pictureGood2.Image = zodiac.sagitarius;
                    pictureGood3.Image = zodiac.gemini;
                    pictureBad1.Image = zodiac.taurus;
                    pictureBad2.Image = zodiac.scorpio;
                    labelGood2.Text = "Baran";
                    labelGood3.Text = "Strzelec";
                    labelGood1.Text = "Bliźnięta";
                    labelBad1.Text = "Byk";
                    labelBad2.Text = "Skorpion";
                    break;
                case (8, >= 23) or (9, <= 22):
                    pictureGood1.Image = zodiac.taurus;
                    pictureGood2.Image = zodiac.capricorn;
                    pictureGood3.Image = zodiac.cancer;
                    pictureBad1.Image = zodiac.gemini;
                    pictureBad2.Image = zodiac.sagitarius;
                    labelGood2.Text = "Byk";
                    labelGood3.Text = "Koziorożec";
                    labelGood1.Text = "Rak";
                    labelBad1.Text = "Bliźnięta";
                    labelBad2.Text = "Strzelec";
                    break;
                case (9, >= 23) or (10, <= 23):
                    pictureGood1.Image = zodiac.gemini;
                    pictureGood2.Image = zodiac.aquarius;
                    pictureGood3.Image = zodiac.leo;
                    pictureBad1.Image = zodiac.cancer;
                    pictureBad2.Image = zodiac.capricorn;
                    labelGood2.Text = "Bliźnięta";
                    labelGood3.Text = "Wodnik";
                    labelGood1.Text = "Lew";
                    labelBad1.Text = "Rak";
                    labelBad2.Text = "Koziorożec";
                    break;
                case (10, >= 24) or (11, <= 22):
                    pictureGood1.Image = zodiac.cancer;
                    pictureGood2.Image = zodiac.pisces;
                    pictureGood3.Image = zodiac.virgo;
                    pictureBad1.Image = zodiac.leo;
                    pictureBad2.Image = zodiac.aquarius;
                    labelGood2.Text = "Rak";
                    labelGood3.Text = "Ryby";
                    labelGood1.Text = "Panna";
                    labelBad1.Text = "Lew";
                    labelBad2.Text = "Wodnik";
                    break;
                case (11, >= 23) or (12, <= 21):
                    pictureGood1.Image = zodiac.aries;
                    pictureGood2.Image = zodiac.leo;
                    pictureGood3.Image = zodiac.libra;
                    pictureBad1.Image = zodiac.virgo;
                    pictureBad2.Image = zodiac.pisces;
                    labelGood2.Text = "Baran";
                    labelGood3.Text = "Lew";
                    labelGood1.Text = "Waga";
                    labelBad1.Text = "Panna";
                    labelBad2.Text = "Ryby";
                    break;
                case (12, >= 22) or (1, <= 19):
                    pictureGood1.Image = zodiac.virgo;
                    pictureGood2.Image = zodiac.taurus;
                    pictureGood3.Image = zodiac.scorpio;
                    pictureBad1.Image = zodiac.aries;
                    pictureBad2.Image = zodiac.leo;
                    labelGood2.Text = "Panna";
                    labelGood3.Text = "Byk";
                    labelGood1.Text = "Skorpion";
                    labelBad1.Text = "Baran";
                    labelBad2.Text = "Lew";
                    break;
                case (1, >= 20) or (2, <= 18):
                    pictureGood1.Image = zodiac.gemini;
                    pictureGood2.Image = zodiac.libra;
                    pictureGood3.Image = zodiac.sagitarius;
                    pictureBad1.Image = zodiac.taurus;
                    pictureBad2.Image = zodiac.scorpio;
                    labelGood2.Text = "Bliźnięta";
                    labelGood3.Text = "Waga";
                    labelGood1.Text = "Strzelec";
                    labelBad1.Text = "Byk";
                    labelBad2.Text = "Skorpion";
                    break;
                case (2, >= 19) or (3, <= 20):
                    pictureGood1.Image = zodiac.scorpio;
                    pictureGood2.Image = zodiac.cancer;
                    pictureGood3.Image = zodiac.virgo;
                    pictureBad1.Image = zodiac.gemini;
                    pictureBad2.Image = zodiac.sagitarius;
                    labelGood2.Text = "Skorpion";
                    labelGood3.Text = "Rak";
                    labelGood1.Text = "Panna";
                    labelBad1.Text = "Bliźnięta";
                    labelBad2.Text = "Strzelec";
                    break;
                default:
                    pictureGood1.Image = Properties.Resources.astrology_logo_small;
                    pictureGood2.Image = Properties.Resources.astrology_logo_small;
                    pictureGood3.Image = Properties.Resources.astrology_logo_small;
                    pictureBad1.Image = Properties.Resources.astrology_logo_small;
                    pictureBad2.Image = Properties.Resources.astrology_logo_small;
                    labelGood2.Text = "Coś poszło nietak!";
                    labelGood3.Text = "Coś poszło nietak!";
                    labelGood1.Text = "Coś poszło nietak!";
                    labelBad1.Text = "Coś poszło nietak!";
                    labelBad2.Text = "Coś poszło nietak!";
                    break;
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            labelKorzystnosc.Text = "Korzystne";
            labelKorzystnosc.ForeColor = Color.Green;
            labelKorzystnosc.Visible = true;
            pictureKorzystnosc.Image = Properties.Resources.heart;
            pictureGood1.Visible = true;
            pictureGood2.Visible = true;
            pictureGood3.Visible = true;
            pictureBad1.Visible = false;
            pictureBad2.Visible = false;
            labelGood1.Visible= true;
            labelGood2.Visible= true;
            labelGood3.Visible= true;
            labelBad1.Visible = false;
            labelBad2.Visible = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            labelKorzystnosc.Text = "Niekorzystne";
            labelKorzystnosc.ForeColor = Color.Red;
            labelKorzystnosc.Visible = true;
            pictureKorzystnosc.Image = Properties.Resources.broken_heart;
            pictureGood1.Visible = false;
            pictureGood2.Visible = false;
            pictureGood3.Visible = false;
            pictureBad1.Visible = true;
            pictureBad2.Visible = true;
            labelGood2.Visible = false;
            labelGood3.Visible = false;
            labelGood1.Visible = false;
            labelBad1.Visible = true;
            labelBad2.Visible = true;
        }
    }
}
