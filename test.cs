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
    public partial class test : Form
    {
        List<PictureBox> platforms = new List<PictureBox>();

        //Movement variables
        bool goleft, goright, airleft, airright, jumping, hold, grounded;
        int move_spd = 5;
        int bounce_spd = 2;
        int gravity = 10; //Falling speed
        int force = 0; //Force of the jump
        int screen_spd = 5; //Screen speed when sidescrolling
        int collide;
        int _tick = 0;
        int temp;
        bool hit;

        //Record variables
        int jumps = 0; //Count the jumps
        int stage; //Show the stage the player is at

        public test()
        {
            InitializeComponent();
        }

        private void game_Load(object sender, EventArgs e)
        {
            foreach (PictureBox x in this.Controls)
            {
                if (x is PictureBox)
                {                 
                    if (x.Tag == "platform")
                    {
                        platforms.Add(x);
                    }
                }               
            }

            //MessageBox.Show(platforms.Count.ToString(), " ");
        }

        //Collision
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

        //Main time events
        private void MainTimeEvents(object sender, EventArgs e)
        {
            player.Top += gravity; //Player is affected by gravity (will keep falling until hit platform)
            _tick += 1;
            //player.Refresh();   

            //Move left and right
            if (goleft == true && player.Left - 1 >= 0 && grounded) { player.Left -= move_spd; }
            if (goright == true && player.Left + player.Width <= this.Width && grounded) { player.Left += move_spd; }

            //Direction of the jump


            //If force > 0 -> jumping = true           
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
                //gravity += 50;
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

            //Collision
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
            
        }

        //Key events
        private void key_is_dowm(object sender, KeyEventArgs e)
        {
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

        private void key_is_up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { goleft = false; }
            if (e.KeyCode == Keys.Right) { goright = false; }
            if (e.KeyCode == Keys.Up && hold)
            {
                jumping = true;
                jumps += 1;
                hold = false;
                int res = _tick - temp;
                if (res > 100)
                {
                    res = 100;
                }
                force = res/2;
                Console.WriteLine("Force = " + force.ToString());
            }
        }
    }
}
