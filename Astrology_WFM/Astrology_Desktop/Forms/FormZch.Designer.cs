namespace Astrology_Desktop.Forms
{
    partial class FormZch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chinesePicture = new PictureBox();
            labelZch = new Label();
            labelOpis = new Label();
            ((System.ComponentModel.ISupportInitialize)chinesePicture).BeginInit();
            SuspendLayout();
            // 
            // chinesePicture
            // 
            chinesePicture.Anchor = AnchorStyles.None;
            chinesePicture.Image = Properties.Resources.astrology_logo_small;
            chinesePicture.Location = new Point(201, 82);
            chinesePicture.Name = "chinesePicture";
            chinesePicture.Size = new Size(320, 320);
            chinesePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            chinesePicture.TabIndex = 0;
            chinesePicture.TabStop = false;
            // 
            // labelZch
            // 
            labelZch.Anchor = AnchorStyles.None;
            labelZch.AutoSize = true;
            labelZch.Font = new Font("Segoe UI", 16F);
            labelZch.ForeColor = Color.WhiteSmoke;
            labelZch.Location = new Point(292, 31);
            labelZch.Name = "labelZch";
            labelZch.RightToLeft = RightToLeft.Yes;
            labelZch.Size = new Size(71, 30);
            labelZch.TabIndex = 1;
            labelZch.Text = "label1";
            // 
            // labelOpis
            // 
            labelOpis.Anchor = AnchorStyles.None;
            labelOpis.AutoSize = true;
            labelOpis.Font = new Font("Segoe UI", 10F);
            labelOpis.ForeColor = Color.WhiteSmoke;
            labelOpis.Location = new Point(12, 416);
            labelOpis.Name = "labelOpis";
            labelOpis.Size = new Size(45, 19);
            labelOpis.TabIndex = 2;
            labelOpis.Text = "label1";
            // 
            // FormZch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 26, 80);
            ClientSize = new Size(813, 456);
            Controls.Add(labelOpis);
            Controls.Add(labelZch);
            Controls.Add(chinesePicture);
            Name = "FormZch";
            Text = "FormZch";
            ((System.ComponentModel.ISupportInitialize)chinesePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox chinesePicture;
        private Label labelZch;
        private Label labelOpis;
    }
}