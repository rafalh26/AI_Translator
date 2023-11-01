namespace AI_Translator
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.fromLanguageList = new System.Windows.Forms.ComboBox();
            this.toLanguageList = new System.Windows.Forms.ComboBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.saveTextToFileButtonLeft = new System.Windows.Forms.Button();
            this.saveTextToFileButtonRight = new System.Windows.Forms.Button();
            this.translateButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fromLanguageList
            // 
            this.fromLanguageList.FormattingEnabled = true;
            this.fromLanguageList.Items.AddRange(new object[] {
            "Polish",
            "English",
            "French",
            "Russian",
            "German",
            "Dutch"});
            this.fromLanguageList.Location = new System.Drawing.Point(523, 69);
            this.fromLanguageList.Name = "fromLanguageList";
            this.fromLanguageList.Size = new System.Drawing.Size(121, 21);
            this.fromLanguageList.TabIndex = 0;
            // 
            // toLanguageList
            // 
            this.toLanguageList.FormattingEnabled = true;
            this.toLanguageList.Items.AddRange(new object[] {
            "Polish",
            "English",
            "French",
            "Russian",
            "German",
            "Dutch"});
            this.toLanguageList.Location = new System.Drawing.Point(858, 69);
            this.toLanguageList.Name = "toLanguageList";
            this.toLanguageList.Size = new System.Drawing.Size(121, 21);
            this.toLanguageList.TabIndex = 0;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(148, 90);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(496, 427);
            this.inputBox.TabIndex = 1;
            // 
            // saveTextToFileButtonLeft
            // 
            this.saveTextToFileButtonLeft.Location = new System.Drawing.Point(148, 62);
            this.saveTextToFileButtonLeft.Name = "saveTextToFileButtonLeft";
            this.saveTextToFileButtonLeft.Size = new System.Drawing.Size(217, 29);
            this.saveTextToFileButtonLeft.TabIndex = 2;
            this.saveTextToFileButtonLeft.Text = "Save Text";
            this.saveTextToFileButtonLeft.UseVisualStyleBackColor = true;
            this.saveTextToFileButtonLeft.Click += new System.EventHandler(this.saveTextToFileButtonLeft_Click);
            // 
            // saveTextToFileButtonRight
            // 
            this.saveTextToFileButtonRight.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.saveTextToFileButtonRight.Location = new System.Drawing.Point(1209, 90);
            this.saveTextToFileButtonRight.Name = "saveTextToFileButtonRight";
            this.saveTextToFileButtonRight.Size = new System.Drawing.Size(173, 78);
            this.saveTextToFileButtonRight.TabIndex = 2;
            this.saveTextToFileButtonRight.Text = "Save Translation";
            this.saveTextToFileButtonRight.UseVisualStyleBackColor = false;
            this.saveTextToFileButtonRight.Click += new System.EventHandler(this.saveTextToFileButtonRight_Click);
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(723, 119);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(75, 197);
            this.translateButton.TabIndex = 2;
            this.translateButton.Text = "Translate";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(858, 90);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(354, 427);
            this.outputBox.TabIndex = 1;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text File|*.txt|All Files|*.*";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.Filter = "Text File|*.txt|All Files|*.*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::AI_Translator.Properties.Resources._1054973_speaker_audio_volume_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(708, 442);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::AI_Translator.Properties.Resources._99809_on_screen_keyboard_icon1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(692, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 67);
            this.button1.TabIndex = 5;
            this.button1.Text = "keyboard";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // mainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::AI_Translator.Properties.Resources.EmptyBook;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1381, 580);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.saveTextToFileButtonRight);
            this.Controls.Add(this.saveTextToFileButtonLeft);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.toLanguageList);
            this.Controls.Add(this.fromLanguageList);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translation Fun";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fromLanguageList;
        private System.Windows.Forms.ComboBox toLanguageList;
        private System.Windows.Forms.Button saveTextToFileButtonLeft;
        private System.Windows.Forms.Button saveTextToFileButtonRight;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox inputBox;
        public System.Windows.Forms.Button translateButton;
    }
}

