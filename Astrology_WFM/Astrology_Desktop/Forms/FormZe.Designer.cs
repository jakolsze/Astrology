namespace Astrology_Desktop.Forms
{
    partial class FormZe
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
            zodiacPicture = new PictureBox();
            labelZodiac = new Label();
            labelTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)zodiacPicture).BeginInit();
            SuspendLayout();
            // 
            // zodiacPicture
            // 
            zodiacPicture.Anchor = AnchorStyles.None;
            zodiacPicture.Location = new Point(28, 87);
            zodiacPicture.Name = "zodiacPicture";
            zodiacPicture.Size = new Size(320, 320);
            zodiacPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            zodiacPicture.TabIndex = 0;
            zodiacPicture.TabStop = false;
            // 
            // labelZodiac
            // 
            labelZodiac.Anchor = AnchorStyles.None;
            labelZodiac.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelZodiac.ForeColor = Color.WhiteSmoke;
            labelZodiac.Location = new Point(409, 109);
            labelZodiac.Name = "labelZodiac";
            labelZodiac.Size = new Size(340, 279);
            labelZodiac.TabIndex = 1;
            labelZodiac.Text = "label1";
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.None;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F);
            labelTitle.ForeColor = Color.WhiteSmoke;
            labelTitle.Location = new Point(79, 25);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(71, 30);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "label1";
            // 
            // FormZe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 26, 80);
            ClientSize = new Size(813, 456);
            Controls.Add(labelTitle);
            Controls.Add(labelZodiac);
            Controls.Add(zodiacPicture);
            Name = "FormZe";
            Text = "FormZe";
            ((System.ComponentModel.ISupportInitialize)zodiacPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox zodiacPicture;
        private Label labelZodiac;
        private Label labelTitle;
    }
}