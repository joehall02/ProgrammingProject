namespace programmingproject
{
    partial class Settings
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
            this.cbTheme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAudio = new System.Windows.Forms.CheckBox();
            this.settingsDino = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsDino)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTheme
            // 
            this.cbTheme.FormattingEnabled = true;
            this.cbTheme.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.cbTheme.Location = new System.Drawing.Point(313, 77);
            this.cbTheme.Name = "cbTheme";
            this.cbTheme.Size = new System.Drawing.Size(121, 23);
            this.cbTheme.TabIndex = 0;
            this.cbTheme.SelectedIndexChanged += new System.EventHandler(this.cbTheme_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Theme";
            // 
            // cbAudio
            // 
            this.cbAudio.AutoSize = true;
            this.cbAudio.Checked = true;
            this.cbAudio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAudio.Location = new System.Drawing.Point(152, 132);
            this.cbAudio.Name = "cbAudio";
            this.cbAudio.Size = new System.Drawing.Size(58, 19);
            this.cbAudio.TabIndex = 3;
            this.cbAudio.Text = "Audio";
            this.cbAudio.UseVisualStyleBackColor = true;
            this.cbAudio.CheckedChanged += new System.EventHandler(this.cbAudio_CheckedChanged);
            // 
            // settingsDino
            // 
            this.settingsDino.BackColor = System.Drawing.Color.Transparent;
            this.settingsDino.Image = global::programmingproject.Properties.Resources.dino;
            this.settingsDino.Location = new System.Drawing.Point(17, 411);
            this.settingsDino.Name = "settingsDino";
            this.settingsDino.Size = new System.Drawing.Size(70, 100);
            this.settingsDino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingsDino.TabIndex = 4;
            this.settingsDino.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Difficulty";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(313, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 6;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 523);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.settingsDino);
            this.Controls.Add(this.cbAudio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTheme);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.settingsDino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbTheme;
        private Label label1;
        private CheckBox cbAudio;
        private PictureBox settingsDino;
        private Label label2;
        private ComboBox comboBox1;
    }
}