namespace Astrology_Desktop.Forms
{
    partial class FormC
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            labelChoice = new Label();
            linkLabelMail = new LinkLabel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(209, 253);
            label1.Name = "label1";
            label1.Size = new Size(313, 40);
            label1.TabIndex = 1;
            label1.Text = "Czy podoba ci się ta aplikacja?";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(248, 313);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Tak!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(407, 313);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Nie...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelChoice
            // 
            labelChoice.Anchor = AnchorStyles.None;
            labelChoice.AutoSize = true;
            labelChoice.ForeColor = Color.WhiteSmoke;
            labelChoice.Location = new Point(279, 359);
            labelChoice.Name = "labelChoice";
            labelChoice.Size = new Size(16, 15);
            labelChoice.TabIndex = 4;
            labelChoice.Text = "...";
            labelChoice.TextAlign = ContentAlignment.MiddleCenter;
            labelChoice.Visible = false;
            // 
            // linkLabelMail
            // 
            linkLabelMail.Anchor = AnchorStyles.None;
            linkLabelMail.AutoSize = true;
            linkLabelMail.Location = new Point(329, 403);
            linkLabelMail.Name = "linkLabelMail";
            linkLabelMail.Size = new Size(48, 15);
            linkLabelMail.TabIndex = 5;
            linkLabelMail.TabStop = true;
            linkLabelMail.Text = "Kontakt";
            linkLabelMail.Visible = false;
            linkLabelMail.LinkClicked += linkLabelMail_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.astrology_logo_small;
            pictureBox1.Location = new Point(279, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 154);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(309, 208);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 7;
            label2.Text = "Astrology ver. 0.1";
            label2.Click += label2_Click;
            // 
            // FormC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 26, 80);
            ClientSize = new Size(813, 456);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabelMail);
            Controls.Add(labelChoice);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "FormC";
            Text = "FormC";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label labelChoice;
        private LinkLabel linkLabelMail;
        private PictureBox pictureBox1;
        private Label label2;
    }
}