namespace Do_an_CK
{
    partial class options
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
            this.options_volume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.music_switch = new System.Windows.Forms.Button();
            this.sfx_switch = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.options_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // options_volume
            // 
            this.options_volume.Location = new System.Drawing.Point(43, 114);
            this.options_volume.Name = "options_volume";
            this.options_volume.Size = new System.Drawing.Size(300, 56);
            this.options_volume.TabIndex = 0;
            this.options_volume.Value = 10;
            this.options_volume.ValueChanged += new System.EventHandler(this.options_volume_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Music";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sfx";
            // 
            // music_switch
            // 
            this.music_switch.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.music_switch.Location = new System.Drawing.Point(315, 75);
            this.music_switch.Name = "music_switch";
            this.music_switch.Size = new System.Drawing.Size(63, 34);
            this.music_switch.TabIndex = 3;
            this.music_switch.Text = "On";
            this.music_switch.UseVisualStyleBackColor = true;
            this.music_switch.Click += new System.EventHandler(this.music_switch_Click);
            // 
            // sfx_switch
            // 
            this.sfx_switch.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfx_switch.Location = new System.Drawing.Point(315, 184);
            this.sfx_switch.Name = "sfx_switch";
            this.sfx_switch.Size = new System.Drawing.Size(63, 33);
            this.sfx_switch.TabIndex = 4;
            this.sfx_switch.Text = "On";
            this.sfx_switch.UseVisualStyleBackColor = true;
            this.sfx_switch.Click += new System.EventHandler(this.sfx_switch_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(341, -2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(50, 50);
            this.exit.TabIndex = 5;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(43, 240);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(300, 56);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 10;
            // 
            // options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(390, 360);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.sfx_switch);
            this.Controls.Add(this.music_switch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.options_volume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "options";
            ((System.ComponentModel.ISupportInitialize)(this.options_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar options_volume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button music_switch;
        private System.Windows.Forms.Button sfx_switch;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}