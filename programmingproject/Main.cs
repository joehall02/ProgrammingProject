using System.Media;

namespace programmingproject
{
    public partial class Main : Form
    {
        public int score;
        public int cactusSpeed;
        public int cloudSpeed;
        
        public int jumpSpeed;
        public int gravity;
        public int highscore = Int32.Parse(File.ReadAllText("highscore.txt"));
        
        public bool run = false;
        public bool isJumping = false;
        public bool gameOver = false;
        public bool audio = true;

        Random rand = new Random();

        List<string> cactusShapes = new List<string>();

        // loads in sound files
        SoundPlayer jumpSound = new SoundPlayer("jump_sound.wav"); //https://stackoverflow.com/questions/3502311/how-to-play-a-sound-in-c-net
        SoundPlayer gameOverSound = new SoundPlayer("gameover_sound.wav");
 
        public Main()
        {
            InitializeComponent();
            ClientSize = new System.Drawing.Size(800, 500);
            cactusShapes.Add("cactus_small.png");
            cactusShapes.Add("cactus_medium.png");
            cactusShapes.Add("cactus_large.png");
            gameStart();
        }

        private void Timer(object sender, EventArgs e)
        {
            //labels
            lbScore.Text = "Score: " + score;
            lbHighscore.Text = "Highscore: " + highscore;

            // jumping 
            pbPlayer.Top += jumpSpeed;

            if (isJumping == true && gravity < 0)
            {
                isJumping = false;
            }

            if (isJumping == true)
            {
                jumpSpeed = -15;
                gravity -= 1;
            }

            else
            {
                jumpSpeed = 15;
            }

            if (pbPlayer.Top > 314 && isJumping == false)
            {
                if (audio == true)
                {
                    jumpSound.Play();
                }
                gravity = 15;
                pbPlayer.Top = 315;
                jumpSpeed = 0;
            }

            // cactus movement
            pbCactus1.Left -= cactusSpeed;
            pbCactus2.Left -= cactusSpeed;

            if (pbCactus1.Left < -70)
            {
                score += 1;
                cactus1Reset();
            }
            if (pbCactus2.Left < -70)
            {
                score += 1;
                cactus2Reset();
            }

            // cloud movement
         /*   pbCloud1.Left -= cloudSpeed;
            pbCloud2.Left -= cloudSpeed;*/

            if (pbCloud1.Left < -130)
            {
                cloud1Reset();
            }

            if (pbCloud2.Left < -130)
            {
                cloud2Reset();
            }

            // collision
            if (pbPlayer.Right/2 > pbCactus1.Left && pbPlayer.Right/2 < pbCactus1.Right)
            {
                if (pbPlayer.Bottom > pbCactus1.Top)
                {
                    gameEnd();
                }
            }

            if (pbPlayer.Right/2 > pbCactus2.Left && pbPlayer.Right/2 < pbCactus2.Right)
            {
                if (pbPlayer.Bottom > pbCactus2.Top)
                {
                    gameEnd();
                }
            }
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && isJumping == false)
            {
                isJumping = true;
            }

            if (e.KeyCode == Keys.R && gameOver == true)
            {
                gameReset();
            }

            if (e.KeyCode == Keys.Space && run == false)
            {
                run = true;
                gameReset();
            }
         }

        private void KeyUpEvent(object sender, KeyEventArgs e)
        {
            if (isJumping == true)
            {
                isJumping = false;

            }
        }
        private void pbSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Owner = this;
            settings.ShowDialog();
        }

        private void cactus1Reset()
        {
            cactusSpeed += 1;
            pbCactus1.Image = Image.FromFile(cactusShapes[rand.Next(0, 3)]); //https://stackoverflow.com/questions/8860725/cannot-implicitly-convert-type-system-drawing-image-to-system-drawing-bitmap
            pbCactus1.Left = rand.Next(800, 1200);
            pbCactus1.Top = pbFloor.Top - pbCactus1.Height;

        }

        private void cactus2Reset()
        {
            pbCactus2.Image = Image.FromFile(cactusShapes[rand.Next(0, 3)]);
            pbCactus2.Left = rand.Next(1300, 1650);
            pbCactus2.Top = pbFloor.Top - pbCactus2.Height;
        }

        private void cloud1Reset()
        {
            pbCloud1.Left = ClientSize.Width + 130;
        }

        private void cloud2Reset()
        {
            pbCloud2.Left = ClientSize.Width + 130;
        }

        private void gameStart()
        {
            lbHighscore.Text = "Highscore: " + highscore;
            lbScore.Text += "\nPress Space to start!";
            pbSettings.Visible = true;
            gameTimer.Stop();
        }

        private void gameReset()
        {
            score = 0;
            cactusSpeed = 10;
            cloudSpeed = 5;
            gravity = 15;
            pbPlayer.Top = 315;
            pbPlayer.Left = 50;
            pbPlayer.Enabled = true;
            pbSettings.Visible = false;
            gameOver = false;
            gameTimer.Start();
            cactus1Reset();
            cactus2Reset();
        }
        private void gameEnd()
        {
            lbScore.Text += "\nGame Over, Press R to restart!";
            pbPlayer.Enabled = false;
            pbSettings.Visible = true;
            gameOver = true;
            gameTimer.Stop(); //https://stackoverflow.com/questions/4563704/c-sharp-how-do-you-stop-a-timer
            if (audio == true)
            {
                gameOverSound.Play();
            }
            if (score > highscore)
            {
                File.WriteAllText("highscore.txt", score.ToString()); 
            }
        }
    }

}