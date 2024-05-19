namespace Astrology_Desktop.Forms
{
    partial class FormL
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
            labelKorzystnosc = new Label();
            pictureGood1 = new PictureBox();
            pictureGood2 = new PictureBox();
            pictureGood3 = new PictureBox();
            pictureBad1 = new PictureBox();
            pictureBad2 = new PictureBox();
            pictureKorzystnosc = new PictureBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            labelGood1 = new Label();
            labelGood2 = new Label();
            labelGood3 = new Label();
            labelBad1 = new Label();
            labelBad2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureGood1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureGood2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureGood3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBad1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBad2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureKorzystnosc).BeginInit();
            SuspendLayout();
            // 
            // labelKorzystnosc
            // 
            labelKorzystnosc.Anchor = AnchorStyles.None;
            labelKorzystnosc.AutoSize = true;
            labelKorzystnosc.Font = new Font("Segoe UI", 16F);
            labelKorzystnosc.ForeColor = Color.WhiteSmoke;
            labelKorzystnosc.Location = new Point(341, 250);
            labelKorzystnosc.Name = "labelKorzystnosc";
            labelKorzystnosc.Size = new Size(107, 30);
            labelKorzystnosc.TabIndex = 0;
            labelKorzystnosc.Text = "Korzystne";
            labelKorzystnosc.Visible = false;
            // 
            // pictureGood1
            // 
            pictureGood1.Anchor = AnchorStyles.None;
            pictureGood1.BackColor = Color.Transparent;
            pictureGood1.Location = new Point(513, 297);
            pictureGood1.Name = "pictureGood1";
            pictureGood1.Size = new Size(120, 120);
            pictureGood1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureGood1.TabIndex = 2;
            pictureGood1.TabStop = false;
            pictureGood1.Visible = false;
            // 
            // pictureGood2
            // 
            pictureGood2.Anchor = AnchorStyles.None;
            pictureGood2.BackColor = Color.Transparent;
            pictureGood2.Location = new Point(328, 297);
            pictureGood2.Name = "pictureGood2";
            pictureGood2.Size = new Size(120, 120);
            pictureGood2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureGood2.TabIndex = 3;
            pictureGood2.TabStop = false;
            pictureGood2.Visible = false;
            // 
            // pictureGood3
            // 
            pictureGood3.Anchor = AnchorStyles.None;
            pictureGood3.BackColor = Color.Transparent;
            pictureGood3.Location = new Point(141, 297);
            pictureGood3.Name = "pictureGood3";
            pictureGood3.Size = new Size(120, 120);
            pictureGood3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureGood3.TabIndex = 4;
            pictureGood3.TabStop = false;
            pictureGood3.Visible = false;
            // 
            // pictureBad1
            // 
            pictureBad1.Anchor = AnchorStyles.None;
            pictureBad1.Location = new Point(235, 297);
            pictureBad1.Name = "pictureBad1";
            pictureBad1.Size = new Size(120, 120);
            pictureBad1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBad1.TabIndex = 2;
            pictureBad1.TabStop = false;
            pictureBad1.Visible = false;
            // 
            // pictureBad2
            // 
            pictureBad2.Anchor = AnchorStyles.None;
            pictureBad2.Location = new Point(412, 297);
            pictureBad2.Name = "pictureBad2";
            pictureBad2.Size = new Size(120, 120);
            pictureBad2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBad2.TabIndex = 3;
            pictureBad2.TabStop = false;
            pictureBad2.Visible = false;
            // 
            // pictureKorzystnosc
            // 
            pictureKorzystnosc.Anchor = AnchorStyles.None;
            pictureKorzystnosc.Image = Properties.Resources.question;
            pictureKorzystnosc.Location = new Point(276, 39);
            pictureKorzystnosc.Name = "pictureKorzystnosc";
            pictureKorzystnosc.Size = new Size(224, 208);
            pictureKorzystnosc.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureKorzystnosc.TabIndex = 5;
            pictureKorzystnosc.TabStop = false;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.None;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(530, 130);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(101, 23);
            iconButton1.TabIndex = 6;
            iconButton1.Text = "Niekorzystne";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.None;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(159, 130);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(75, 23);
            iconButton2.TabIndex = 7;
            iconButton2.Text = "Korzystne";
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(264, 15);
            label2.Name = "label2";
            label2.Size = new Size(257, 21);
            label2.TabIndex = 8;
            label2.Text = "Poznaj swoje dopasowanie miłosne:";
            // 
            // labelGood1
            // 
            labelGood1.Anchor = AnchorStyles.None;
            labelGood1.AutoSize = true;
            labelGood1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelGood1.ForeColor = Color.WhiteSmoke;
            labelGood1.Location = new Point(176, 432);
            labelGood1.Name = "labelGood1";
            labelGood1.Size = new Size(70, 15);
            labelGood1.TabIndex = 9;
            labelGood1.Text = "labelGood1";
            labelGood1.Visible = false;
            // 
            // labelGood2
            // 
            labelGood2.Anchor = AnchorStyles.None;
            labelGood2.AutoSize = true;
            labelGood2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelGood2.ForeColor = Color.WhiteSmoke;
            labelGood2.Location = new Point(556, 432);
            labelGood2.Name = "labelGood2";
            labelGood2.Size = new Size(40, 15);
            labelGood2.TabIndex = 10;
            labelGood2.Text = "label3";
            labelGood2.Visible = false;
            // 
            // labelGood3
            // 
            labelGood3.Anchor = AnchorStyles.None;
            labelGood3.AutoSize = true;
            labelGood3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelGood3.ForeColor = Color.WhiteSmoke;
            labelGood3.Location = new Point(354, 432);
            labelGood3.Name = "labelGood3";
            labelGood3.Size = new Size(40, 15);
            labelGood3.TabIndex = 11;
            labelGood3.Text = "label4";
            labelGood3.Visible = false;
            // 
            // labelBad1
            // 
            labelBad1.Anchor = AnchorStyles.None;
            labelBad1.AutoSize = true;
            labelBad1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelBad1.ForeColor = Color.WhiteSmoke;
            labelBad1.Location = new Point(284, 426);
            labelBad1.Name = "labelBad1";
            labelBad1.Size = new Size(40, 15);
            labelBad1.TabIndex = 12;
            labelBad1.Text = "label1";
            labelBad1.Visible = false;
            // 
            // labelBad2
            // 
            labelBad2.Anchor = AnchorStyles.None;
            labelBad2.AutoSize = true;
            labelBad2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelBad2.ForeColor = Color.WhiteSmoke;
            labelBad2.Location = new Point(443, 426);
            labelBad2.Name = "labelBad2";
            labelBad2.Size = new Size(40, 15);
            labelBad2.TabIndex = 13;
            labelBad2.Text = "label3";
            labelBad2.Visible = false;
            // 
            // FormL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 26, 80);
            ClientSize = new Size(813, 456);
            Controls.Add(labelBad2);
            Controls.Add(labelBad1);
            Controls.Add(labelGood3);
            Controls.Add(labelGood2);
            Controls.Add(labelGood1);
            Controls.Add(label2);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(pictureBad2);
            Controls.Add(pictureGood1);
            Controls.Add(pictureBad1);
            Controls.Add(pictureGood3);
            Controls.Add(pictureGood2);
            Controls.Add(labelKorzystnosc);
            Controls.Add(pictureKorzystnosc);
            Name = "FormL";
            Text = "FormL";
            ((System.ComponentModel.ISupportInitialize)pictureGood1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureGood2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureGood3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBad1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBad2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureKorzystnosc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelKorzystnosc;
        private PictureBox pictureGood1;
        private PictureBox pictureGood2;
        private PictureBox pictureGood3;
        private PictureBox pictureBad1;
        private PictureBox pictureBad2;
        private PictureBox pictureKorzystnosc;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label2;
        private Label labelGood1;
        private Label labelGood2;
        private Label labelGood3;
        private Label labelBad1;
        private Label labelBad2;
    }
}