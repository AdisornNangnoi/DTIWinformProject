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
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide();
        }

        private void FrmWelcome_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = shareData.loginName + " (" + shareData.loginType + ")";
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("th-TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyy เวลา HH:mm:ss น.", culture);
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim().Length == 0)
            {
                shareData.showWarningMsg("ป้อนชื่อด้วย...");
            }
            else if (dtpBirthday.Value.Year >= DateTime.Now.Year)
            {
                shareData.showWarningMsg("ปีเกิดต้องน้อยกว่าปีปัจจุบัน");
            }
            else
            {
                int age = DateTime.Now.Year - dtpBirthday.Value.Year;

                string birthDate = dtpBirthday.Value.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyy", new CultureInfo("th-TH"));

                //string gender;
                //if (rdMale.Checked == true)
                //{
                //    gender = "ชาย";
                //}
                //else
                //{
                //    gender = "หญิง";
                //}
                string gender = rdMale.Checked == true ? "ชาย" : "หญิง";

                string dataShow = "ชื่อ : " + tbName.Text + "\n" +
                    "วันเกิด : " + birthDate + "\n" +
                    "อายุ : " + age + " ปี\n" +
                    "เพศ : " + gender;
                lbResult.Text = dataShow;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbName.Clear();
            rdMale.Checked = true;
            dtpBirthday.Value = DateTime.Now;
            tbName.Focus();
        }
    }
}
