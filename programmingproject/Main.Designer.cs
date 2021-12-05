namespace programmingproject
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.pbFloor = new System.Windows.Forms.PictureBox();
            this.lbScore = new System.Windows.Forms.Label();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbCactus1 = new System.Windows.Forms.PictureBox();
            this.pbCactus2 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lbHighscore = new System.Windows.Forms.Label();
            this.pbSettings = new System.Windows.Forms.PictureBox();
            this.pbCloud1 = new System.Windows.Forms.PictureBox();
            this.pbCloud2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCactus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCactus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFloor
            // 
            this.pbFloor.BackColor = System.Drawing.Color.PeachPuff;
            this.pbFloor.Location = new System.Drawing.Point(-7, 417);
            this.pbFloor.Name = "pbFloor";
            this.pbFloor.Size = new System.Drawing.Size(809, 88);
            this.pbFloor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFloor.TabIndex = 0;
            this.pbFloor.TabStop = false;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.Transparent;
            this.lbScore.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScore.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbScore.Location = new System.Drawing.Point(12, 9);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(94, 24);
            this.lbScore.TabIndex = 1;
            this.lbScore.Text = "Score: 0";
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer.Image = global::programmingproject.Properties.Resources.dino;
            this.pbPlayer.Location = new System.Drawing.Point(36, 317);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(70, 100);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer.TabIndex = 2;
            this.pbPlayer.TabStop = false;
            // 
            // pbCactus1
            // 
            this.pbCactus1.BackColor = System.Drawing.Color.Transparent;
            this.pbCactus1.Image = global::programmingproject.Properties.Resources.cactus_large;
            this.pbCactus1.Location = new System.Drawing.Point(521, 317);
            this.pbCactus1.Name = "pbCactus1";
            this.pbCactus1.Size = new System.Drawing.Size(50, 100);
            this.pbCactus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCactus1.TabIndex = 3;
            this.pbCactus1.TabStop = false;
            // 
            // pbCactus2
            // 
            this.pbCactus2.BackColor = System.Drawing.Color.Transparent;
            this.pbCactus2.Image = global::programmingproject.Properties.Resources.cactus_large;
            this.pbCactus2.Location = new System.Drawing.Point(647, 317);
            this.pbCactus2.Name = "pbCactus2";
            this.pbCactus2.Size = new System.Drawing.Size(50, 100);
            this.pbCactus2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCactus2.TabIndex = 4;
            this.pbCactus2.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.Timer);
            // 
            // lbHighscore
            // 
            this.lbHighscore.AutoSize = true;
            this.lbHighscore.BackColor = System.Drawing.Color.Transparent;
            this.lbHighscore.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHighscore.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbHighscore.Location = new System.Drawing.Point(325, 9);
            this.lbHighscore.Name = "lbHighscore";
            this.lbHighscore.Size = new System.Drawing.Size(144, 24);
            this.lbHighscore.TabIndex = 5;
            this.lbHighscore.Text = "Highscore: 0";
            // 
            // pbSettings
            // 
            this.pbSettings.BackColor = System.Drawing.Color.Transparent;
            this.pbSettings.Image = global::programmingproject.Properties.Resources.settings_icon2;
            this.pbSettings.Location = new System.Drawing.Point(742, 3);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(45, 38);
            this.pbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSettings.TabIndex = 6;
            this.pbSettings.TabStop = false;
            this.pbSettings.Click += new System.EventHandler(this.pbSettings_Click);
            // 
            // pbCloud1
            // 
            this.pbCloud1.BackColor = System.Drawing.Color.Transparent;
            this.pbCloud1.Image = global::programmingproject.Properties.Resources.cloud1;
            this.pbCloud1.Location = new System.Drawing.Point(103, 74);
            this.pbCloud1.Name = "pbCloud1";
            this.pbCloud1.Size = new System.Drawing.Size(130, 68);
            this.pbCloud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCloud1.TabIndex = 7;
            this.pbCloud1.TabStop = false;
            // 
            // pbCloud2
            // 
            this.pbCloud2.BackColor = System.Drawing.Color.Transparent;
            this.pbCloud2.Image = global::programmingproject.Properties.Resources.cloud1;
            this.pbCloud2.Location = new System.Drawing.Point(521, 74);
            this.pbCloud2.Name = "pbCloud2";
            this.pbCloud2.Size = new System.Drawing.Size(130, 68);
            this.pbCloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCloud2.TabIndex = 8;
            this.pbCloud2.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::programmingproject.Properties.Resources.background_light;
            this.ClientSize = new System.Drawing.Size(799, 499);
            this.Controls.Add(this.pbCloud2);
            this.Controls.Add(this.pbCloud1);
            this.Controls.Add(this.pbSettings);
            this.Controls.Add(this.lbHighscore);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pbCactus2);
            this.Controls.Add(this.pbCactus1);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.pbFloor);
            this.Name = "Main";
            this.Text = "Dino Jumper";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpEvent);
            ((System.ComponentModel.ISupportInitialize)(this.pbFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCactus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCactus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbFloor;
        private Label lbScore;
        private PictureBox pbPlayer;
        private PictureBox pbCactus1;
        private PictureBox pbCactus2;
        private System.Windows.Forms.Timer gameTimer;
        private Label lbHighscore;
        private PictureBox pbSettings;
        private PictureBox pbCloud1;
        private PictureBox pbCloud2;
    }
}