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
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = shareData.loginName + " (" + shareData.loginType + ")";
            timer1.Enabled = true;
            cbbDecimal.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("th-TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyy เวลา HH:mm:ss น.", culture);
        }

        private void tbNum1_KeyPress(object sender, KeyPressEventArgs e)
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

        

        private void tbNum2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void calNumber(string opt)
        {
            if (tbNum1.Text.Length == 0 || tbNum2.Text.Length == 0)
            {
                shareData.showWarningMsg("ป้อนตัวเลขด้วย...");
            }
            else
            {
                double num1 = double.Parse(tbNum1.Text);
                double num2 = double.Parse(tbNum2.Text);
                double result;
                if (opt == "+" )
                {
                    result = num1 + num2;
                }
                else if (opt == "-")
                {
                    result = num1 - num2;

                }
                else if (opt == "*")
                {
                    result = num1 * num2;

                }
                else if (opt == "/")
                {
                    if (num2 == 0)
                    {
                        shareData.showWarningMsg("ไม่สามารถหารด้วย 0 ได้");
                        return;
                    }
                    result = num1 / num2;

                }
                else
                {
                    result = Math.Pow(num1, num2);

                }
                if (cbbDecimal.SelectedIndex == 0)
                {
                    lbResult.Text = result.ToString("N2");
                }
                else if (cbbDecimal.SelectedIndex == 1)
                {
                    lbResult.Text = result.ToString("N4");
                }
                else
                {
                    lbResult.Text = result.ToString("N8");
                }
            }
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            calNumber("+");
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            calNumber("-");
        }

        private void btMultiply_Click(object sender, EventArgs e)
        {
            calNumber("*");
        }

        private void btDivide_Click(object sender, EventArgs e)
        {
            calNumber("/");
        }

        private void btPow_Click(object sender, EventArgs e)
        {
            calNumber("^");
        }
    }
}
