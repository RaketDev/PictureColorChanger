
namespace PictureColorLabel
{
    partial class PCLGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.labelRed = new System.Windows.Forms.Button();
            this.labelGreen = new System.Windows.Forms.Button();
            this.labelBlue = new System.Windows.Forms.Button();
            this.RGBValue = new System.Windows.Forms.NumericUpDown();
            this.LabelGray = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGBValue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(126, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(774, 426);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(9, 12);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // labelRed
            // 
            this.labelRed.Location = new System.Drawing.Point(9, 119);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(75, 23);
            this.labelRed.TabIndex = 8;
            this.labelRed.Text = "Red";
            this.labelRed.UseVisualStyleBackColor = true;
            this.labelRed.Click += new System.EventHandler(this.labelRed_Click);
            // 
            // labelGreen
            // 
            this.labelGreen.Location = new System.Drawing.Point(9, 148);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(75, 23);
            this.labelGreen.TabIndex = 9;
            this.labelGreen.Text = "Green";
            this.labelGreen.UseVisualStyleBackColor = true;
            this.labelGreen.Click += new System.EventHandler(this.labelGreen_Click);
            // 
            // labelBlue
            // 
            this.labelBlue.Location = new System.Drawing.Point(9, 177);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(75, 23);
            this.labelBlue.TabIndex = 10;
            this.labelBlue.Text = "Blue";
            this.labelBlue.UseVisualStyleBackColor = true;
            this.labelBlue.Click += new System.EventHandler(this.labelBlue_Click);
            // 
            // RGBValue
            // 
            this.RGBValue.Location = new System.Drawing.Point(9, 90);
            this.RGBValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RGBValue.Name = "RGBValue";
            this.RGBValue.Size = new System.Drawing.Size(75, 23);
            this.RGBValue.TabIndex = 11;
            this.RGBValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // LabelGray
            // 
            this.LabelGray.Location = new System.Drawing.Point(9, 206);
            this.LabelGray.Name = "LabelGray";
            this.LabelGray.Size = new System.Drawing.Size(75, 23);
            this.LabelGray.TabIndex = 12;
            this.LabelGray.Text = "Gray";
            this.LabelGray.UseVisualStyleBackColor = true;
            this.LabelGray.Click += new System.EventHandler(this.LabelGray_Click);
            // 
            // PCLGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 449);
            this.Controls.Add(this.LabelGray);
            this.Controls.Add(this.RGBValue);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.browseButton);
            this.Name = "PCLGUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PCLGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGBValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button labelRed;
        private System.Windows.Forms.Button labelGreen;
        private System.Windows.Forms.Button labelBlue;
        private System.Windows.Forms.NumericUpDown RGBValue;
        private System.Windows.Forms.Button LabelGray;
    }
}

