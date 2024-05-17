namespace Astrology_Desktop.Forms
{
    partial class FormHome
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
            resetDateTimePicker = new DateTimePicker();
            resetButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // resetDateTimePicker
            // 
            resetDateTimePicker.Anchor = AnchorStyles.None;
            resetDateTimePicker.Location = new Point(307, 237);
            resetDateTimePicker.Name = "resetDateTimePicker";
            resetDateTimePicker.Size = new Size(200, 23);
            resetDateTimePicker.TabIndex = 0;
            // 
            // resetButton
            // 
            resetButton.Anchor = AnchorStyles.None;
            resetButton.Location = new Point(365, 310);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 1;
            resetButton.Text = "Potwierdź";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(294, 159);
            label1.Name = "label1";
            label1.Size = new Size(223, 32);
            label1.TabIndex = 2;
            label1.Text = "Wybierz nową datę:";
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 26, 80);
            ClientSize = new Size(813, 456);
            Controls.Add(label1);
            Controls.Add(resetButton);
            Controls.Add(resetDateTimePicker);
            Name = "FormHome";
            Text = "FormDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker resetDateTimePicker;
        private Button resetButton;
        private Label label1;
    }
}