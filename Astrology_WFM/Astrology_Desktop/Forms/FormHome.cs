using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Astrology_Desktop.Forms
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            welcome.instance.wybranaData = resetDateTimePicker.Value;
            this.Hide();
            main.instance.Close();
            main newForm = new main(); // Tworzenie nowego formularza
            newForm.Show();
                        
        }
    }
}
