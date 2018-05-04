namespace GuessTheNumber
{
    partial class MainForm
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
            this.comboBoxLevels = new System.Windows.Forms.ComboBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tbChoose = new System.Windows.Forms.TextBox();
            this.lblUpOrDown = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblGuess = new System.Windows.Forms.Label();
            this.lblRandom = new System.Windows.Forms.Label();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.pbUpOrDown = new System.Windows.Forms.PictureBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.lblTries = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpOrDown)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxLevels
            // 
            this.comboBoxLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLevels.FormattingEnabled = true;
            this.comboBoxLevels.Items.AddRange(new object[] {
            "1-10",
            "1-50",
            "1-100",
            "1-1000"});
            this.comboBoxLevels.Location = new System.Drawing.Point(52, 56);
            this.comboBoxLevels.Name = "comboBoxLevels";
            this.comboBoxLevels.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLevels.TabIndex = 0;
            this.comboBoxLevels.SelectedIndexChanged += new System.EventHandler(this.comboBoxLevels_SelectedIndexChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(286, 41);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(94, 48);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // tbChoose
            // 
            this.tbChoose.Location = new System.Drawing.Point(64, 214);
            this.tbChoose.Name = "tbChoose";
            this.tbChoose.Size = new System.Drawing.Size(100, 20);
            this.tbChoose.TabIndex = 2;
            // 
            // lblUpOrDown
            // 
            this.lblUpOrDown.AutoSize = true;
            this.lblUpOrDown.Location = new System.Drawing.Point(223, 317);
            this.lblUpOrDown.Name = "lblUpOrDown";
            this.lblUpOrDown.Size = new System.Drawing.Size(64, 13);
            this.lblUpOrDown.TabIndex = 4;
            this.lblUpOrDown.Text = "Up or Down";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(385, 355);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(58, 13);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result Box";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(73, 26);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(78, 13);
            this.lblLevel.TabIndex = 7;
            this.lblLevel.Text = "Choose Level !";
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Location = new System.Drawing.Point(49, 169);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(144, 13);
            this.lblGuess.TabIndex = 8;
            this.lblGuess.Text = "Guess the Random Number !";
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Location = new System.Drawing.Point(100, 98);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(0, 13);
            this.lblRandom.TabIndex = 10;
            this.lblRandom.Visible = false;
            // 
            // pbResult
            // 
            this.pbResult.Location = new System.Drawing.Point(345, 205);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(118, 125);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResult.TabIndex = 5;
            this.pbResult.TabStop = false;
            // 
            // pbUpOrDown
            // 
            this.pbUpOrDown.Location = new System.Drawing.Point(202, 205);
            this.pbUpOrDown.Name = "pbUpOrDown";
            this.pbUpOrDown.Size = new System.Drawing.Size(91, 82);
            this.pbUpOrDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUpOrDown.TabIndex = 3;
            this.pbUpOrDown.TabStop = false;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(89, 307);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 11;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // lblTries
            // 
            this.lblTries.AutoSize = true;
            this.lblTries.Location = new System.Drawing.Point(100, 252);
            this.lblTries.Name = "lblTries";
            this.lblTries.Size = new System.Drawing.Size(0, 13);
            this.lblTries.TabIndex = 12;
            this.lblTries.Click += new System.EventHandler(this.lblTries_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 440);
            this.Controls.Add(this.lblTries);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.lblRandom);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.pbResult);
            this.Controls.Add(this.lblUpOrDown);
            this.Controls.Add(this.pbUpOrDown);
            this.Controls.Add(this.tbChoose);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.comboBoxLevels);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpOrDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLevels;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox tbChoose;
        private System.Windows.Forms.PictureBox pbUpOrDown;
        private System.Windows.Forms.Label lblUpOrDown;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label lblTries;
    }
}

