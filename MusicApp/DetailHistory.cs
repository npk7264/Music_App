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

        private void DetailHistory_Load(object sender, EventArgs e)
        {
            PictureBox pbSong = new PictureBox();
            pbSong.Size = new Size(60, 60);
            pbSong.Location = new Point(0, 10);
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
            Label lbView = new Label();
            lbView.Text = Functions.GetFieldValues(
                "select LuotNghe from BAIHAT where TenBaiHat = N'" + Home.songClick + "'");
            lbView.Location = new Point(630, 30);
            lbView.Font = new Font("Arial Rounded MT", 10, FontStyle.Bold);
            lbView.ForeColor = Color.Gray;
            lbView.AutoSize = true;
            //
            pnSong.Controls.Add(pbSong);
            pnSong.Controls.Add(lbSong);
            pnSong.Controls.Add(lbSinger);
            pnSong.Controls.Add(lbView);

            //////////////////////////////////////////////////////////
            List<string> times = Functions.GetFieldValuesList(
                "select ThoiGian from LICHSU where TenBaiHat = N'" + Home.songClick + "' order by ThoiGian desc");

            foreach(string time in times)
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

            pb.BackgroundImage = Image.FromFile("songImage/" + songImg + ".jpg");
            pb.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
