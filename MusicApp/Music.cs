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
using System.IO.Compression;

namespace MusicApp
{
    public partial class Music : Form
    {
        public Music()
        {
            InitializeComponent();
        }

        private void Music_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Location = new Point(panel2.Location.X, panel2.Location.Y - 40);
            axWindowsMediaPlayer1.Size = new Size(panel2.Width, panel2.Height);


            // Lưu lượt nghe
            int luotnghe = Convert.ToInt32(Functions.GetFieldValues(
                "select LuotNghe from BAIHAT where TenBaiHat = N'" + Home.songClick + "'")) + 1;
            Functions.RunSQL(
                "update BAIHAT set LuotNghe = " + luotnghe.ToString() + " where TenBaiHat = N'" + Home.songClick + "'");
            // Lưu lịch sử
            Functions.RunSQL("insert into LICHSU values(N'" + Home.songClick + "', '" + DateTime.Now.ToString() + "')");

            // Load ảnh
            string songImg = Functions.GetFieldValues("select AnhBaiHat from BAIHAT where TenBaiHat = N'" + Home.songClick + "'");
            pbSong.BackgroundImage = Image.FromFile("songImage/" + songImg + ".jpg");
            //
            lbSong.Text = Home.songClick;
            lbSinger.Text = "Singer: " + Functions.GetFieldValues("select CaSi from BAIHAT where TenBaiHat = N'" + Home.songClick + "'");
            lbComposer.Text = "Composer: " + Functions.GetFieldValues("select SangTac from BAIHAT where TenBaiHat = N'" + Home.songClick + "'");
            string genre = Functions.GetFieldValues("select TheLoai from BAIHAT where TenBaiHat = N'" + Home.songClick + "'");
            if (genre == "R&B")
                genre = "R&&B";
            lbCategory.Text = "Genre: " + genre;

            // Load lời bài hát
            string lyrics_path = "songLyric/" + songImg + ".txt";
            if (File.Exists(lyrics_path))
            {
                StreamReader reader = new StreamReader(lyrics_path);
                rtxtLyrics.Text = reader.ReadToEnd();
                reader.Close();
            }
            else
                MessageBox.Show("File khong ton tai!");
            //
            pbPlay.BackgroundImage = Image.FromFile("icon/play_icon.png");
            pbPlay.Tag = "icon/play_icon.png";
            //
            string like = Functions.GetFieldValues("select YeuThich from BAIHAT where TenBaiHat = N'" + Home.songClick + "'");
            if (like == "0")
            {
                pbLike.BackgroundImage = Image.FromFile("icon/unlike.png");
                pbLike.Tag = "icon/unlike.png";
            }
            else
            {
                pbLike.BackgroundImage = Image.FromFile("icon/like.png");
                pbLike.Tag = "icon/like.png";
            }
            //
            pbAddPlaylist.BackgroundImage = Image.FromFile("icon/addplaylist.png");
            //
            pbDownload.BackgroundImage = Image.FromFile("icon/download_icon.png");
            // Load nhac
            axWindowsMediaPlayer1.URL = "song/" + songImg + ".mp3";
        }

        private void pbPlay_Click(object sender, EventArgs e)
        {
            string path = (string)pbPlay.Tag;
            if (path == "icon/pause_icon.png")
            {
                pbPlay.BackgroundImage = Image.FromFile("icon/play_icon.png");
                pbPlay.Tag = "icon/play_icon.png";
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else if (path == "icon/play_icon.png")
            {
                pbPlay.BackgroundImage = Image.FromFile("icon/pause_icon.png");
                pbPlay.Tag = "icon/pause_icon.png";
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
        }

        private void pbLike_Click(object sender, EventArgs e)
        {
            string path = (string)pbLike.Tag;
            if (path == "icon/unlike.png")
            {
                pbLike.BackgroundImage = Image.FromFile("icon/like.png");
                pbLike.Tag = "icon/like.png";
                string sql = "update BAIHAT set YeuThich = 1 where TenBaiHat = N'" + lbSong.Text + "'";
                Functions.RunSQL(sql);
            }
            else if (path == "icon/like.png")
            {
                pbLike.BackgroundImage = Image.FromFile("icon/unlike.png");
                pbLike.Tag = "icon/unlike.png";
                string sql = "update BAIHAT set YeuThich = 0 where TenBaiHat = N'" + lbSong.Text + "'";
                Functions.RunSQL(sql);
            }
        }

        private void pbAddPlaylist_Click(object sender, EventArgs e)
        {
            PlaylistAdd frm = new PlaylistAdd();
            frm.ShowDialog();
        }

        private void pnBack_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.Close();

            if(DetailHistory.history_to_music == 1)
            {
                DetailHistory frm = new DetailHistory();
                frm.ShowDialog();
            }
        }

        private void pbDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "mp3|*.mp3";
            bool flag = false;
            string destPath = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                flag = true;
                destPath = saveFileDialog.FileName;
            }
            if(flag)
            {
                string sourceFile = axWindowsMediaPlayer1.URL;
                string destFile = destPath;
                File.Copy(sourceFile, destFile, true);
                MessageBox.Show("Đã tải nhạc về máy");
            }
        }
    }
}