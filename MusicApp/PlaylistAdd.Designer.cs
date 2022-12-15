namespace MusicApp
{
    partial class PlaylistAdd
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
            this.btnAddToPlaylist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flpnSong = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPlaylist = new System.Windows.Forms.TextBox();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pnBack = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddToPlaylist
            // 
            this.btnAddToPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToPlaylist.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToPlaylist.Location = new System.Drawing.Point(1267, 141);
            this.btnAddToPlaylist.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.btnAddToPlaylist.Name = "btnAddToPlaylist";
            this.btnAddToPlaylist.Size = new System.Drawing.Size(183, 60);
            this.btnAddToPlaylist.TabIndex = 23;
            this.btnAddToPlaylist.Text = "Add";
            this.btnAddToPlaylist.UseVisualStyleBackColor = true;
            this.btnAddToPlaylist.Click += new System.EventHandler(this.btnAddToPlaylist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 38);
            this.label1.TabIndex = 21;
            this.label1.Text = "New Playlist";
            // 
            // flpnSong
            // 
            this.flpnSong.AutoScroll = true;
            this.flpnSong.Location = new System.Drawing.Point(375, 269);
            this.flpnSong.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.flpnSong.Name = "flpnSong";
            this.flpnSong.Size = new System.Drawing.Size(1103, 570);
            this.flpnSong.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 38);
            this.label2.TabIndex = 19;
            this.label2.Text = "Playlist";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtPlaylist);
            this.panel1.Location = new System.Drawing.Point(376, 141);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 60);
            this.panel1.TabIndex = 24;
            // 
            // txtPlaylist
            // 
            this.txtPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaylist.ForeColor = System.Drawing.Color.Gray;
            this.txtPlaylist.Location = new System.Drawing.Point(15, 15);
            this.txtPlaylist.Name = "txtPlaylist";
            this.txtPlaylist.Size = new System.Drawing.Size(848, 31);
            this.txtPlaylist.TabIndex = 0;
            this.txtPlaylist.Text = "Enter new playlist name";
            this.txtPlaylist.Enter += new System.EventHandler(this.txtPlaylist_Enter);
            this.txtPlaylist.Leave += new System.EventHandler(this.txtPlaylist_Leave);
            // 
            // pbHome
            // 
            this.pbHome.BackgroundImage = global::MusicApp.Properties.Resources.home_icon;
            this.pbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHome.Location = new System.Drawing.Point(375, 20);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(50, 50);
            this.pbHome.TabIndex = 25;
            this.pbHome.TabStop = false;
            // 
            // pnBack
            // 
            this.pnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.pnBack.BackgroundImage = global::MusicApp.Properties.Resources.back_icon;
            this.pnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnBack.Location = new System.Drawing.Point(1, 1);
            this.pnBack.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.pnBack.Name = "pnBack";
            this.pnBack.Size = new System.Drawing.Size(342, 838);
            this.pnBack.TabIndex = 16;
            this.pnBack.Click += new System.EventHandler(this.pnBack_Click);
            // 
            // PlaylistAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 841);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddToPlaylist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpnSong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlaylistAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlaylistAdd";
            this.Load += new System.EventHandler(this.PlaylistAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddToPlaylist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpnSong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPlaylist;
        private System.Windows.Forms.PictureBox pbHome;
    }
}