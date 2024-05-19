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
                    labelOpis.Text = "Szczury są znane ze swojej inteligencji i sprytu. Często odnoszą sukces dzięki swojej zdolności do szybkiego adaptowania się do nowych sytuacji.";
                    break;
                case ("Woł"):
                    chinesePicture.Image = zodiac.ox;
                    labelZch.Text = znakiZodiaku[terrestrialBranch - 1] + " (牛)";
                    labelOpis.Text = "Woły są pracowite i niezawodne, a ich determinacja często prowadzi ich do osiągnięcia celów. Cenią sobie stabilność w życiu.";
                    break;
                case ("Tygrys"):
                    chinesePicture.Image = zodiac.tiger;
                    labelZch.Text = znakiZodiaku[terrestrialBranch - 1] + " (虎)";
                    labelOpis.Text = "Tygrysy są odważne i pełne pasji. Ich charyzmatyczna natura przyciąga innych, ale potrafią też być impulsywne.";
                    break;
                case ("Królik"):
                    chinesePicture.Image = zodiac.rabbit;
                    labelZch.Text = znakiZodiaku[terrestrialBranch - 1] + " (兔)";
                    labelOpis.Text = "Króliki są spokojne i uprzejme, z łatwością nawiązują przyjaźnie. Ich dyplomatyczne podejście pomaga im unikać konfliktów.";
                    break;
                case ("Smok"):
                    chinesePicture.Image = zodiac.dragon;
                    labelZch.Text = znakiZodiaku[terrestrialBranch - 1] + " (龍)";
                    labelOpis.Text = "Smoki są energiczne i pewne siebie, często zajmują pozycje przywódcze. Ich ambicja i odwaga są inspirujące dla innych.";
                    break;
                case ("Wąż"):
                    chinesePicture.Image = zodiac.snake;
                    labelZch.Text = znakiZodiaku[terrestrialBranch - 1] + " (蛇)";
                    labelOpis.Text = "Węże są mądre i tajemnicze, często działają intuicyjnie. Mają głębokie myśli i skłonności filozoficzne.";
                    break;
                case ("Koń"):
                    chinesePicture.Image = zodiac.horse;
                    labelZch.Text = znakiZodiaku[terrestrialBranch - 1] + " (馬)";
                    labelOpis.Text = "Konie są niezależne i energiczne. Lubią być w ruchu i często są duszą towarzystwa.";
                    break;
                case ("Owca"):
                    chinesePicture.Image = zodiac.sheep;
                    labelZch.Text = znakiZodiaku[terrestrialBranch - 1] + " (羊)";
                    labelOpis.Text = "Owce są kreatywne i delikatne. Ich empatia i dobroć sprawiają, że są lubiane przez otoczenie.";
                    break;
                case ("Małpa"):
                    chinesePicture.Image = zodiac.monkey;
                    labelZch.Text = znakiZodiaku[terrestrialBranch - 1] + " (猴)";
                    labelOpis.Text = "Małpy są pomysłowe i pełne energii. Ich ciekawość i zręczność pomagają im w rozwiązywaniu problemów.";
                    break;
                case ("Kogut"):
                    chinesePicture.Image = zodiac.rooster;
                    labelZch.Text = znakiZodiaku[terrestrialBranch - 1] + " (鸡)";
                    labelOpis.Text = "Koguty są praktyczne i punktualne. Ich zorganizowane podejście do życia często prowadzi do sukcesu.";
                    break;
                case ("Pies"):
                    chinesePicture.Image = zodiac.dog;
                    labelZch.Text = znakiZodiaku[terrestrialBranch - 1] + " (狗)";
                    labelOpis.Text = "Psy są lojalne i uczciwe. Ich wierność i uczciwość sprawiają, że są cenionymi przyjaciółmi.";
                    break;
                case ("Świnia"):
                    chinesePicture.Image = zodiac.pig;
                    labelZch.Text = znakiZodiaku[terrestrialBranch - 1] +" (猪)";
                    labelOpis.Text = "Świnie są szczere i hojne. Ich dobroduszność i chęć pomocy innym czynią je sympatycznymi towarzyszami.";
                    break;
                default:
                    chinesePicture.Image = Properties.Resources.astrology_logo_small;
                    labelOpis.Text = "Cos poszlo nietak";
                    break;
            }
        }  


    }
}
