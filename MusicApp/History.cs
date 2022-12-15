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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            Functions.Connect();
        }

        private void History_Load(object sender, EventArgs e)
        {
            List<string> songList = Functions.GetFieldValuesList("select TenBaiHat from BAIHAT where LuotNghe > 0 order by LuotNghe desc");

            foreach (string song in songList)
            {
                Panel pnSong = new Panel();
                pnSong.Width = flpnHistory.Width - 28;
                pnSong.Height = 80;
                pnSong.Margin = new Padding(0, 0, 0, 0);
                //
                PictureBox pbSong = new PictureBox();
                pbSong.Size = new Size(60, 60);
                pbSong.Location = new Point(10, 10);
                string songImg = Functions.GetFieldValues("select AnhBaiHat from BAIHAT where TenBaiHat = N'" + song + "'");
                pbSong.BackgroundImage = Image.FromFile("songImage/" + songImg + ".jpg");
                pbSong.BackgroundImageLayout = ImageLayout.Stretch;
                //
                Label lbSong = new Label();
                lbSong.Text = song;
                lbSong.Location = new Point(110, 10);
                lbSong.Font = new Font("Arial Rounded MT", 14, FontStyle.Bold);
                lbSong.ForeColor = Color.FromArgb(64, 64, 64);
                lbSong.AutoSize = true;
                //
                Label lbSinger = new Label();
                lbSinger.Text = Functions.GetFieldValues(
                "select CaSi from BAIHAT where TenBaiHat = N'" + song + "'");
                lbSinger.Location = new Point(110, 50);
                lbSinger.Font = new Font("Arial Rounded MT", 10, FontStyle.Bold);
                lbSinger.ForeColor = Color.Gray;
                lbSinger.AutoSize = true;
                //
                Label lbTime = new Label();
                lbTime.Text = Functions.GetFieldValues("select LuotNghe from BAIHAT where TenBaiHat = N'" + song + "'");
                lbTime.Location = new Point(720, 30);
                lbTime.Font = new Font("Arial Rounded MT", 10, FontStyle.Bold);
                lbTime.ForeColor = Color.Gray;
                lbTime.AutoSize = true;
                //
                pnSong.Controls.Add(pbSong);
                pnSong.Controls.Add(lbSong);
                pnSong.Controls.Add(lbSinger);
                pnSong.Controls.Add(lbTime);
                //
                pnSong.MouseClick += new MouseEventHandler(this._songClick);
                pnSong.MouseHover += new EventHandler(this._songHover);
                pnSong.MouseLeave += new EventHandler(this._songLeave);
                pnSong.Cursor = Cursors.Hand;
                //
                foreach (Control control in pnSong.Controls)
                {
                    control.MouseClick += new MouseEventHandler(this._itemClick);
                    control.MouseHover += new EventHandler(this._itemHover);
                    control.MouseLeave += new EventHandler(this._itemLeave);
                }
                flpnHistory.Controls.Add(pnSong);
            }
        }

        void _songClick(object sender, MouseEventArgs e)
        {
            Panel temp = (Panel)sender;
            Home.songClick = temp.Controls[1].Text;
            DetailHistory frm = new DetailHistory();
            frm.ShowDialog();
        }

        void _songHover(object sender, EventArgs e)
        {
            Panel temp = (Panel)sender;
            temp.BackColor = Color.FromArgb(212, 211, 215);
        }

        void _songLeave(object sender, EventArgs e)
        {
            Panel temp = (Panel)sender;
            temp.BackColor = Color.Transparent;
        }

        void _itemClick(object sender, MouseEventArgs e)
        {
            Panel pnParent = (Panel)((Control)sender).Parent;
            _songClick(pnParent, e);
        }

        void _itemHover(object sender, EventArgs e)
        {
            Panel pnParent = (Panel)((Control)sender).Parent;
            _songHover(pnParent, e);
        }

        void _itemLeave(object sender, EventArgs e)
        {
            Panel pnParent = (Panel)((Control)sender).Parent;
            _songLeave(pnParent, e);
        }

        private void pnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
