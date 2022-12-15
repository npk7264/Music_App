using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class Playlist : Form
    {
        public Playlist()
        {
            InitializeComponent();
            Functions.Connect();
        }

        public static string playlistClick;

        private void Playlist_Load(object sender, EventArgs e)
        {
            List<string> playlistList = Functions.GetFieldValuesList("select TenPlayList from PLAYLIST");

            foreach (string song in playlistList)
            {
                Panel pnPlayList = new Panel();
                pnPlayList.Width = flpnSong.Width - 28;
                pnPlayList.Height = 80;
                pnPlayList.Margin = new Padding(0, 0, 0, 0);

                //
                Label lbSong = new Label();
                lbSong.Text = song;
                lbSong.Location = new Point(10, 10);
                lbSong.Font = new Font("Arial Rounded MT", 14, FontStyle.Bold);
                lbSong.ForeColor = Color.FromArgb(64, 64, 64);
                lbSong.AutoSize = true;
                //
                Label lbSinger = new Label();
                string sobaihat = Functions.GetFieldValues("select COUNT(TenBaiHat) from CHITIETPLAYLIST where TenPlayList = N'" + song + "'");
                lbSinger.Text = sobaihat + " bài hát";
                lbSinger.Location = new Point(10, 50);
                lbSinger.Font = new Font("Arial Rounded MT", 10, FontStyle.Bold);
                lbSinger.ForeColor = Color.Gray;
                lbSinger.AutoSize = true;
                //
                pnPlayList.Controls.Add(lbSong);
                pnPlayList.Controls.Add(lbSinger);
                //
                pnPlayList.MouseClick += new MouseEventHandler(this._playlistClick);
                pnPlayList.MouseHover += new EventHandler(this._playlistHover);
                pnPlayList.MouseLeave += new EventHandler(this._playlistLeave);
                pnPlayList.Cursor = Cursors.Hand;
                //
                foreach (Control control in pnPlayList.Controls)
                {
                    control.MouseClick += new MouseEventHandler(this._itemClick);
                    control.MouseHover += new EventHandler(this._itemHover);
                    control.MouseLeave += new EventHandler(this._itemLeave);
                }
                //
                flpnSong.Controls.Add(pnPlayList);
            }
        }

        void _playlistClick(object sender, MouseEventArgs e)
        {
            Panel temp = (Panel)sender;
            playlistClick = temp.Controls[0].Text;
            //
            this.Close();
            DetailPlaylist frm = new DetailPlaylist();
            frm.ShowDialog();
        }

        void _playlistHover(object sender, EventArgs e)
        {
            Panel temp = (Panel)sender;
            temp.BackColor = Color.FromArgb(212, 211, 215);
        }

        void _playlistLeave(object sender, EventArgs e)
        {
            Panel temp = (Panel)sender;
            temp.BackColor = Color.Transparent;
        }

        void _itemClick(object sender, MouseEventArgs e)
        {
            Panel pnParent = (Panel)((Control)sender).Parent;
            _playlistClick(pnParent, e);
        }

        void _itemHover(object sender, EventArgs e)
        {
            Panel pnParent = (Panel)((Control)sender).Parent;
            _playlistHover(pnParent, e);
        }

        void _itemLeave(object sender, EventArgs e)
        {
            Panel pnParent = (Panel)((Control)sender).Parent;
            _playlistLeave(pnParent, e);
        }

        private void pnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}