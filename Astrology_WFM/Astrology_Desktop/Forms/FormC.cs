using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Astrology_Desktop.Forms
{
    public partial class FormC : Form
    {
        private System.Windows.Forms.Timer timer1;

        public FormC()
        {
            InitializeComponent();
            this.timer1 = new System.Windows.Forms.Timer();
            this.timer1.Interval = 500;
            this.timer1.Tick += new EventHandler(timer1_Tick);
            this.timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelChoice.Text = "SUPER! Bardzo się cieszę!";
            labelChoice.Font = new Font(labelChoice.Font.FontFamily, 16);
            linkLabelMail.Visible = false;
            labelChoice.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelChoice.Text = "Daj mi proszę znać co mógłbym poprawić!";
            labelChoice.Font = new Font(labelChoice.Font.FontFamily, 12);
            linkLabelMail.Visible = true;
            labelChoice.Visible = true;
        }

        private void linkLabelMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "mailto:kontakt@example.com",
                UseShellExecute = true
            };
            Process.Start(psi);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label3.Visible = !label3.Visible;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
