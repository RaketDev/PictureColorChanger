
namespace PictureColorChangerGUI
{
    partial class PCCGUI
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
            this.browseButton = new System.Windows.Forms.Button();
            this.colorBarRed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.colorBarGreen = new System.Windows.Forms.TrackBar();
            this.colorBarBlue = new System.Windows.Forms.TrackBar();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imgBoxBlue = new System.Windows.Forms.TrackBar();
            this.imgBoxGreen = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.imgBoxRed = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.colorBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxRed)).BeginInit();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(12, 12);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // colorBarRed
            // 
            this.colorBarRed.Location = new System.Drawing.Point(12, 87);
            this.colorBarRed.Maximum = 255;
            this.colorBarRed.Name = "colorBarRed";
            this.colorBarRed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.colorBarRed.Size = new System.Drawing.Size(45, 150);
            this.colorBarRed.TabIndex = 1;
            this.colorBarRed.TabStop = false;
            this.colorBarRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.colorBarRed.Scroll += new System.EventHandler(this.colorBarRed_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "R         G         B";
            // 
            // colorBarGreen
            // 
            this.colorBarGreen.Location = new System.Drawing.Point(42, 87);
            this.colorBarGreen.Maximum = 255;
            this.colorBarGreen.Name = "colorBarGreen";
            this.colorBarGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.colorBarGreen.Size = new System.Drawing.Size(45, 150);
            this.colorBarGreen.TabIndex = 3;
            this.colorBarGreen.TabStop = false;
            this.colorBarGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.colorBarGreen.Scroll += new System.EventHandler(this.colorBarGreen_Scroll);
            // 
            // colorBarBlue
            // 
            this.colorBarBlue.Location = new System.Drawing.Point(73, 87);
            this.colorBarBlue.Maximum = 255;
            this.colorBarBlue.Name = "colorBarBlue";
            this.colorBarBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.colorBarBlue.Size = new System.Drawing.Size(45, 150);
            this.colorBarBlue.TabIndex = 4;
            this.colorBarBlue.TabStop = false;
            this.colorBarBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.colorBarBlue.Scroll += new System.EventHandler(this.colorBarBlue_Scroll);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(129, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(774, 426);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Background:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Image:";
            // 
            // imgBoxBlue
            // 
            this.imgBoxBlue.Location = new System.Drawing.Point(75, 286);
            this.imgBoxBlue.Maximum = 255;
            this.imgBoxBlue.Name = "imgBoxBlue";
            this.imgBoxBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.imgBoxBlue.Size = new System.Drawing.Size(45, 150);
            this.imgBoxBlue.TabIndex = 10;
            this.imgBoxBlue.TabStop = false;
            this.imgBoxBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.imgBoxBlue.Scroll += new System.EventHandler(this.imgBoxBlue_Scroll);
            // 
            // imgBoxGreen
            // 
            this.imgBoxGreen.Location = new System.Drawing.Point(44, 286);
            this.imgBoxGreen.Maximum = 255;
            this.imgBoxGreen.Name = "imgBoxGreen";
            this.imgBoxGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.imgBoxGreen.Size = new System.Drawing.Size(45, 150);
            this.imgBoxGreen.TabIndex = 9;
            this.imgBoxGreen.TabStop = false;
            this.imgBoxGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.imgBoxGreen.Scroll += new System.EventHandler(this.imgBoxGreen_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "R         G         B";
            // 
            // imgBoxRed
            // 
            this.imgBoxRed.Location = new System.Drawing.Point(14, 286);
            this.imgBoxRed.Maximum = 255;
            this.imgBoxRed.Name = "imgBoxRed";
            this.imgBoxRed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.imgBoxRed.Size = new System.Drawing.Size(45, 150);
            this.imgBoxRed.TabIndex = 7;
            this.imgBoxRed.TabStop = false;
            this.imgBoxRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.imgBoxRed.Scroll += new System.EventHandler(this.imgBoxRed_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imgBoxBlue);
            this.Controls.Add(this.imgBoxGreen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imgBoxRed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.colorBarBlue);
            this.Controls.Add(this.colorBarGreen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorBarRed);
            this.Controls.Add(this.browseButton);
            this.Name = "Form1";
            this.Text = "Image Color Changer - by Raket | Lucy Drachenstein";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colorBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        public System.Windows.Forms.TrackBar colorBarRed;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TrackBar colorBarGreen;
        public System.Windows.Forms.TrackBar colorBarBlue;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TrackBar imgBoxBlue;
        public System.Windows.Forms.TrackBar imgBoxGreen;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TrackBar imgBoxRed;
    }
}

