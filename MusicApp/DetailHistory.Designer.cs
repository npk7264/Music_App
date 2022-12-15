namespace MusicApp
{
    partial class DetailHistory
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
            this.label2 = new System.Windows.Forms.Label();
            this.flpnTime = new System.Windows.Forms.FlowLayoutPanel();
            this.pnSong = new System.Windows.Forms.Panel();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pb = new System.Windows.Forms.PictureBox();
            this.pnBack = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1208, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 38);
            this.label2.TabIndex = 17;
            this.label2.Text = "Time";
            // 
            // flpnTime
            // 
            this.flpnTime.AutoScroll = true;
            this.flpnTime.Location = new System.Drawing.Point(1120, 241);
            this.flpnTime.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.flpnTime.Name = "flpnTime";
            this.flpnTime.Size = new System.Drawing.Size(358, 598);
            this.flpnTime.TabIndex = 15;
            // 
            // pnSong
            // 
            this.pnSong.Location = new System.Drawing.Point(375, 141);
            this.pnSong.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.pnSong.Name = "pnSong";
            this.pnSong.Size = new System.Drawing.Size(1075, 100);
            this.pnSong.TabIndex = 0;
            // 
            // pbHome
            // 
            this.pbHome.BackgroundImage = global::MusicApp.Properties.Resources.home_icon;
            this.pbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHome.Location = new System.Drawing.Point(375, 20);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(50, 50);
            this.pbHome.TabIndex = 19;
            this.pbHome.TabStop = false;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(375, 244);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(585, 585);
            this.pb.TabIndex = 18;
            this.pb.TabStop = false;
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
            this.pnBack.TabIndex = 12;
            this.pnBack.Click += new System.EventHandler(this.pnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 38);
            this.label1.TabIndex = 20;
            this.label1.Text = "Song";
            // 
            // DetailHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 841);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.pnSong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flpnTime);
            this.Controls.Add(this.pnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistorySong";
            this.Load += new System.EventHandler(this.DetailHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpnTime;
        private System.Windows.Forms.Panel pnBack;
        private System.Windows.Forms.Panel pnSong;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Label label1;
    }
}