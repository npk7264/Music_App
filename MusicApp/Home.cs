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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            Functions.Connect();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            txtSearch.Text = "Type to search";
            string[] theloaiList = { "Pop", "R&B", "Indie", "Dance", "Rap" };

            foreach (string theloai in theloaiList)
                LoadData(theloai);
            //
            Control[] controls = { pnPop, pnRB, pnIndie, pnDance, pnRap };
            foreach (Control control in controls)
            {
                control.MouseClick += new MouseEventHandler(this._theloaiClick);
                control.MouseHover += new EventHandler(this._songHover);
                control.MouseLeave += new EventHandler(this._songLeave);
                //
                foreach (Control child in control.Controls)
                {
                    child.MouseClick += new MouseEventHandler(this._itemTheLoaiClick);
                    child.MouseHover += new EventHandler(this._itemHover);
                    child.MouseLeave += new EventHandler(this._itemLeave);
                }
            }
        }

        void LoadData(string theloai)
        {
            List<string> songList = Functions.GetFieldValuesList("select TenBaiHat from BAIHAT where TheLoai = N'" + theloai + "'");

            foreach (string song in songList)
            {
                Panel pnSong = new Panel();
                pnSong.Width = flpnSong.Width - 28;
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
                lbSinger.Text = Functions.GetFieldValues("select CaSi from BAIHAT where TenBaiHat = N'" + song + "'");
                lbSinger.Location = new Point(110, 50);
                lbSinger.Font = new Font("Arial Rounded MT", 10, FontStyle.Bold);
                lbSinger.ForeColor = Color.Gray;
                lbSinger.AutoSize = true;
                //
                pnSong.Controls.Add(pbSong);
                pnSong.Controls.Add(lbSong);
                pnSong.Controls.Add(lbSinger);
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
                flpnSong.Controls.Add(pnSong);
            }
        }

        public static string songClick;

        void _theloaiClick(object sender, MouseEventArgs e)
        {
            Panel temp = (Panel)sender;
            string theloai = "";
            foreach (Control control in temp.Controls)
            {
                if (control.GetType() == typeof(Label))
                {
                    theloai = control.Text;
                    if (theloai == "R&&B")
                        theloai = "R&B";
                }
            }
            flpnSong.Controls.Clear();
            LoadData(theloai);
        }
        void _itemTheLoaiClick(object sender, MouseEventArgs e)
        {
            Control temp = (Control)sender;
            Control parent = temp.Parent;
            _theloaiClick(parent, e);
        }

        void _songClick(object sender, MouseEventArgs e)
        {
            Panel temp = (Panel)sender;
            Control txtSong = temp.Controls[1];
            songClick = txtSong.Text;
            // Luu luot nghe
            int luotnghe = Convert.ToInt32(Functions.GetFieldValues("select LuotNghe from BAIHAT where TenBaiHat = N'" + songClick + "'")) + 1;
            Functions.RunSQL("update BAIHAT set LuotNghe = " + luotnghe.ToString() + " where TenBaiHat = N'" + songClick + "'");
            // Luu lich su
            Functions.RunSQL("insert into LICHSU values(N'" + songClick + "', '" + DateTime.Now.ToString() + "')");
            //
            Music frm = new Music();
            frm.ShowDialog();
        }
        void _songHover(object sender, EventArgs e)
        {
            Panel temp = (Panel)sender;
            //temp.BackColor = Color.FromArgb(179, 219, 231);
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

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Type to search";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Type to search")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            Playlist frm = new Playlist();
            frm.ShowDialog();
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            flpnSong.Controls.Clear();
            List<string> songList = Functions.GetFieldValuesList("select TenBaiHat from BAIHAT where YeuThich = 1");

            foreach (string song in songList)
            {
                Panel pnSong = new Panel();
                pnSong.Width = flpnSong.Width - 28;
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
                lbSinger.Text = Functions.GetFieldValues("select CaSi from BAIHAT where TenBaiHat = N'" + song + "'");
                lbSinger.Location = new Point(110, 50);
                lbSinger.Font = new Font("Arial Rounded MT", 10, FontStyle.Bold);
                lbSinger.ForeColor = Color.Gray;
                lbSinger.AutoSize = true;
                //
                pnSong.Controls.Add(pbSong);
                pnSong.Controls.Add(lbSong);
                pnSong.Controls.Add(lbSinger);
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
                flpnSong.Controls.Add(pnSong);
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History frm = new History();
            frm.ShowDialog();
        }
    }
}