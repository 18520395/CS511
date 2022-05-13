using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Do_an_CK
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        public bool con;    //True if continue
        public int map = 1;     //Map selection
        public int stage = 1;   //Stage selection
        public int char_s = 1;  //Character selection
        public bool mute;
        string path;

        private void home_new_game_Click(object sender, EventArgs e)
        {
            con = false;            

            if (map == 1)
            {
                Game f = new Game(this);
                f.AutoScroll = false;
                f.Width = 950;
                f.Show();
            }
            if (map == 2)
            {
                game_2 f = new game_2(this);
                f.AutoScroll = false;
                f.Width = 950;
                f.Show();
            }
            if (map ==3)
            {
                game_3 f = new game_3(this);
                f.AutoScroll = false;
                f.Width = 950;
                f.Show();
            }

            this.Hide();
        }

        private void home_continue_Click(object sender, EventArgs e)
        {
            con = true;
            Game f = new Game(this);
            f.Show();
            this.Hide();
        }

        private void home_options_Click(object sender, EventArgs e)
        {
            options f1 = new options();
            f1.Show();
        }

        private void home_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void home_Load(object sender, EventArgs e)
        {
            if (new FileInfo("save.txt").Length == 0)
            {
                home_continue.Enabled = false;
            }
            else
            {
                home_continue.Enabled = true;
            }
        }

        private void home_map_Click(object sender, EventArgs e)
        {
            switch (map)
            {
                case 1:
                    this.BackgroundImage = Image.FromFile("home-2.png");
                    map = 2;
                    break;
                case 2:
                    this.BackgroundImage = Image.FromFile("home-3.png");
                    map = 3;
                    break;
                case 3:
                    this.BackgroundImage = Image.FromFile("home.PNG");
                    map = 1;
                    break;
            }
        }

        private void home_stage_Click(object sender, EventArgs e)
        {
            switch (stage)
            {
                case 1:
                    stage_pic.BackgroundImage = Image.FromFile("2.png");
                    stage = 2;
                    break;
                case 2:
                    stage_pic.BackgroundImage = Image.FromFile("3.png");
                    stage = 3;
                    break;
                case 3:
                    stage_pic.BackgroundImage = Image.FromFile("4.png");
                    stage = 4;
                    break;
                case 4:
                    stage_pic.BackgroundImage = Image.FromFile("5.png");
                    stage = 5;
                    break;
                case 5:
                    stage_pic.BackgroundImage = Image.FromFile("6.png");
                    stage = 6;
                    break;
                case 6:
                    stage_pic.BackgroundImage = Image.FromFile("1.png");
                    stage = 1;
                    break;
            }
        }

        private void home_char_Click(object sender, EventArgs e)
        {
            switch (char_s)
            {
                case 1:
                    char_pic.BackgroundImage = Image.FromFile("char-2.png");
                    char_s = 2;
                    break;
                case 2:
                    char_pic.BackgroundImage = Image.FromFile("char-3.png");
                    char_s = 3;
                    break;
                case 3:
                    char_pic.BackgroundImage = Image.FromFile("char-1.png");
                    char_s = 1;
                    break;
            }
        }
    }
}
