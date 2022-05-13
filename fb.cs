using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Do_an_CK
{
    public partial class fb : Form
    {
        public fb()
        {
            InitializeComponent();
        }

        public string GetAccessTokenFromCode(string AppID, string AppSecret)
        {
            WebClient wc = new WebClient();
            string u2 = "https://graph.facebook.com/oauth/access_token?client_id=" + AppID + "&client_secret=" + AppSecret;
            string access = wc.DownloadString(u2);
            access = access.Substring(access.IndexOf("access_token") + 13);
            if (access.Contains("&"))
            {
                string accesstoken = access.Substring(0, access.IndexOf("&"));
                return accesstoken;
            }

            return access;
        }

        private void fb_Load(object sender, EventArgs e)
        {
            
        }
    }
}
