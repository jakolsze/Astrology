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
                    labelZodiac.Text = "Baran, pierwszy znak zodiaku, emanuje energią pioniera i odwagi, rządzony przez planetę Mars, symbolizuje inicjatywę i pasję.\r\n\n" +
                        "    Osoby urodzone pod tym znakiem są znane z ich spontaniczności, zapału do życia i nieustraszonego podejścia do nowych wyzwań.\r\n\n" +
                        "    Jako znak ognia, Barany są dynamiczne i pełne witalności, często inspirując innych swoją żywą energią i entuzjazmem.\r\n\n" +
                        "    Charakterystyczna dla Baranów jest ich bezpośredniość i impulsywność, co sprawia, że szybko podejmują decyzje i działają z determinacją.\r\n\n " +
                        "   Mimo że ich zapał może być czasami krótkotrwały, Barany nie boją się ryzyka i zawsze są gotowe walczyć o to, w co wierzą.";
                    labelTitle.Text = "Baran (21 marca - 19 kwietnia): Symbolizuje odwagę i inicjatywę.";
                    break;
                case (4, >= 20) or (5, <= 20):
                    zodiacPicture.Image = zodiac.taurus;
                    labelZodiac.Text = "Byk, znak zodiaku rządzony przez planetę Wenus, symbolizuje wytrwałość, stabilność i miłość do piękna.\r\n\n " +
                        "   Osoby spod tego znaku są znane ze swojej praktyczności, cierpliwości i skłonności do komfortowego życia, unikając niepotrzebnych zmian.\r\n\n  " +
                        "  Byki cenią materialne aspekty życia, dążąc do zabezpieczenia finansowego i otaczając się luksusami.\r\n\n " +
                        "   Charakteryzują się upartością i determinacją w dążeniu do celów, co czyni ich niezawodnymi, ale czasem opornymi na kompromisy.\r\n\n " +
                        "  W relacjach międzyludzkich Byki są lojalne i godne zaufania, choć ich konserwatywne podejście może prowadzić do konfliktów z bardziej spontanicznymi osobowościami.\r";
                    labelTitle.Text = "Byk (20 kwietnia - 20 maja): Reprezentuje wytrwałość i stabilność.";
                    break;
                case (5, >= 21) or (6, <= 21):
                    zodiacPicture.Image = zodiac.gemini;
                    labelZodiac.Text = "Bliźnięta, znak zodiaku rządzony przez Merkurego, reprezentują energię intelektualną, komunikatywność i zdolność do adaptacji.\r\n\n" +
                        "    Osoby spod tego znaku są ciekawe świata, mają otwarty umysł i często wykazują talent do języków oraz umiejętność wielozadaniowości.\r\n\n" +
                        "    Bliźnięta uwielbiają różnorodność i zmiany, co sprawia, że są ciągle w ruchu, poszukując nowych doświadczeń i wiedzy.\r\n\n" +
                        "    Ich towarzyski charakter i urok osobisty sprawiają, że łatwo nawiązują kontakty i są lubiane w swoim otoczeniu.\r\n\n" +
                        "    Mimo swojej zmienności i niecierpliwości, Bliźnięta potrafią być pomysłowe i kreatywne, co czyni je atrakcyjnymi w wielu dziedzinach życia.\r\n ";
                    labelTitle.Text = "Bliźnięta (21 maja - 20 czerwca): Symbolizują komunikację i zróżnicowanie.";
                    break;
                case (6, >= 22) or (7, <= 22):
                    zodiacPicture.Image = zodiac.cancer;
                    labelZodiac.Text = "Rak to znak zodiaku, który jest symbolem emocjonalnej głębi i intuicji, często ukrywający swoją wrażliwość pod zewnętrzną twardością1.\r\n\n" +
                        "    Osoby urodzone pod tym znakiem są znane z ich opiekuńczej natury, silnej intuicji i zdolności do głębokiego zrozumienia emocji innych.\r\n\n" +
                        "    Księżyc, jako władca Raka, nadaje mu tajemniczość i wpływa na zmienne nastroje, które mogą być równie zmiennych jak fazy księżycowe1.\r\n\n" +
                        "    Rak ceni sobie dom i rodzinę ponad wszystko, tworząc wokół siebie atmosferę bezpieczeństwa i komfortu2.\r\n\n" +
                        "    Choć czasami może wydawać się nieufny i kapryśny, Rak jest lojalnym przyjacielem i partnerem, gotowym do wielkich poświęceń dla bliskich.\r\n ";
                    labelTitle.Text = "Rak (21 czerwca - 22 lipca): Reprezentuje opiekę i emocje.";
                    break;
                case (7, >= 23) or (8, <= 22):
                    zodiacPicture.Image = zodiac.leo;
                    labelZodiac.Text = "Lew jest znakiem zodiaku, który emanuje naturalnymi zdolnościami przywódczymi i pewnością siebie, co czyni go magnetycznym i charyzmatycznym liderem1.\r\n\n" +
                        "    Osoby spod tego znaku są często hojne i lojalne, mając wielu przyjaciół dzięki swojej serdeczności i zdrowemu poczuciu humoru1.\r\n\n" +
                        "    Słońce, jako planeta rządząca Lwem, nadaje mu siłę i blask, inspirując do dążenia do samoświadomości i rozwoju osobistego1.\r\n\n" +
                        "    Lwy cenią sobie zabawę i luksus, a ich żywioł ognia sprawia, że są pełne pasji i entuzjazmu do życia1.\r\n\n" +
                        "    Mimo że mogą być czasami postrzegane jako aroganckie lub egocentryczne, w rzeczywistości Lwy są odważne i gotowe stawić czoła wyzwaniom z godnością i szacunkiem1.\r\n";
                    labelTitle.Text = "Lew (23 lipca - 22 sierpnia): Symbolizuje władzę i kreatywność.";
                    break;
                case (8, >= 23) or (9, <= 22):
                    zodiacPicture.Image = zodiac.virgo;
                    labelZodiac.Text = "Panna to znak zodiaku, który jest uosobieniem dokładności i skrupulatności, z silnym zmysłem analitycznym i praktycznym podejściem do życia1.\r\n\n" +
                        "    Osoby urodzone pod tym znakiem często cechuje perfekcjonizm i tendencja do analizowania każdego szczegółu, co sprawia, że są niezawodne w każdym zadaniu2.\r\n\n" +
                        "    Rządząca Panną planeta Merkury wpływa na ich komunikatywność i inteligencję, co czyni je świetnymi rozwiązywaczami problemów1.\r\n\n" +
                        "    Panny są znane z lojalności i uczciwości, co sprawia, że są cenionymi przyjaciółmi i współpracownikami.\r\n\n" +
                        "    Choć mogą być czasami krytyczne wobec siebie i innych, ich pomocna natura i pragnienie doskonalenia sprawiają, że są nieocenione w każdym zespole.\r\n";
                    labelTitle.Text = "Panna (23 sierpnia - 22 września): Reprezentuje precyzję i analizę.";
                    break;
                case (9, >= 23) or (10, <= 23):
                    zodiacPicture.Image = zodiac.libra;
                    labelZodiac.Text = "Waga to znak zodiaku, który symbolizuje równowagę i harmonię, a osoby urodzone pod tym znakiem często posiadają wysoko rozwiniętą empatię i dążą do unikania konfliktów1.\r\n\n" +
                        "    Rządzone przez planetę Wenus, Wagi mają naturalną skłonność do doceniania piękna i sztuki, często wykazując zainteresowanie kulturą i uczestnicząc w wydarzeniach artystycznych1.\r\n\n" +
                        "    Wagi są znane z ich dyplomatycznego podejścia do życia, mają tendencję do bycia sprawiedliwymi i uczciwymi, co czyni je doskonałymi mediatorami w każdej sytuacji2.\r\n\n" +
                        "    Charakteryzują się one również urokiem osobistym i życzliwością, co sprawia, że są dobrze odbierane przez otoczenie i mają wielu przyjaciół1.\r\n\n" +
                        "    Mimo że czasami mogą być niezdecydowane, Wagi są lojalne i prawdomówne, a ich silna osobowość pomaga im w rozwiązywaniu problemów i podejmowaniu ważnych decyzji1.\r\n";
                    labelTitle.Text = "Waga (23 września - 22 października): Symbolizuje równowagę i harmonię.";
                    break;
                case (10, >= 24) or (11, <= 22):
                    zodiacPicture.Image = zodiac.scorpio;
                    labelZodiac.Text = "Skorpion to znak zodiaku, który jest znany z intensywnej energii i emocji, często rządzony przez silne planety jak Mars i Pluton, co nadaje mu cechy transformacji i odrodzenia1.\r\n\n" +
                        "    Osoby urodzone pod tym znakiem są często postrzegane jako detektywi zodiaku, mają zdolność do głębokiego penetrowania tajemnic i odkrywania ukrytych prawd1.\r\n\n" +
                        "    Charakterystyczne dla Skorpiona jest jego wytrwałość i ambicja, a także głęboka emocjonalność i wysoka intuicja, co sprawia, że są oni pasjonatami swoich zainteresowań i relacji1.\r\n\n" +
                        "    Skorpiony cenią głębokie rozmowy i związki emocjonalne, unikając powierzchowności i płytkich relacji1.\r\n\n" +
                        "    Mimo że mogą być postrzegane jako osoby o silnym charakterze i nieustraszone, w rzeczywistości Skorpiony są lojalne i namiętne, gotowe do wielkich poświęceń dla bliskich1.\r\n ";
                    labelTitle.Text = "Skorpion (23 października - 21 listopada): Reprezentuje pasję i tajemniczość.";
                    break;
                case (11, >= 23) or (12, <= 21):
                    zodiacPicture.Image = zodiac.sagitarius;
                    labelZodiac.Text = "Strzelce są znane ze swojego optymizmu i miłości do wolności, co często prowadzi ich do poszukiwania nowych przygód i doświadczeń1.\r\n\n" +
                        "    Osoby urodzone pod tym znakiem często wykazują energiczność i kreatywność, a ich żywiołowy charakter sprawia, że nie znoszą nudy i monotonii.\r\n\n" +
                        "    Rządząca planetą Strzelca jest Jowisz, co wiąże się z ich potrzebą rozwoju, nauki i optymistycznego podejścia do życia.\r\n\n" +
                        "    Strzelce mają tendencję do bycia bezpośrednimi i szczerymi, co czasami może być odbierane jako brak taktu, ale to również świadczy o ich autentyczności.\r\n\n" +
                        "    W relacjach międzyludzkich, Strzelce cenią sobie niezależność i wolność, poszukując partnerów, którzy podzielają ich entuzjazm do życia i nie ograniczają ich swobody.\r\n";
                    labelTitle.Text = "Strzelec (22 listopada - 21 grudnia): Symbolizuje optymizm i poszukiwanie przygód.";
                    break;
                case (12, >= 22) or (1, <= 19):
                    zodiacPicture.Image = zodiac.capricorn;
                    labelZodiac.Text = "Koziorożce są ambitne i dyscyplinowane, co sprawia, że często osiągają sukcesy dzięki swojej ciężkiej pracy i praktycznemu podejściu do życia1.\r\n\n" +
                        "    Jako znak zodiaku, który patronuje Ziemia, Koziorożce są uważane za trzeźwo myślących realistów, którzy cenią sobie stabilność i bezpieczeństwo.\r\n\n" +
                        "    Osoby spod tego znaku często wykazują perfekcjonizm i skupienie na rzeczach materialnych, co może czasem prowadzić do zapominania o potrzebach emocjonalnych.\r\n\n" +
                        "    W relacjach międzyludzkich Koziorożce są lojalne i odpowiedzialne, ale ich naturalna ostrożność może sprawiać, że trudno jest zdobyć ich zaufanie.\r\n\n" +
                        "    W miłości i przyjaźni Koziorożce są szczere i oddane, choć ich grono przyjaciół jest zazwyczaj ograniczone do kilku zaufanych osób.\r\n";
                    labelTitle.Text = "Koziorożec (22 grudnia - 19 stycznia): Reprezentuje ambicję i pracowitość.";
                    break;
                case (1, >= 20) or (2, <= 18):
                    zodiacPicture.Image = zodiac.aquarius;
                    labelZodiac.Text = "Wodniki są znane z ich niezależności i oryginalności, często idą własną drogą i nie boją się łamać konwencji.\r\n\n" +
                        "    Jako znak powietrza, Wodniki mają szybko myślący umysł i są otwarte na nowe idee, co czyni je wizjonerami w wielu dziedzinach.\r\n\n" +
                        "    Uran, rządząca planeta Wodnika, sprzyja ich buntowniczej naturze i zachęca do innowacyjnego myślenia oraz poszukiwania rewolucyjnych rozwiązań.\r\n\n" +
                        "    Wodniki często angażują się w aktywizm społeczny i działania na rzecz dobra wspólnego, co odzwierciedla ich humanitarny charakter.\r\n\n" +
                        "    W relacjach osobistych Wodniki szukają porozumienia intelektualnego i potrzebują partnera, który będzie mógł dotrzymać im kroku w ich nieustannym dążeniu do wolności i przygód.\r\n";
                    labelTitle.Text = "Wodnik (20 stycznia - 18 lutego): Symbolizuje niezależność i oryginalność.";
                    break;
                case (2, >= 19) or (3, <= 20):
                    zodiacPicture.Image = zodiac.pisces;
                    labelZodiac.Text = "Ryby są intuicyjne i empatyczne, co pozwala im głęboko rozumieć uczucia innych i często sprawia, że angażują się w działania pomocowe.\r\n\n" +
                        "    Jako znak wodny, Ryby mają silną kreatywność i duchowość, co skłania je do poszukiwania głębszego sensu w życiu i wyrażania siebie przez sztukę.\r\n\n" +
                        "    Rządząca planetą Ryb jest Neptun, co wiąże się z ich marzycielską naturą i skłonnością do ucieczki w świat fantazji i snów2.\r\n\n" +
                        "    Ryby są znane z ich wrażliwości i bezinteresowności, często stawiając potrzeby innych ponad własne, co może prowadzić do nadmiernego poświęcenia2.\r\n\n" +
                        "    W relacjach międzyludzkich Ryby szukają duchowego porozumienia i głębokiej więzi, pragnąc miłości, która jest równie bajkowa, jak ich idealistyczne wyobrażenia o związku1.\r\n";
                    labelTitle.Text = "Ryby (19 lutego - 20 marca): Reprezentują intuicję i współczucie.";
                    break;
                default:
                    zodiacPicture.Image = Properties.Resources.astrology_logo_small;
                    labelZodiac.Text = "Cos poszlo nie tak ";
                    labelTitle.Text = "Jakiś błąd";
                    break;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
