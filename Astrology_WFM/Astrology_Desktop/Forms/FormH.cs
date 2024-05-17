using Azure.AI.OpenAI;
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
    public partial class FormH : Form
    {
        string gpt_model = "gpt-3.5-turbo";
        public FormH()
        {
            InitializeComponent();
            chatgpt();
        }
        public async Task chatgpt()
        {
            if (welcome.instance.flag == 0)
            {
                string pies = "Podaj horoskop na dzis dla osoby urodzonej w dniu: ";
                string kot = welcome.instance.wybranaData.ToString("dd-MM");
                string zwierzeta = ". Ogranicz się do 5 zdań.";
                string query = pies + kot + zwierzeta;


                OpenAIClient client = new OpenAIClient(welcome.instance.gpt_api_key);
                // Przygotowanie opcji dla zapytania

                var chatCompletionsOptions = new ChatCompletionsOptions()
                {
                    DeploymentName = gpt_model, // Use DeploymentName for "model" with non-Azure clients
                    Messages =
                  {
                      new ChatRequestSystemMessage(query),
                  }
                };

                // Wywołanie metody GetChatCompletionsAsync i oczekiwanie na odpowiedź
                var response = await client.GetChatCompletionsAsync(chatCompletionsOptions);
                var completions = response.Value.Choices[0].Message.Content;

                // Wyświetlenie odpowiedzi
                labelH.Text = completions;
                //labelH.Text = query;
                welcome.instance.flag = 1;
                welcome.instance.pamiec = completions.ToString();
            }
            else
            {
                labelH.Text = welcome.instance.pamiec;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gpt_model = comboBox1.Text;
            welcome.instance.flag = 0;
            this.Controls.Clear(); // Usuwa wszystkie kontrolki z formularza
            this.InitializeComponent(); // Ponownie inicjalizuje wszystkie kontrolki na formularzu
            this.chatgpt();

        }
    }
}
