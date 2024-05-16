
using Astrology_Desktop.Forms;
using FontAwesome.Sharp;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Azure;
using Azure.AI.OpenAI;

namespace Astrology_Desktop
{
    public partial class main : Form
    {

        //Fields
        private Panel leftBorderBtn;
        private IconButton currentBtn;
        private Form currentChildForm;
        public static main instance;
        public main()
        {
            InitializeComponent();
            instance = this;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //form graphics improvement
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            //topbar 
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.StartPosition = FormStartPosition.CenterScreen;
            Welcome_Load();
            // Utwórz nowy obiekt ToolTip
            ToolTip toolTip1 = new ToolTip();

            // Ustaw czas trwania dymka
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;

            // Ustaw, aby dymek był zawsze widoczny
            toolTip1.ShowAlways = true;

            // Ustaw tekst dymka dla pictureBox1
            toolTip1.SetToolTip(this.homeBtn, "Wybierz nową datę");

            // openAI
            chatgpt();
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 255, 255);
            public static Color color2 = Color.FromArgb(245, 245, 245);
            public static Color color3 = Color.FromArgb(220, 220, 220);
            public static Color color4 = Color.FromArgb(211, 211, 211);
            public static Color color5 = Color.FromArgb(192, 192, 192);
            public static Color color6 = Color.FromArgb(169, 169, 169);
        }

        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // lewy button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //home label
                currentIcon.IconChar = currentBtn.IconChar;
                currentLabel.Text = currentBtn.Text;


            }
        }
        public void Welcome_Load()
        {
            wybranaDataDateTimePicker.Value = welcome.instance.wybranaData;
            //label1.Text = wybranaDataDateTimePicker.Value.ToString("dd-MM-yyyy");

        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(13, 32, 89);
                currentBtn.ForeColor = Color.WhiteSmoke;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.WhiteSmoke;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            if (currentLabel.Text != "Start")
            {
                currentLabel.Text = currentBtn.Text;
            }


        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void zeBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new FormZe());
        }

        private void zchBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new FormZch());
        }

        private void znBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new FormZn());
        }

        private void hBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
            OpenChildForm(new FormH());
        }

        private void lBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
            OpenChildForm(new FormL());
        }

        private void cBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
            OpenChildForm(new FormC());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            currentIcon.IconChar = IconChar.HomeAlt;
            currentLabel.Text = "Start";
        }
        private void homeBtn_Click(object sender, EventArgs e)
        {
            Reset();
            OpenChildForm(new FormHome());

        }

        //draging form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;

        }

        private void mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        public async Task chatgpt()
        {

            string pies = "Podaj 3 slawne osoby urodzne w dniu: ";
            string kot = wybranaDataDateTimePicker.Value.ToString("dd-MM");
            string query = pies + kot;


            OpenAIClient client = new OpenAIClient("sk-proj-hs2lXSTjAWNllnWm6PHET3BlbkFJmomnrkPU1T9zzwUkG9oe");
            // Przygotowanie opcji dla zapytania

            var chatCompletionsOptions = new ChatCompletionsOptions()
            {
                DeploymentName = "gpt-3.5-turbo", // Use DeploymentName for "model" with non-Azure clients
                Messages =
                  {
                      new ChatRequestSystemMessage(query),
                  }
            };
            
            // Wywołanie metody GetChatCompletionsAsync i oczekiwanie na odpowiedź
            var response = await client.GetChatCompletionsAsync(chatCompletionsOptions);
            var completions = response.Value.Choices[0].Message.Content;

            // Wyświetlenie odpowiedzi
            gptFamLabel.Text=completions;
            //gptFamLabel.Text = query;
        }

    }
}
