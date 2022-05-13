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
using Facebook;

namespace Do_an_CK
{
    public partial class menu : Form
    {
        Game game1;
        game_2 game2;
        game_3 game3;
        home home1;
        string img;

        public menu(Game f, home f1)
        {
            InitializeComponent();
            game1 = f;
            home1 = f1;
        }

        public menu(game_2 f, home f1)
        {
            InitializeComponent();
            game2 = f;
            home1 = f1;
        }

        public menu(game_3 f, home f1)
        {
            InitializeComponent();
            game3 = f;
            home1 = f1;
        }

        public void Save_screen(Form frm)
        {
            string ImagePath = string.Format("screen_{0}.png", DateTime.Now.Ticks);
            img = ImagePath;
            Bitmap Image = new Bitmap(frm.Width, frm.Height);
            frm.DrawToBitmap(Image, new Rectangle(0, 0, frm.Width, frm.Height));
            Image.Save(ImagePath, System.Drawing.Imaging.ImageFormat.Png);
        }

        string path = "save.txt";

        private void menu_resume_Click(object sender, EventArgs e)
        {
            //Resume timer
            switch (home1.map)
            {
                case 1:
                    game1.music_player.settings.volume = 100;
                    break;
                case 2:
                    game2.music_player.settings.volume = 100;
                    break;
                case 3:
                    game3.music_player.settings.volume = 100;
                    break;
            }

            this.Close();   //Close menu
        }

        private void menu_options_Click(object sender, EventArgs e)
        {
            if (home1.map == 1)
            {
                options op = new options(game1, home1);
                op.Show();
            }
            if (home1.map == 2)
            {
                options op = new options(game2, home1);
                op.Show();
            }
            if (home1.map == 3)
            {
                options op = new options(game3, home1);
                op.Show();
            }
        }

        private void menu_restart_Click(object sender, EventArgs e)
        {            
            this.Close();   //Close menu
        }

        private void menu_save_Click(object sender, EventArgs e)
        {
            File.WriteAllText(path, String.Empty);  //Reset save file
            System.IO.StreamWriter writer = new System.IO.StreamWriter("save.txt");            
            switch (home1.map)
            {
                case 1:
                    writer.Write(game1.player_location.X.ToString() + "\n");
                    writer.Write(game1.player_location.Y.ToString() + "\n");
                    writer.Write(game1.stage.ToString() + "\n");
                    writer.Close();
                    writer.Dispose();
                    break;
                case 2:
                    writer.Write(game2.player_location.X.ToString() + "\n");
                    writer.Write(game2.player_location.Y.ToString() + "\n");
                    writer.Write(game2.stage.ToString() + "\n");
                    writer.Close();
                    writer.Dispose();
                    break;
                case 3:
                    writer.Write(game3.player_location.X.ToString() + "\n");
                    writer.Write(game3.player_location.Y.ToString() + "\n");
                    writer.Write(game3.stage.ToString() + "\n");
                    writer.Close();
                    writer.Dispose();
                    break;
            }            
            home1.Show();
            this.Close();   //Close menu
        }

        private void menu_give_up_Click(object sender, EventArgs e)
        {
            switch (home1.map)
            {
                case 1:
                    game1.music_player.controls.stop();
                    this.Close();           //Close menu           
                    game1.Close();          //Close game
                    home1.Show();           //Open home
                    break;
                case 2:
                    game2.music_player.controls.stop();
                    this.Close();           //Close menu           
                    game2.Close();          //Close game
                    home1.Show();           //Open home
                    break;
                case 3:
                    game3.music_player.controls.stop();
                    this.Close();           //Close menu           
                    game3.Close();          //Close game
                    home1.Show();           //Open home
                    break;
            }                      
        }

        private const string AppId = "873909356604915";
        private const string ExtendedPermissions = "user_about_me,publish_stream";

        private void menu_share_Click(object sender, EventArgs e)
        {
            Save_screen(game1);

            var fb = new FacebookClient("EAAMa0ODELfMBALsXhdyaping0T8DGMRPkjGwc1Qj3Xr0ZBvC7yh47MK8TefoeSzonuT026strQZBhBfZAiVgXuGonSAbP2YZBtkq7ELXYZBRqFmVW0UGOyKUH3cXjX1BpQGcDGFnZBa83EvnKjoM1MA2xPfawJiMmJjV2RGuZCkCKWrQ17QdiAdzWrBO4CVRrcZD");

            var img1 = File.OpenRead(img);

            dynamic res = fb.Post("me/photos", new
            {
                message = "",
                file = new FacebookMediaStream
                {
                    ContentType = "image/jpg",
                    FileName = Path.GetFileName(img)

                }.SetValue(img1)
                
            });
        }

        
    }
}
