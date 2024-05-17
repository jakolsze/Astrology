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
                    break;
                case (4, >= 20) or (5, <= 20):
                    pictureGood1.Image = zodiac.virgo;
                    pictureGood2.Image = zodiac.capricorn;
                    pictureGood3.Image = zodiac.cancer;
                    pictureBad1.Image = zodiac.leo;
                    pictureBad2.Image = zodiac.aquarius;
                    break;
                case (5, >= 21) or (6, <= 21):
                    pictureGood1.Image = zodiac.libra;
                    pictureGood2.Image = zodiac.aquarius;
                    pictureGood3.Image = zodiac.sagitarius;
                    pictureBad1.Image = zodiac.virgo;
                    pictureBad2.Image = zodiac.pisces;
                    break;
                case (6, >= 22) or (7, <= 22):
                    pictureGood1.Image = zodiac.taurus;
                    pictureGood2.Image = zodiac.virgo;
                    pictureGood3.Image = zodiac.pisces;
                    pictureBad1.Image = zodiac.aries;
                    pictureBad2.Image = zodiac.libra;
                    break;
                case (7, >= 23) or (8, <= 22):
                    pictureGood1.Image = zodiac.aries;
                    pictureGood2.Image = zodiac.sagitarius;
                    pictureGood3.Image = zodiac.gemini;
                    pictureBad1.Image = zodiac.taurus;
                    pictureBad2.Image = zodiac.scorpio;
                    break;
                case (8, >= 23) or (9, <= 22):
                    pictureGood1.Image = zodiac.taurus;
                    pictureGood2.Image = zodiac.capricorn;
                    pictureGood3.Image = zodiac.cancer;
                    pictureBad1.Image = zodiac.gemini;
                    pictureBad2.Image = zodiac.sagitarius;
                    break;
                case (9, >= 23) or (10, <= 23):
                    pictureGood1.Image = zodiac.gemini;
                    pictureGood2.Image = zodiac.aquarius;
                    pictureGood3.Image = zodiac.leo;
                    pictureBad1.Image = zodiac.cancer;
                    pictureBad2.Image = zodiac.capricorn;
                    break;
                case (10, >= 24) or (11, <= 22):
                    pictureGood1.Image = zodiac.cancer;
                    pictureGood2.Image = zodiac.pisces;
                    pictureGood3.Image = zodiac.virgo;
                    pictureBad1.Image = zodiac.leo;
                    pictureBad2.Image = zodiac.aquarius;
                    break;
                case (11, >= 23) or (12, <= 21):
                    pictureGood1.Image = zodiac.aries;
                    pictureGood2.Image = zodiac.leo;
                    pictureGood3.Image = zodiac.libra;
                    pictureBad1.Image = zodiac.virgo;
                    pictureBad2.Image = zodiac.pisces;
                    break;
                case (12, >= 22) or (1, <= 19):
                    pictureGood1.Image = zodiac.virgo;
                    pictureGood2.Image = zodiac.taurus;
                    pictureGood3.Image = zodiac.scorpio;
                    pictureBad1.Image = zodiac.aries;
                    pictureBad2.Image = zodiac.leo;
                    break;
                case (1, >= 20) or (2, <= 18):
                    pictureGood1.Image = zodiac.gemini;
                    pictureGood2.Image = zodiac.libra;
                    pictureGood3.Image = zodiac.sagitarius;
                    pictureBad1.Image = zodiac.taurus;
                    pictureBad2.Image = zodiac.scorpio;
                    break;
                case (2, >= 19) or (3, <= 20):
                    pictureGood1.Image = zodiac.scorpio;
                    pictureGood2.Image = zodiac.cancer;
                    pictureGood3.Image = zodiac.virgo;
                    pictureBad1.Image = zodiac.gemini;
                    pictureBad2.Image = zodiac.sagitarius;
                    break;
                default:
                    pictureGood1.Image = Properties.Resources.astrology_logo_small;
                    pictureGood2.Image = Properties.Resources.astrology_logo_small;
                    pictureGood3.Image = Properties.Resources.astrology_logo_small;
                    pictureBad1.Image =  Properties.Resources.astrology_logo_small;
                    pictureBad2.Image = Properties.Resources.astrology_logo_small;
                    break;
            }
        }
    }
}
