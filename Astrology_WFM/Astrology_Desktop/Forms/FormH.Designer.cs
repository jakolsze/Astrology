namespace Astrology_Desktop.Forms
{
    partial class FormH
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
            labelH = new Label();
            SuspendLayout();
            // 
            // labelH
            // 
            labelH.Anchor = AnchorStyles.None;
            labelH.Font = new Font("Segoe UI", 12F);
            labelH.ForeColor = Color.WhiteSmoke;
            labelH.Location = new Point(156, 92);
            labelH.Name = "labelH";
            labelH.Size = new Size(575, 301);
            labelH.TabIndex = 0;
            labelH.Text = "Trwa wczytywanie horoskopu";
            // 
            // FormH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 26, 80);
            ClientSize = new Size(813, 456);
            Controls.Add(labelH);
            Name = "FormH";
            Text = "FormH";
            ResumeLayout(false);
        }

        #endregion

        private Label labelH;
    }
}