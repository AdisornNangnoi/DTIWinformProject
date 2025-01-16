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
    public partial class FrmDooDuang : Form
    {
        public FrmDooDuang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide();
        }

        private void FrmDooDuang_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = shareData.loginName + " (" + shareData.loginType + ")";
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("th-TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyy เวลา HH:mm:ss น.", culture);
        }
    }
}
