namespace ADayAtTheRaces
{
    partial class ADayAtTheRacesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADayAtTheRacesForm));
            this.raceTrack = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.BetsButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RaceButton = new System.Windows.Forms.Button();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dog1Pic = new System.Windows.Forms.PictureBox();
            this.dog2Pic = new System.Windows.Forms.PictureBox();
            this.dog3Pic = new System.Windows.Forms.PictureBox();
            this.dog4Pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // raceTrack
            // 
            this.raceTrack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("raceTrack.BackgroundImage")));
            this.raceTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.raceTrack.Location = new System.Drawing.Point(12, 12);
            this.raceTrack.Name = "raceTrack";
            this.raceTrack.Size = new System.Drawing.Size(610, 209);
            this.raceTrack.TabIndex = 0;
            this.raceTrack.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.BetsButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.RaceButton);
            this.groupBox1.Controls.Add(this.alBetLabel);
            this.groupBox1.Controls.Add(this.bobBetLabel);
            this.groupBox1.Controls.Add(this.joeBetLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.alRadioButton);
            this.groupBox1.Controls.Add(this.bobRadioButton);
            this.groupBox1.Controls.Add(this.joeRadioButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(310, 110);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "pounds on dog number";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(130, 110);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // BetsButton
            // 
            this.BetsButton.Location = new System.Drawing.Point(48, 110);
            this.BetsButton.Name = "BetsButton";
            this.BetsButton.Size = new System.Drawing.Size(75, 23);
            this.BetsButton.TabIndex = 10;
            this.BetsButton.Text = "Bets";
            this.BetsButton.UseVisualStyleBackColor = true;
            this.BetsButton.Click += new System.EventHandler(this.BetsButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name";
            // 
            // RaceButton
            // 
            this.RaceButton.Location = new System.Drawing.Point(421, 39);
            this.RaceButton.Name = "RaceButton";
            this.RaceButton.Size = new System.Drawing.Size(159, 59);
            this.RaceButton.TabIndex = 8;
            this.RaceButton.Text = "Race!";
            this.RaceButton.UseVisualStyleBackColor = true;
            this.RaceButton.Click += new System.EventHandler(this.RaceButton_Click);
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.Location = new System.Drawing.Point(227, 87);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(148, 13);
            this.alBetLabel.TabIndex = 7;
            this.alBetLabel.Text = "alBetLabel";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(227, 62);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(148, 15);
            this.bobBetLabel.TabIndex = 6;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(227, 39);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(148, 15);
            this.joeBetLabel.TabIndex = 5;
            this.joeBetLabel.Text = "joeBetLabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minimum Bet";
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(10, 83);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(92, 17);
            this.alRadioButton.TabIndex = 3;
            this.alRadioButton.TabStop = true;
            this.alRadioButton.Text = "alRadioButton";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(10, 60);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(102, 17);
            this.bobRadioButton.TabIndex = 2;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "bobRadioButton";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(10, 37);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.joeRadioButton.Size = new System.Drawing.Size(98, 17);
            this.joeRadioButton.TabIndex = 1;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "joeRadioButton";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum Bet";
            // 
            // dog1Pic
            // 
            this.dog1Pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dog1Pic.BackgroundImage")));
            this.dog1Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dog1Pic.Location = new System.Drawing.Point(24, 21);
            this.dog1Pic.Name = "dog1Pic";
            this.dog1Pic.Size = new System.Drawing.Size(71, 22);
            this.dog1Pic.TabIndex = 2;
            this.dog1Pic.TabStop = false;
            // 
            // dog2Pic
            // 
            this.dog2Pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dog2Pic.BackgroundImage")));
            this.dog2Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dog2Pic.Location = new System.Drawing.Point(24, 66);
            this.dog2Pic.Name = "dog2Pic";
            this.dog2Pic.Size = new System.Drawing.Size(71, 22);
            this.dog2Pic.TabIndex = 3;
            this.dog2Pic.TabStop = false;
            // 
            // dog3Pic
            // 
            this.dog3Pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dog3Pic.BackgroundImage")));
            this.dog3Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dog3Pic.Location = new System.Drawing.Point(24, 123);
            this.dog3Pic.Name = "dog3Pic";
            this.dog3Pic.Size = new System.Drawing.Size(71, 22);
            this.dog3Pic.TabIndex = 4;
            this.dog3Pic.TabStop = false;
            // 
            // dog4Pic
            // 
            this.dog4Pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dog4Pic.BackgroundImage")));
            this.dog4Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dog4Pic.Location = new System.Drawing.Point(24, 175);
            this.dog4Pic.Name = "dog4Pic";
            this.dog4Pic.Size = new System.Drawing.Size(71, 22);
            this.dog4Pic.TabIndex = 5;
            this.dog4Pic.TabStop = false;
            // 
            // ADayAtTheRacesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 401);
            this.Controls.Add(this.dog4Pic);
            this.Controls.Add(this.dog3Pic);
            this.Controls.Add(this.dog2Pic);
            this.Controls.Add(this.dog1Pic);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.raceTrack);
            this.Name = "ADayAtTheRacesForm";
            this.Text = "A Day At The Races";
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox raceTrack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button BetsButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RaceButton;
        private System.Windows.Forms.PictureBox dog1Pic;
        private System.Windows.Forms.PictureBox dog2Pic;
        private System.Windows.Forms.PictureBox dog3Pic;
        private System.Windows.Forms.PictureBox dog4Pic;
    }
}

