namespace MusicApp
{
    partial class DetailPlaylist
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
            this.flpnSong = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pnBack = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.SuspendLayout();
            // 
            // flpnSong
            // 
            this.flpnSong.AutoScroll = true;
            this.flpnSong.Location = new System.Drawing.Point(375, 141);
            this.flpnSong.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.flpnSong.Name = "flpnSong";
            this.flpnSong.Size = new System.Drawing.Size(1103, 698);
            this.flpnSong.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 38);
            this.label2.TabIndex = 16;
            this.label2.Text = "Song";
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
            // pnBack
            // 
            this.pnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.pnBack.BackgroundImage = global::MusicApp.Properties.Resources.back_icon;
            this.pnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnBack.Location = new System.Drawing.Point(0, 1);
            this.pnBack.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.pnBack.Name = "pnBack";
            this.pnBack.Size = new System.Drawing.Size(342, 838);
            this.pnBack.TabIndex = 13;
            this.pnBack.Click += new System.EventHandler(this.pnBack_Click);
            // 
            // DetailPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 841);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.flpnSong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailPlaylist";
            this.Load += new System.EventHandler(this.DetailPlaylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpnSong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnBack;
        private System.Windows.Forms.PictureBox pbHome;
    }
}