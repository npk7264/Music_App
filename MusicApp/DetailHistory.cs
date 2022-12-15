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
    public partial class DetailHistory : Form
    {
        public DetailHistory()
        {
            InitializeComponent();
        }

        public static int history_to_music;

        private void DetailHistory_Load(object sender, EventArgs e)
        {
            history_to_music = 0;

            PictureBox pbSong = new PictureBox();
            pbSong.Size = new Size(60, 60);
            pbSong.Location = new Point(10, 10);
            string songImg = Functions.GetFieldValues(
                "select AnhBaiHat from BAIHAT where TenBaiHat = N'" + Home.songClick + "'");
            pbSong.BackgroundImage = Image.FromFile("songImage/" + songImg + ".jpg");
            pbSong.BackgroundImageLayout = ImageLayout.Stretch;
            //
            Label lbSong = new Label();
            lbSong.Text = Home.songClick;
            lbSong.Location = new Point(110, 10);
            lbSong.Font = new Font("Arial Rounded MT", 14, FontStyle.Bold);
            lbSong.ForeColor = Color.FromArgb(64, 64, 64);
            lbSong.AutoSize = true;
            //
            Label lbSinger = new Label();
            lbSinger.Text = Functions.GetFieldValues(
                "select CaSi from BAIHAT where TenBaiHat = N'" + Home.songClick + "'");
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

            //////////////////////////////////////////////////////////
            List<string> times = Functions.GetFieldValuesList(
                "select ThoiGian from LICHSU where TenBaiHat = N'" + Home.songClick + "' order by ThoiGian desc");

            foreach (string time in times)
            {
                Panel pn = new Panel();
                pn.Width = flpnTime.Width - 28;
                pn.Height = 40;
                pn.Margin = new Padding(0, 0, 0, 0);
                //
                Label lbTime = new Label();
                lbTime.Text = time;
                lbTime.Location = new Point(10, 15);
                lbTime.Font = new Font("Arial Rounded MT", 10, FontStyle.Bold);
                lbTime.ForeColor = Color.FromArgb(64, 64, 64);
                lbTime.AutoSize = true;
                //
                pn.Controls.Add(lbTime);
                flpnTime.Controls.Add(pn);
            }
        }

        private void pnBack_Click(object sender, EventArgs e)
        {
            history_to_music = 0;
            this.Close();

            History frm = new History();
            frm.ShowDialog();
        }

        void _songClick(object sender, MouseEventArgs e)
        {
            Panel temp = (Panel)sender;
            Home.songClick = temp.Controls[1].Text;

            history_to_music = 1;
            this.Close();

            Music frm = new Music();
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

        private void pbHome_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();
            foreach (Form f in Application.OpenForms)
                openForms.Add(f);
            foreach (Form f in openForms)
                if (f.Name != "Home")
                    f.Close();
        }
    }
}
