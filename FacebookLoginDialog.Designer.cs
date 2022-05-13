namespace Do_an_CK
{
    partial class FacebookLoginDialog
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
            this.fb_01 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // fb_01
            // 
            this.fb_01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fb_01.Location = new System.Drawing.Point(0, 0);
            this.fb_01.MinimumSize = new System.Drawing.Size(20, 20);
            this.fb_01.Name = "fb_01";
            this.fb_01.Size = new System.Drawing.Size(800, 450);
            this.fb_01.TabIndex = 0;
            //this.fb_01.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.fb_01_DocumentCompleted);
            // 
            // fb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fb_01);
            this.Name = "fb";
            this.Text = "fb";
            //this.Load += new System.EventHandler(this.fb_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser fb_01;
    }
}