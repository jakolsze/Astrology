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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormL));
            label1 = new Label();
            label2 = new Label();
            pictureGood1 = new PictureBox();
            pictureGood2 = new PictureBox();
            pictureGood3 = new PictureBox();
            pictureBad1 = new PictureBox();
            pictureBad2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureGood1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureGood2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureGood3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBad1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBad2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(141, 50);
            label1.Name = "label1";
            label1.Size = new Size(107, 30);
            label1.TabIndex = 0;
            label1.Text = "Korzystne";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(555, 39);
            label2.Name = "label2";
            label2.Size = new Size(144, 30);
            label2.TabIndex = 1;
            label2.Text = "Niekorzystne:";
            // 
            // pictureGood1
            // 
            pictureGood1.Anchor = AnchorStyles.None;
            pictureGood1.BackColor = Color.Transparent;
            pictureGood1.Location = new Point(245, 172);
            pictureGood1.Name = "pictureGood1";
            pictureGood1.Size = new Size(120, 120);
            pictureGood1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureGood1.TabIndex = 2;
            pictureGood1.TabStop = false;
            // 
            // pictureGood2
            // 
            pictureGood2.Anchor = AnchorStyles.None;
            pictureGood2.BackColor = Color.Transparent;
            pictureGood2.Location = new Point(141, 309);
            pictureGood2.Name = "pictureGood2";
            pictureGood2.Size = new Size(120, 120);
            pictureGood2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureGood2.TabIndex = 3;
            pictureGood2.TabStop = false;
            // 
            // pictureGood3
            // 
            pictureGood3.Anchor = AnchorStyles.None;
            pictureGood3.BackColor = Color.Transparent;
            pictureGood3.Location = new Point(43, 172);
            pictureGood3.Name = "pictureGood3";
            pictureGood3.Size = new Size(120, 120);
            pictureGood3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureGood3.TabIndex = 4;
            pictureGood3.TabStop = false;
            // 
            // pictureBad1
            // 
            pictureBad1.Anchor = AnchorStyles.None;
            pictureBad1.Location = new Point(496, 206);
            pictureBad1.Name = "pictureBad1";
            pictureBad1.Size = new Size(120, 120);
            pictureBad1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBad1.TabIndex = 2;
            pictureBad1.TabStop = false;
            // 
            // pictureBad2
            // 
            pictureBad2.Anchor = AnchorStyles.None;
            pictureBad2.Location = new Point(639, 206);
            pictureBad2.Name = "pictureBad2";
            pictureBad2.Size = new Size(120, 120);
            pictureBad2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBad2.TabIndex = 3;
            pictureBad2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(85, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(523, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(206, 188);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // FormL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 26, 80);
            ClientSize = new Size(813, 456);
            Controls.Add(pictureBad2);
            Controls.Add(pictureGood1);
            Controls.Add(pictureBad1);
            Controls.Add(pictureGood3);
            Controls.Add(pictureGood2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "FormL";
            Text = "FormL";
            ((System.ComponentModel.ISupportInitialize)pictureGood1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureGood2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureGood3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBad1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBad2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureGood1;
        private PictureBox pictureGood2;
        private PictureBox pictureGood3;
        private PictureBox pictureBad1;
        private PictureBox pictureBad2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}