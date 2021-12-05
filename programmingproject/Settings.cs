using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programmingproject
{
    public partial class Settings : Form
    {

        Main main = new Main();
        public Settings()
        {
            InitializeComponent();
        }

        private void cbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTheme.SelectedIndex == 0)
            {
                Owner.BackgroundImage = new Bitmap("background_light.png");
            }
            if (cbTheme.SelectedIndex == 1)
            {
                Owner.BackgroundImage = new Bitmap("background_dark.png");
            }
        }

        private void cbAudio_CheckedChanged(object sender, EventArgs e)
        {

            if (cbAudio.Checked == true)
            {
                main.audio = true;
            }
            if (cbAudio.Checked == false)
            {
                main.audio = false;
            }
        }
    }
}
