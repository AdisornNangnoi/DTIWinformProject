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
    public partial class FrmShapeArea : Form
    {
        public FrmShapeArea()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide();
        }

        private void FrmShapeArea_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = shareData.loginName + " (" + shareData.loginType + ")";
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("th-TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyy เวลา HH:mm:ss น.", culture);
        }

        private void keyNumberAndDotOnly(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // ถ้า TextBox ว่าง และตัวอักษรที่ป้อนไม่ใช่ตัวเลข
            if (textBox.Text.Length == 0 && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void tbRadius_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberAndDotOnly(sender, e);
        }

        private void btCircleCancel_Click(object sender, EventArgs e)
        {
            tbRadius.Clear();
            lbCircleResult.Text = "0.00";
            rdbCircleArea.Checked = true;
            tbRadius.Focus();
        }

        private void btCircleCal_Click(object sender, EventArgs e)
        {
            if (tbRadius.Text.Trim().Length == 0)
            {
                shareData.showWarningMsg("กรุณากรอกรัศมี");
            }
            else
            {
                double radius = double.Parse(tbRadius.Text);
                double result = 0.00;
                if (rdbCircleArea.Checked)
                {
                    result = Math.PI * Math.Pow(radius, 2);
                }
                else
                {
                    result = 2 * Math.PI * radius;
                }
                lbCircleResult.Text = result.ToString("0.00");
            }
        }

        private void tbRectWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberAndDotOnly(sender, e);
        }

        private void tbRectHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberAndDotOnly(sender, e);
        }

        private void btRectCancel_Click(object sender, EventArgs e)
        {
            tbRectHeight.Clear();
            tbRectWidth.Clear();
            rdbRectArea.Checked = true;
            lbRectResult.Text = "0.00";
            tbRectWidth.Focus();
        }

        private void btRectCal_Click(object sender, EventArgs e)
        {
            if (tbRectWidth.Text.Trim().Length == 0 || tbRectHeight.Text.Trim().Length == 0)
            {
                shareData.showWarningMsg("กรุณากรอกความกว้างและความสูง");
            }
            else
            {
                double width = double.Parse(tbRectWidth.Text);
                double height = double.Parse(tbRectHeight.Text);
                double result = 0.00;
                if (rdbRectArea.Checked)
                {
                    result = width * height;
                }
                else
                {
                    result = 2 * (width + height);
                }
                lbRectResult.Text = result.ToString("0.00");
            }
        }

        private void tbTriWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberAndDotOnly(sender, e);
        }

        private void tbTriLong_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberAndDotOnly(sender, e);
        }

        private void tbTriSideAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberAndDotOnly(sender, e);
        }

        private void btTriCancel_Click(object sender, EventArgs e)
        {
            tbTriLong.Clear();
            tbTriSideAngle.Clear();
            tbTriWidth.Clear();
            rdbTriArea.Checked = true;
            lbTriResult.Text = "0.00";
            tbTriWidth.Focus();
        }

        private void btTriCal_Click(object sender, EventArgs e)
        {
            if (tbTriWidth.Text.Trim().Length == 0 || tbTriLong.Text.Trim().Length == 0 || tbTriSideAngle.Text.Trim().Length == 0)
            {
                shareData.showWarningMsg("กรุณากรอกความกว้าง ความยาว และมุมด้านข้าง");
            }
            else
            {
                double width = double.Parse(tbTriWidth.Text);
                double height = double.Parse(tbTriLong.Text);
                double sideAngle = double.Parse(tbTriSideAngle.Text);
                double result = 0.00;

                if (rdbTriArea.Checked)
                {
                    result = 0.5 * width * height;
                }
                else
                {
                    double side1 = width;
                    double side2 = height;
                    double side3 = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2) - 2 * side1 * side2 * Math.Cos(sideAngle * Math.PI / 180));
                    result = side1 + side2 + side3;
                }
                lbTriResult.Text = result.ToString("0.00");
            }
        }
    }
}
