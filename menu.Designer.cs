namespace Do_an_CK
{
    partial class menu
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
            this.menu_resume = new System.Windows.Forms.Button();
            this.menu_options = new System.Windows.Forms.Button();
            this.menu_restart = new System.Windows.Forms.Button();
            this.menu_save = new System.Windows.Forms.Button();
            this.menu_give_up = new System.Windows.Forms.Button();
            this.menu_share = new System.Windows.Forms.Button();
            this.fb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fb)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_resume
            // 
            this.menu_resume.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.menu_resume.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_resume.ForeColor = System.Drawing.Color.White;
            this.menu_resume.Location = new System.Drawing.Point(12, 12);
            this.menu_resume.Name = "menu_resume";
            this.menu_resume.Size = new System.Drawing.Size(367, 63);
            this.menu_resume.TabIndex = 1;
            this.menu_resume.Text = "Resume";
            this.menu_resume.UseVisualStyleBackColor = false;
            this.menu_resume.Click += new System.EventHandler(this.menu_resume_Click);
            // 
            // menu_options
            // 
            this.menu_options.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.menu_options.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_options.ForeColor = System.Drawing.Color.White;
            this.menu_options.Location = new System.Drawing.Point(12, 81);
            this.menu_options.Name = "menu_options";
            this.menu_options.Size = new System.Drawing.Size(367, 63);
            this.menu_options.TabIndex = 2;
            this.menu_options.Text = "Options";
            this.menu_options.UseVisualStyleBackColor = false;
            this.menu_options.Click += new System.EventHandler(this.menu_options_Click);
            // 
            // menu_restart
            // 
            this.menu_restart.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.menu_restart.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_restart.ForeColor = System.Drawing.Color.White;
            this.menu_restart.Location = new System.Drawing.Point(12, 150);
            this.menu_restart.Name = "menu_restart";
            this.menu_restart.Size = new System.Drawing.Size(367, 63);
            this.menu_restart.TabIndex = 3;
            this.menu_restart.Text = "Restart";
            this.menu_restart.UseVisualStyleBackColor = false;
            this.menu_restart.Click += new System.EventHandler(this.menu_restart_Click);
            // 
            // menu_save
            // 
            this.menu_save.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.menu_save.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_save.ForeColor = System.Drawing.Color.White;
            this.menu_save.Location = new System.Drawing.Point(12, 219);
            this.menu_save.Name = "menu_save";
            this.menu_save.Size = new System.Drawing.Size(367, 63);
            this.menu_save.TabIndex = 4;
            this.menu_save.Text = "Save and Exit";
            this.menu_save.UseVisualStyleBackColor = false;
            this.menu_save.Click += new System.EventHandler(this.menu_save_Click);
            // 
            // menu_give_up
            // 
            this.menu_give_up.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.menu_give_up.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_give_up.ForeColor = System.Drawing.Color.White;
            this.menu_give_up.Location = new System.Drawing.Point(11, 357);
            this.menu_give_up.Name = "menu_give_up";
            this.menu_give_up.Size = new System.Drawing.Size(367, 63);
            this.menu_give_up.TabIndex = 5;
            this.menu_give_up.Text = "Give up";
            this.menu_give_up.UseVisualStyleBackColor = false;
            this.menu_give_up.Click += new System.EventHandler(this.menu_give_up_Click);
            // 
            // menu_share
            // 
            this.menu_share.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.menu_share.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_share.ForeColor = System.Drawing.Color.White;
            this.menu_share.Location = new System.Drawing.Point(11, 288);
            this.menu_share.Name = "menu_share";
            this.menu_share.Size = new System.Drawing.Size(367, 63);
            this.menu_share.TabIndex = 6;
            this.menu_share.Text = "Share on facebook";
            this.menu_share.UseVisualStyleBackColor = false;
            this.menu_share.Click += new System.EventHandler(this.menu_share_Click);
            // 
            // fb
            // 
            this.fb.BackColor = System.Drawing.Color.Transparent;
            this.fb.BackgroundImage = global::Do_an_CK.Properties.Resources.facebook;
            this.fb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fb.Location = new System.Drawing.Point(297, 298);
            this.fb.Name = "fb";
            this.fb.Size = new System.Drawing.Size(40, 40);
            this.fb.TabIndex = 7;
            this.fb.TabStop = false;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 435);
            this.Controls.Add(this.fb);
            this.Controls.Add(this.menu_share);
            this.Controls.Add(this.menu_give_up);
            this.Controls.Add(this.menu_save);
            this.Controls.Add(this.menu_restart);
            this.Controls.Add(this.menu_options);
            this.Controls.Add(this.menu_resume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            ((System.ComponentModel.ISupportInitialize)(this.fb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menu_resume;
        private System.Windows.Forms.Button menu_options;
        private System.Windows.Forms.Button menu_restart;
        private System.Windows.Forms.Button menu_save;
        private System.Windows.Forms.Button menu_give_up;
        private System.Windows.Forms.Button menu_share;
        private System.Windows.Forms.PictureBox fb;
    }
}