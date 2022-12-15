namespace MusicApp
{
    partial class Music
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbDownload = new System.Windows.Forms.PictureBox();
            this.pbAddPlaylist = new System.Windows.Forms.PictureBox();
            this.pbLike = new System.Windows.Forms.PictureBox();
            this.pbPlay = new System.Windows.Forms.PictureBox();
            this.rtxtLyrics = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pbSong = new System.Windows.Forms.PictureBox();
            this.pnBack = new System.Windows.Forms.Panel();
            this.lbSinger = new System.Windows.Forms.Label();
            this.lbComposer = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSong = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSong)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pbDownload);
            this.panel2.Controls.Add(this.pbAddPlaylist);
            this.panel2.Controls.Add(this.pbLike);
            this.panel2.Controls.Add(this.pbPlay);
            this.panel2.Location = new System.Drawing.Point(375, 738);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1103, 100);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(185, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pbDownload
            // 
            this.pbDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDownload.Location = new System.Drawing.Point(857, 25);
            this.pbDownload.Name = "pbDownload";
            this.pbDownload.Size = new System.Drawing.Size(60, 50);
            this.pbDownload.TabIndex = 3;
            this.pbDownload.TabStop = false;
            this.pbDownload.Click += new System.EventHandler(this.pbDownload_Click);
            // 
            // pbAddPlaylist
            // 
            this.pbAddPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAddPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddPlaylist.Location = new System.Drawing.Point(689, 17);
            this.pbAddPlaylist.Name = "pbAddPlaylist";
            this.pbAddPlaylist.Size = new System.Drawing.Size(60, 60);
            this.pbAddPlaylist.TabIndex = 2;
            this.pbAddPlaylist.TabStop = false;
            this.pbAddPlaylist.Click += new System.EventHandler(this.pbAddPlaylist_Click);
            // 
            // pbLike
            // 
            this.pbLike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLike.Location = new System.Drawing.Point(353, 17);
            this.pbLike.Name = "pbLike";
            this.pbLike.Size = new System.Drawing.Size(60, 60);
            this.pbLike.TabIndex = 1;
            this.pbLike.TabStop = false;
            this.pbLike.Click += new System.EventHandler(this.pbLike_Click);
            // 
            // pbPlay
            // 
            this.pbPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPlay.Location = new System.Drawing.Point(521, 17);
            this.pbPlay.Name = "pbPlay";
            this.pbPlay.Size = new System.Drawing.Size(60, 60);
            this.pbPlay.TabIndex = 0;
            this.pbPlay.TabStop = false;
            this.pbPlay.Click += new System.EventHandler(this.pbPlay_Click);
            // 
            // rtxtLyrics
            // 
            this.rtxtLyrics.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtLyrics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtLyrics.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtxtLyrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtLyrics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtxtLyrics.Location = new System.Drawing.Point(375, 412);
            this.rtxtLyrics.Margin = new System.Windows.Forms.Padding(3, 60, 3, 0);
            this.rtxtLyrics.Name = "rtxtLyrics";
            this.rtxtLyrics.ReadOnly = true;
            this.rtxtLyrics.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtLyrics.Size = new System.Drawing.Size(1103, 323);
            this.rtxtLyrics.TabIndex = 4;
            this.rtxtLyrics.Text = "Lyrics";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 358);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lyrics";
            // 
            // pbHome
            // 
            this.pbHome.BackgroundImage = global::MusicApp.Properties.Resources.home_icon;
            this.pbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHome.Location = new System.Drawing.Point(375, 20);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(50, 50);
            this.pbHome.TabIndex = 20;
            this.pbHome.TabStop = false;
            // 
            // pbSong
            // 
            this.pbSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(219)))), ((int)(((byte)(231)))));
            this.pbSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSong.Location = new System.Drawing.Point(375, 89);
            this.pbSong.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.pbSong.Name = "pbSong";
            this.pbSong.Size = new System.Drawing.Size(240, 240);
            this.pbSong.TabIndex = 0;
            this.pbSong.TabStop = false;
            // 
            // pnBack
            // 
            this.pnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.pnBack.BackgroundImage = global::MusicApp.Properties.Resources.back_icon;
            this.pnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnBack.Location = new System.Drawing.Point(0, 0);
            this.pnBack.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.pnBack.Name = "pnBack";
            this.pnBack.Size = new System.Drawing.Size(342, 838);
            this.pnBack.TabIndex = 3;
            this.pnBack.Click += new System.EventHandler(this.pnBack_Click);
            // 
            // lbSinger
            // 
            this.lbSinger.AutoSize = true;
            this.lbSinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSinger.ForeColor = System.Drawing.Color.Black;
            this.lbSinger.Location = new System.Drawing.Point(36, 124);
            this.lbSinger.Margin = new System.Windows.Forms.Padding(0);
            this.lbSinger.Name = "lbSinger";
            this.lbSinger.Size = new System.Drawing.Size(214, 26);
            this.lbSinger.TabIndex = 1;
            this.lbSinger.Text = "Singer: Fiona Fung";
            // 
            // lbComposer
            // 
            this.lbComposer.AutoSize = true;
            this.lbComposer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComposer.ForeColor = System.Drawing.Color.Black;
            this.lbComposer.Location = new System.Drawing.Point(36, 159);
            this.lbComposer.Margin = new System.Windows.Forms.Padding(0);
            this.lbComposer.Name = "lbComposer";
            this.lbComposer.Size = new System.Drawing.Size(254, 26);
            this.lbComposer.TabIndex = 2;
            this.lbComposer.Text = "Composer: Fiona Fung";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.ForeColor = System.Drawing.Color.Black;
            this.lbCategory.Location = new System.Drawing.Point(36, 194);
            this.lbCategory.Margin = new System.Windows.Forms.Padding(0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(173, 26);
            this.lbCategory.TabIndex = 3;
            this.lbCategory.Text = "Category: Love";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbCategory);
            this.panel1.Controls.Add(this.lbComposer);
            this.panel1.Controls.Add(this.lbSinger);
            this.panel1.Controls.Add(this.lbSong);
            this.panel1.Location = new System.Drawing.Point(636, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 240);
            this.panel1.TabIndex = 1;
            // 
            // lbSong
            // 
            this.lbSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSong.Location = new System.Drawing.Point(29, 7);
            this.lbSong.Margin = new System.Windows.Forms.Padding(0);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(791, 100);
            this.lbSong.TabIndex = 0;
            this.lbSong.Text = "A LITTE LOVE";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(348, 770);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(21, 45);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 841);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtLyrics);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pbSong);
            this.Controls.Add(this.pnBack);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Music";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music";
            this.Load += new System.EventHandler(this.Music_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnBack;
        private System.Windows.Forms.RichTextBox rtxtLyrics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbAddPlaylist;
        private System.Windows.Forms.PictureBox pbLike;
        private System.Windows.Forms.PictureBox pbPlay;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Label lbSinger;
        private System.Windows.Forms.Label lbComposer;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSong;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbDownload;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}