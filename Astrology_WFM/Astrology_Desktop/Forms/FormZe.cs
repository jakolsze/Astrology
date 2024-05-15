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
        private DateTime data = welcome.instance.wybranaData;
        public FormZe()
        {
            InitializeComponent();
            if (data.Month == 07)
            {
                pictureBox1.Image = zodiac.leo;
            }
            if (data.Month == 06)
            {
                pictureBox1.Image = zodiac.gemini;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
