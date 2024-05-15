using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astrology_Desktop
{

    public partial class welcome : Form
    {
        public static welcome instance;
        public string WybranaDataString;
        public DateTime wybranaData;
        public welcome()
        {
            InitializeComponent();
            instance = this;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WybranaDataString = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            wybranaData = dateTimePicker1.Value;
            main form = new main();
            this.Hide();
            form.Show();


        }
    }
}
