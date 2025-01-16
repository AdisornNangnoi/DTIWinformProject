using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace DTIWinformProject
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = shareData.loginName + " (" +shareData.loginType + ")";
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("th-TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyy เวลา HH:mm:ss น.", culture);

        }

        private void btWelcome_Click(object sender, EventArgs e)
        {
            FrmWelcome frmWelcome = new FrmWelcome();
            frmWelcome.Show();
            Hide();
        }

        private void btCal_Click(object sender, EventArgs e)
        {
            FrmCalculator frmCalculator = new FrmCalculator();
            frmCalculator.Show();
            Hide();
        }

        private void btShop_Click(object sender, EventArgs e)
        {
            FrmSAUShop frmSAUShop = new FrmSAUShop();
            frmSAUShop.Show();
            Hide();
        }

        private void btLotto_Click(object sender, EventArgs e)
        {
            FrmLotto frmLotto = new FrmLotto();
            frmLotto.Show();
            Hide();
        }

        private void btDooduang_Click(object sender, EventArgs e)
        {
            FrmDooDuang frmDooDuang = new FrmDooDuang();
            frmDooDuang.Show();
            Hide();
        }

        private void btArea_Click(object sender, EventArgs e)
        {
            FrmShapeArea frmShapeArea = new FrmShapeArea();
            frmShapeArea.Show();
            Hide();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            FrmSAURegister frmSAURegister = new FrmSAURegister();
            frmSAURegister.Show();
            Hide();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            Hide();
        }
    }
}
