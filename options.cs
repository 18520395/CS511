using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_CK
{
    public partial class options : Form
    {
        home home1;
        Game game1;
        game_2 game2;
        game_3 game3;

        public options()
        {
            InitializeComponent();
        }

        public options(Game f, home f1)
        {
            InitializeComponent();
            game1 = f;
            home1 = f1;
        }

        public options(game_2 f, home f1)
        {
            InitializeComponent();
            game2 = f;
            home1 = f1;
        }

        public options(game_3 f, home f1)
        {
            InitializeComponent();
            game3 = f;
            home1 = f1;
        }

        private void music_switch_Click(object sender, EventArgs e)
        {
            if (music_switch.Text == "On")
            {
                switch (home1.map)
                {
                    case 1:
                        game1.music_player.controls.pause();
                        break;
                    case 2:
                        game2.music_player.controls.pause();
                        break;
                    case 3:
                        game3.music_player.controls.pause();
                        break;
                }
                
                music_switch.Text = "Off";
            }
            else
            {
                switch (home1.map)
                {
                    case 1:
                        game1.music_player.controls.play();
                        break;
                    case 2:
                        game2.music_player.controls.play();
                        break;
                    case 3:
                        game3.music_player.controls.play();
                        break;
                }
                music_switch.Text = "On";
            }
        }

        private void sfx_switch_Click(object sender, EventArgs e)
        {
            if (sfx_switch.Text == "On")
            {
                home1.mute = true;
                sfx_switch.Text = "Off";
            }
            else
            {
                home1.mute = false;
                sfx_switch.Text = "On";
            }
        }

        private void options_volume_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
