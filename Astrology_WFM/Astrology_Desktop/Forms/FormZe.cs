using Astrology_Desktop.Properties;
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
    public partial class FormZe : Form
    {
        private DateTime dataZodiak = welcome.instance.wybranaData;
        public FormZe()
        {
            InitializeComponent();
            switch (dataZodiak.Month, dataZodiak.Day)
            {
                case (3, >= 21) or (4, <= 19):
                    zodiacPicture.Image = zodiac.aries;
                    break;
                case (4, >= 20) or (5, <= 20):
                    zodiacPicture.Image = zodiac.taurus;
                    break;
                case (5, >= 21) or (6, <= 21):
                    zodiacPicture.Image = zodiac.gemini;
                    break;
                case (6, >= 22) or (7, <= 22):
                    zodiacPicture.Image = zodiac.cancer;
                    break;
                case (7, >= 23) or (8, <= 22):
                    zodiacPicture.Image = zodiac.leo;
                    break;
                case (8, >= 23) or (9, <= 22):
                    zodiacPicture.Image = zodiac.virgo;
                    break;
                case (9, >= 23) or (10, <= 23):
                    zodiacPicture.Image = zodiac.libra;
                    break;
                case (10, >= 24) or (11, <= 22):
                    zodiacPicture.Image = zodiac.scorpio;
                    break;
                case (11, >= 23) or (12, <= 21):
                    zodiacPicture.Image = zodiac.sagitarius;
                    break;
                case (12, >= 22) or (1, <= 19):
                    zodiacPicture.Image = zodiac.capricorn;
                    break;
                case (1, >= 20) or (2, <= 18):
                    zodiacPicture.Image = zodiac.aquarius;
                    break;
                case (2, >= 19) or (3, <= 20):
                    zodiacPicture.Image = zodiac.pisces;
                    break;
                default:
                    zodiacPicture.Image = Properties.Resources.astrology_logo_small;
                    break;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
