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
using System.Windows.Forms;

namespace Astrology_Desktop.Forms
{
    public partial class FormC : Form
    {
        public FormC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelChoice.Text = "SUPER! Bardzo się cieszę!";
            linkLabelMail.Visible = false;
            labelChoice.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelChoice.Text = "Daj mi proszę znać co mógłbym poprawić!";
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
