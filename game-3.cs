using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Do_an_CK
{
    public partial class game_3 : Form
    {
        home home1;

        public game_3(home f)
        {
            InitializeComponent();
            home1 = f;
        }

        WindowsMediaPlayer music = new WindowsMediaPlayer();                        //BG music
        public System.Media.SoundPlayer sound = new System.Media.SoundPlayer();     //Sfx

        List<PictureBox> platforms = new List<PictureBox>();                        //Save platforms
        List<int> stage_scores = new List<int>();

        bool goleft, goright, airleft, airright, jumping, hold, grounded;
        int move_spd = 5;
        int bounce_spd = 2;
        int gravity = 10;
        int force = 0;
        int collide;
        int _tick = 0;
        int temp;
        bool hit;
        bool pause;
        bool stage_up;
        bool stage_down;
        int last_stage;
        public int scores;
        public int stage;

        //Player location
        public Point player_location
        {
            get { return player.Location; }
            set { player.Location = value; }
        }

        //Music player
        public WindowsMediaPlayer music_player
        {
            get { return music; }
        }

        private void game_3_Load(object sender, EventArgs e)
        {
            music.URL = "bensound-ofeliasdream.mp3";
            music.settings.volume = 50;
            music.controls.play();

            stage_scores.Add(0);
            stage_scores.Add(10);
            stage_scores.Add(20);
            stage_scores.Add(30);
            stage_scores.Add(40);
            stage_scores.Add(50);
            stage_scores.Add(0);
            scores = 0;

            foreach (PictureBox x in this.Controls.OfType<PictureBox>())
            {
                if (x.Tag == "platform")
                {
                    platforms.Add(x);
                }
            }

            if (home1.con)
            {
                string[] lines = System.IO.File.ReadAllLines("save.txt");

                int plx = Convert.ToInt32(lines[0]);    //Player location X
                int ply = Convert.ToInt32(lines[1]);    //Player location Y
                int stg = Convert.ToInt32(lines[2]);    //Stage

                int m = (6 - stg) * 700;                //Calculate map and platforms positions

                bg.Top -= m;
                player.Location = new Point(plx, ply);
                stage = stg;

                foreach (PictureBox x in platforms)
                {
                    x.Top -= m;
                }
            }
            else
            {
                int st = home1.stage;
                int m = 4200 - st * 700;
                bg.Top -= m;
                stage = st;
                foreach (PictureBox x in platforms)
                {
                    x.Top -= m;
                }

                for (int i = 1; i < st; i++)
                {
                    stage_scores[i] = 0;
                    Console.WriteLine(stage_scores[i]);
                }

                switch (st)
                {
                    case 1:
                        player.Top = 700 - 200;
                        player.Left = 450;
                        break;
                    case 2:
                        player.Top = 700 - 200;
                        player.Left = 135;
                        break;
                    case 3:
                        player.Top = 700 - 200;
                        player.Left = 565;
                        break;
                    case 4:
                        player.Top = 700 - 150;
                        player.Left = 842;
                        break;
                    case 5:
                        player.Top = 700 - 300;
                        player.Left = 20;
                        break;
                    case 6:
                        player.Top = 700 - 200;
                        player.Left = 430;
                        break;
                }

                int ch = home1.char_s;
                switch (ch)
                {
                    case 1:
                        player.BackgroundImage = Image.FromFile("char-1.png");
                        break;
                    case 2:
                        player.BackgroundImage = Image.FromFile("char-2.png");
                        break;
                    case 3:
                        player.BackgroundImage = Image.FromFile("char-3.png");
                        break;
                }
            }
        }

        private void game_3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                //Pause the timer
                music.settings.volume = 20;         //Lower music volume
                menu f = new menu(this, home1);     //Open game menu
                f.Show();
            }

            if (e.KeyCode == Keys.Left && !hold) { goleft = true; }
            if (e.KeyCode == Keys.Left && hold) { airleft = true; }
            if (e.KeyCode == Keys.Right && !hold) { goright = true; }
            if (e.KeyCode == Keys.Right && hold) { airright = true; }
            if (e.KeyCode == Keys.Up && !jumping && !hold)
            {
                goleft = false;
                goright = false;

                hold = true;
                temp = _tick;
            }
        }

        private void game_3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { goleft = false; }
            if (e.KeyCode == Keys.Right) { goright = false; }
            if (e.KeyCode == Keys.Up && hold)
            {
                jumping = true;
                sound.SoundLocation = "Jump_005.wav";
                if (!home1.mute)
                { sound.Play(); }
                //jumps += 1;
                hold = false;
                int res = _tick - temp;
                if (res > 100)
                {
                    res = 100;
                }
                force = res / 2;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (stage == 6 && grounded)
            {
                Timer.Stop();
                music.URL = "bensound-birthofahero.mp3";
                music.controls.play();
            }

            player.Top += gravity; //Player is affected by gravity (will keep falling until hit platform)
            _tick += 1;

            //Move left and right
            if (goleft == true && player.Left - 1 >= 0 && grounded) { player.Left -= move_spd; }
            if (goright == true && player.Left + player.Width <= this.Width && grounded) { player.Left += move_spd; }

            //Direction of the jump       
            if (jumping)
            {
                grounded = false;

                if (airleft)
                {
                    player.Left -= move_spd;
                }
                if (airright)
                {
                    player.Left += move_spd;
                }
                player.Top -= force;
                force--;
            }

            //If force = 0 -> jumping = false 
            if (jumping && force < 0)
            {
                jumping = false;
            }

            if (!grounded)
            {
                if (hit)
                {
                    if (airleft)
                    {
                        player.Left -= bounce_spd;

                    }
                    if (airright)
                    {
                        player.Left += bounce_spd;

                    }
                }
                else
                {
                    if (airleft)
                    {
                        player.Left -= 5;
                    }
                    if (airright)
                    {
                        player.Left += 5;
                    }
                }
            }

            //In-game detection
            if (Collision_detect(player))
            {
                if (Bottom_collision(player, platforms[collide]))
                {
                    player.Top = platforms[collide].Top - player.Height;
                    grounded = true;
                    airleft = false;
                    airright = false;
                    gravity = 0;
                    hit = false;
                }

                if (Top_collision(player, platforms[collide]))
                {
                    player.Top = platforms[collide].Bottom;
                    force = 0;
                }

                if (Left_collision(player, platforms[collide]))
                {
                    if (airleft)
                    {
                        hit = true;
                        airleft = false;
                        airright = true;
                    }
                    player.Left = platforms[collide].Left + platforms[collide].Width;
                    goleft = false;
                }

                if (Right_collision(player, platforms[collide]))
                {
                    if (airright)
                    {
                        hit = true;
                        airright = false;
                        airleft = true;
                    }
                    player.Left = platforms[collide].Left - player.Width;
                    goright = false;
                }
            }
            else { gravity = 10; bounce_spd = 5; }

            Stage_changed(stage);

            if (stage_up && grounded)
            {
                scores += stage_scores[last_stage];
                stage_scores[last_stage] = 0;
                score.Text = scores == 0 ? "00" : scores.ToString();
                stage_up = false;
            }
        }

        //Collision detection
        public Boolean Collision_detect(PictureBox box)
        {
            foreach (PictureBox x in platforms)
            {
                if (box.Bounds.IntersectsWith(x.Bounds))
                {
                    collide = platforms.IndexOf(x);
                    return true;
                }

            }
            return false;
        }

        public Boolean Top_collision(PictureBox p, PictureBox plat)
        {
            PictureBox temp_box = new PictureBox();
            temp_box.Bounds = plat.Bounds;
            temp_box.SetBounds(temp_box.Location.X + 1, temp_box.Location.Y + temp_box.Height, temp_box.Width - 2, 1);
            if (p.Bounds.IntersectsWith(temp_box.Bounds))
            {
                return true;
            }
            return false;
        }

        public Boolean Bottom_collision(PictureBox p, PictureBox plat)
        {
            PictureBox temp_box = new PictureBox();
            temp_box.Bounds = plat.Bounds;
            temp_box.SetBounds(temp_box.Location.X + 1, temp_box.Location.Y - 1, temp_box.Width - 2, 1);
            if (p.Bounds.IntersectsWith(temp_box.Bounds))
            {
                return true;
            }
            return false;
        }

        public Boolean Left_collision(PictureBox p, PictureBox plat)
        {
            PictureBox temp_box = new PictureBox();
            temp_box.Bounds = plat.Bounds;
            temp_box.SetBounds(temp_box.Location.X + temp_box.Width, temp_box.Location.Y, 1, temp_box.Height);
            if (p.Bounds.IntersectsWith(temp_box.Bounds))
            {
                return true;
            }
            return false;
        }

        public Boolean Right_collision(PictureBox p, PictureBox plat)
        {
            PictureBox temp_box = new PictureBox();
            temp_box.Bounds = plat.Bounds;
            temp_box.SetBounds(temp_box.Location.X - 1, temp_box.Location.Y, 1, temp_box.Height);
            if (p.Bounds.IntersectsWith(temp_box.Bounds))
            {
                return true;
            }
            return false;
        }

        public void Stage_changed(int st)
        {
            if (st == 1)
            {
                if (player.Top < 0)
                {
                    bg.Top += 700;
                    foreach (PictureBox x in platforms)
                    {
                        x.Top += 700;
                    }
                    stage = st + 1;
                    last_stage = st;
                    stage_up = true;
                    stage_down = false;
                    player.Top = 700 - 1;
                }
                return;
            }

            if (st == 6)
            {
                if (player.Top > 700)
                {
                    bg.Top -= 700;
                    foreach (PictureBox x in platforms)
                    {
                        x.Top -= 700;
                    }
                    stage = st - 1;
                    last_stage = st;
                    stage_down = true;
                    stage_up = false;
                    player.Top = 1;
                }
                return;
            }

            if (player.Top < 0)
            {
                bg.Top += 700;
                foreach (PictureBox x in platforms)
                {
                    x.Top += 700;
                }
                stage = st + 1;
                last_stage = st;
                stage_up = true;
                stage_down = false;
                player.Top = 700 - 1;
            }

            if (player.Top > 700)
            {
                bg.Top -= 700;
                foreach (PictureBox x in platforms)
                {
                    x.Top -= 700;
                }
                stage = st - 1;
                last_stage = st;
                stage_down = true;
                stage_up = false;
                player.Top = 1;
            }
        }
    }
}
