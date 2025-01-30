using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTIWinformProject
{
    public partial class FrmLotto : Form
    {
        public FrmLotto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide();
        }

        private void FrmLotto_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = shareData.loginName + " (" + shareData.loginType + ")";
            timer1.Enabled = true;
            rdbClose.PerformClick();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("th-TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyy เวลา HH:mm:ss น.", culture);
        }

        private void rdbClose_Click(object sender, EventArgs e)
        {
            lbLotto1.Text = "??????";
            lbLotto2_1.Text = "???";
            lbLotto2_2.Text = "???";
            lbLotto3_1.Text = "???";
            lbLotto3_2.Text = "???";
            lbLotto4.Text = "??";

            btLotto1.Enabled = false;
            btLotto2.Enabled = false;
            btLotto3.Enabled = false;
            btLotto4.Enabled = false;

            dtpDate.Value = DateTime.Now;
        }

        private void rdbOpen_Click(object sender, EventArgs e)
        {
            btLotto1.Enabled = true;
            btLotto2.Enabled = true;
            btLotto3.Enabled = true;
            btLotto4.Enabled = true;
        }

        private void btLotto1_Click(object sender, EventArgs e)
        {
            if (dtpDate.Value.Day != 1 && dtpDate.Value.Day != 16)
            {
                shareData.showWarningMsg("วันที่ต้องเป็นวันที่ 1 หรือ 16 เท่านั้น");
            }
            else
            {
                Random random = new Random();
                String Lotto = random.Next(1000000).ToString("000000");
                lbLotto1.Text = Lotto;
                btLotto1.Enabled = false;
            }
        }

        private void btLotto2_Click(object sender, EventArgs e)
        {
            if (dtpDate.Value.Day != 1 && dtpDate.Value.Day != 16)
            {
                shareData.showWarningMsg("วันที่ต้องเป็นวันที่ 1 หรือ 16 เท่านั้น");
            }
            else
            {
                Random random = new Random();
                String Lotto2_1 = random.Next(1000).ToString("000");
                String Lotto2_2 = random.Next(1000).ToString("000");
                lbLotto2_1.Text = Lotto2_1;
                lbLotto2_2.Text = Lotto2_2;
                btLotto2.Enabled = false;
            }
        }

        

        private void btLotto4_Click(object sender, EventArgs e)
        {
            if (dtpDate.Value.Day != 1 && dtpDate.Value.Day != 16)
            {
                shareData.showWarningMsg("วันที่ต้องเป็นวันที่ 1 หรือ 16 เท่านั้น");
            }
            else
            {
                Random random = new Random();
                String Lotto = random.Next(100).ToString("00");
                lbLotto4.Text = Lotto;
                btLotto4.Enabled = false;
            }
        }

        private void btLotto3_Click(object sender, EventArgs e)
        {
            if (dtpDate.Value.Day != 1 && dtpDate.Value.Day != 16)
            {
                shareData.showWarningMsg("วันที่ต้องเป็นวันที่ 1 หรือ 16 เท่านั้น");
            }
            else
            {
                Random random = new Random();
                String Lotto3_1 = random.Next(1000).ToString("000");
                String Lotto3_2 = random.Next(1000).ToString("000");
                lbLotto3_1.Text = Lotto3_1;
                lbLotto3_2.Text = Lotto3_2;
                btLotto3.Enabled = false;
            }
        }
    }
}
