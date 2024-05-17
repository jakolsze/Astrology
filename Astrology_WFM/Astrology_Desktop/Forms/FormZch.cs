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
        public partial class FormZch : Form
    {
        private DateTime wybranaData = welcome.instance.wybranaData;
        public FormZch()
        {
            InitializeComponent();
            ChineseZodiac();


        }
        public void ChineseZodiac()
        {
            System.Globalization.EastAsianLunisolarCalendar cc = new System.Globalization.ChineseLunisolarCalendar();
            int sexagenaryYear = cc.GetSexagenaryYear(wybranaData);
            int terrestrialBranch = cc.GetTerrestrialBranch(sexagenaryYear);

            string[] znakiZodiaku = new string[] { "Szczur", "Woł", "Tygrys", "Królik", "Smok", "Wąż", "Koń", "Owca", "Małpa", "Kogut", "Pies", "Świnia" };
            string chineseZodiac = znakiZodiaku[terrestrialBranch - 1];
            switch (chineseZodiac)
            {
                case ("Szczur"):
                    chinesePicture.Image = zodiac.rat;
                    labelZch.Text = znakiZodiaku[terrestrialBranch - 1] + " (鼠)";
                    break;
                case ("Woł"):
                    chinesePicture.Image = zodiac.ox;
                    labelZch.Text = znakiZodiaku[terrestrialBranch - 1] + " (牛)";
                    break;
                case ("Tygrys"):
                    chinesePicture.Image = zodiac.tiger;
                    labelZch.Text = znakiZodiaku[terrestrialBranch - 1] + " (虎)";
                    break;
                case ("Królik"):
                    chinesePicture.Image = zodiac.rabbit;
                    labelZch.Text = znakiZodiaku[terrestrialBranch - 1] + " (兔)";
                    break;
                case ("Smok"):
                    chinesePicture.Image = zodiac.dragon;
                    labelZch.Text = znakiZodiaku[terrestrialBranch - 1] + " (龙 / 龍)";
                    break;
                case ("Wąż"):
                    chinesePicture.Image = zodiac.snake;
                    labelZch.Text = znakiZodiaku[terrestrialBranch - 1] + " (蛇)";
                    break;
                case ("Koń"):
                    chinesePicture.Image = zodiac.horse;
                    labelZch.Text = znakiZodiaku[terrestrialBranch - 1] + " (马 / 馬)";
                    break;
                case ("Owca"):
                    chinesePicture.Image = zodiac.sheep;
                    labelZch.Text = znakiZodiaku[terrestrialBranch - 1] + " (羊)";
                    break;
                case ("Małpa"):
                    chinesePicture.Image = zodiac.monkey;
                    labelZch.Text = znakiZodiaku[terrestrialBranch - 1] + " (猴)";
                    break;
                case ("Kogut"):
                    chinesePicture.Image = zodiac.rooster;
                    labelZch.Text = znakiZodiaku[terrestrialBranch - 1] + " (雞 / 鸡)";
                    break;
                case ("Pies"):
                    chinesePicture.Image = zodiac.dog;
                    labelZch.Text = znakiZodiaku[terrestrialBranch - 1] + " (狗)";
                    break;
                case ("Świnia"):
                    chinesePicture.Image = zodiac.pig;
                    labelZch.Text = znakiZodiaku[terrestrialBranch - 1] +" (豬 / 猪)";
                    break;
                default:
                    chinesePicture.Image = Properties.Resources.astrology_logo_small;
                    break;
            }
        }  


    }
}
