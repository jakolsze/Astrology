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
            SuspendLayout();
            // 
            // resetDateTimePicker
            // 
            resetDateTimePicker.Location = new Point(306, 162);
            resetDateTimePicker.Name = "resetDateTimePicker";
            resetDateTimePicker.Size = new Size(200, 23);
            resetDateTimePicker.TabIndex = 0;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(364, 245);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 1;
            resetButton.Text = "Potiwerdź";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 26, 80);
            ClientSize = new Size(813, 456);
            Controls.Add(resetButton);
            Controls.Add(resetDateTimePicker);
            Name = "FormHome";
            Text = "FormDashboard";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker resetDateTimePicker;
        private Button resetButton;
    }
}