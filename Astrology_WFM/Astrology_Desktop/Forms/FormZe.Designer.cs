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
            ((System.ComponentModel.ISupportInitialize)zodiacPicture).BeginInit();
            SuspendLayout();
            // 
            // zodiacPicture
            // 
            zodiacPicture.Location = new Point(0, 0);
            zodiacPicture.Name = "zodiacPicture";
            zodiacPicture.Size = new Size(813, 456);
            zodiacPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            zodiacPicture.TabIndex = 0;
            zodiacPicture.TabStop = false;
            // 
            // FormZe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 26, 80);
            ClientSize = new Size(813, 456);
            Controls.Add(zodiacPicture);
            Name = "FormZe";
            Text = "FormZe";
            ((System.ComponentModel.ISupportInitialize)zodiacPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox zodiacPicture;
    }
}