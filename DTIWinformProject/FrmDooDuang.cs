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
            btNew.PerformClick();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("th-TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyy เวลา HH:mm:ss น.", culture);
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            mtbID.Clear();
            tbName.Clear();
            dtpDate.Value = DateTime.Now;
            nudHeight.Value = 0;
            nudWeight.Value = 0;

            lbID.Text = "XXXXXXXXXX";
            lbName.Text = "XXXXXXXXXX";
            lbDate.Text = "XXXXXXXXXX";
            lbAge.Text = "XXXXXXXXXX";
            lbHeight.Text = "XXXXXXXXXX";
            lbWeight.Text = "XXXXXXXXXX";
            lbBMI.Text = "XXXXXXXXXX";

            lbResult.Text = "ผลดวง";

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide();
        }

        private void btDooduang_Click(object sender, EventArgs e)
        {
            if (mtbID.MaskCompleted == false)
            {
                shareData.showWarningMsg("กรุณากรอกเลขบัตรประชาชนให้ครบ");
            }
            else if (tbName.Text.Trim().Length == 0)
            {
                shareData.showWarningMsg("กรุณากรอกชื่อ-สกุล");
            }
            else if (dtpDate.Value.Year >= DateTime.Now.Year)
            {
                shareData.showWarningMsg("กรุณาเลือกวันเกิดให้ถูกต้อง");
            }
            else if (nudHeight.Value == 0)
            {
                shareData.showWarningMsg("กรุณากรอกส่วนสูง");
            }
            else if (nudWeight.Value == 0)
            {
                shareData.showWarningMsg("กรุณากรอกน้ำหนัก");
            }
            else
            {
                lbID.Text = mtbID.Text;
                lbName.Text = tbName.Text;
                lbDate.Text = dtpDate.Value.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyy", new CultureInfo("th-TH"));
                lbAge.Text = (DateTime.Now.Year - dtpDate.Value.Year).ToString();
                lbHeight.Text = nudHeight.Value.ToString();
                lbWeight.Text = nudWeight.Value.ToString();
                lbBMI.Text = (nudWeight.Value / ((nudHeight.Value / 100) * (nudHeight.Value / 100))).ToString("0.00");

                int month = dtpDate.Value.Month;
                switch (month)
                {
                    case 1: lbResult.Text = "โชคดีมาก1"; break;
                    case 2: lbResult.Text = "โชคดีมาก2"; break;
                    case 3: lbResult.Text = "โชคดีมาก3"; break;
                    case 4: lbResult.Text = "โชคดีมาก4"; break;
                    case 5: lbResult.Text = "โชคดีมาก5"; break;
                    case 6: lbResult.Text = "โชคดีมาก6"; break;
                    case 7: lbResult.Text = "โชคดีมาก7"; break;
                    case 8: lbResult.Text = "โชคดีมาก8"; break;
                    case 9: lbResult.Text = "โชคดีมาก9"; break;
                    case 10: lbResult.Text = "โชคดีมาก10"; break;
                    case 11: lbResult.Text = "โชคดีมาก11"; break;
                    case 12: lbResult.Text = "โชคดีมาก12"; break;


                }
            }


        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // ห้ามพิมพ์ตัวเลขและสัญลักษณ์
            }
        }
    }
}
