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
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelH
            // 
            labelH.Anchor = AnchorStyles.None;
            labelH.Font = new Font("Segoe UI", 12F);
            labelH.ForeColor = Color.WhiteSmoke;
            labelH.Location = new Point(73, 70);
            labelH.Name = "labelH";
            labelH.Size = new Size(575, 301);
            labelH.TabIndex = 0;
            labelH.Text = "Trwa wczytywanie horoskopu...";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(518, 374);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Zapytaj!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "gpt-3.5-turbo", "gpt-4o", "gpt-4-turbo" });
            comboBox1.Location = new Point(320, 377);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(106, 375);
            label1.Name = "label1";
            label1.Size = new Size(152, 21);
            label1.TabIndex = 3;
            label1.Text = "Zapytaj inną wróżkę:";
            // 
            // FormH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 26, 80);
            ClientSize = new Size(813, 456);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(labelH);
            Name = "FormH";
            Text = "FormH";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelH;
        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
    }
}