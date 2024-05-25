namespace Astrology_Desktop
{
    partial class welcome
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
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            labelTitle = new Label();
            labelPodajDate = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(121, 350);
            button1.Name = "button1";
            button1.Size = new Size(137, 65);
            button1.TabIndex = 0;
            button1.Text = "Potwierdź";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(49, 293);
            dateTimePicker1.MaxDate = new DateTime(2101, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1901, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(264, 23);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.Value = new DateTime(1901, 1, 1, 0, 0, 0, 0);
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.None;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.WhiteSmoke;
            labelTitle.Location = new Point(20, 24);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(334, 32);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "Witaj w programie Astrology!";
            // 
            // labelPodajDate
            // 
            labelPodajDate.Anchor = AnchorStyles.None;
            labelPodajDate.AutoSize = true;
            labelPodajDate.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPodajDate.ForeColor = Color.WhiteSmoke;
            labelPodajDate.Location = new Point(82, 263);
            labelPodajDate.Name = "labelPodajDate";
            labelPodajDate.Size = new Size(203, 18);
            labelPodajDate.TabIndex = 4;
            labelPodajDate.Text = "Podaj datę urodzenia:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.astrology_logo_small;
            pictureBox1.Location = new Point(112, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 155);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 32, 89);
            ClientSize = new Size(366, 450);
            Controls.Add(pictureBox1);
            Controls.Add(labelPodajDate);
            Controls.Add(labelTitle);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Name = "welcome";
            Text = "Astrology";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label labelTitle;
        private Label labelPodajDate;
        private PictureBox pictureBox1;
    }
}