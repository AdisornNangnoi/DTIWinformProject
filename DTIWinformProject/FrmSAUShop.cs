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
    public partial class FrmSAUShop : Form
    {
        public FrmSAUShop()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void FrmSAUShop_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = shareData.loginName + " (" + shareData.loginType + ")";
            timer1.Enabled = true;
            btCancel.PerformClick();

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            cbPen.Checked = false;
            cbPencil.Checked = false;
            cbEraser.Checked = false;
            cbRuler.Checked = false;
            cbBook.Checked = false;

            tbPen.Clear();
            tbPencil.Clear();
            tbEraser.Clear();
            tbRuler.Clear();
            tbBook.Clear();

            tbPen.Enabled = false;
            tbPencil.Enabled = false;
            tbEraser.Enabled = false;
            tbRuler.Enabled = false;
            tbBook.Enabled = false;

            lbPen.Text = "0.00";
            lbPencil.Text = "0.00";
            lbEraser.Text = "0.00";
            lbRuler.Text = "0.00";
            lbBook.Text = "0.00";
            lbResult.Text = "0.00";

            cbbDiscount.SelectedIndex = 0;
        }

        private void cbPen_Click(object sender, EventArgs e)
        {
            if (cbPen.Checked == true)
            {
                tbPen.Enabled = true;
            }
            else
            {
                tbPen.Clear();
                tbPen.Enabled = false;
                lbPen.Text = "0.00";
            }
        }

        private void cbPencil_Click(object sender, EventArgs e)
        {
            if (cbPencil.Checked == true)
            {
                tbPencil.Enabled = true;
            }
            else
            {
                tbPencil.Clear();
                tbPencil.Enabled = false;
                lbPencil.Text = "0.00";
            }
        }

        private void cbEraser_Click(object sender, EventArgs e)
        {
            if (cbEraser.Checked == true)
            {
                tbEraser.Enabled = true;
            }
            else
            {
                tbEraser.Clear();
                tbEraser.Enabled = false;
                lbEraser.Text = "0.00";
            }
        }

        private void cbRuler_Click(object sender, EventArgs e)
        {
            if (cbRuler.Checked == true)
            {
                tbRuler.Enabled = true;
            }
            else
            {
                tbRuler.Clear();
                tbRuler.Enabled = false;
                lbRuler.Text = "0.00";
            }
        }

        private void cbBook_Click(object sender, EventArgs e)
        {
            if (cbBook.Checked == true)
            {
                tbBook.Enabled = true;
            }
            else
            {
                tbBook.Clear();
                tbBook.Enabled = false;
                lbBook.Text = "0.00";
            }
        }

        private void tbPen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPencil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbEraser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbRuler_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPen_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbPen.Text.Length > 0)
            {
            int quantity = int.Parse(tbPen.Text);
            double price = 5.00 * quantity;
            lbPen.Text = price.ToString("0.00");
            }
            else
            {
                lbPen.Text = "0.00";
            }
            
        }

        private void tbPencil_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbPencil.Text.Length > 0)
            {
                int quantity = int.Parse(tbPencil.Text);
                double price = 1.50 * quantity;
                lbPencil.Text = price.ToString("0.00");
            }
            else
            {
                lbPencil.Text = "0.00";
            }

            }

        private void tbEraser_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbEraser.Text.Length > 0)
            {
                int quantity = int.Parse(tbEraser.Text);
                double price = 2.50 * quantity;
                lbEraser.Text = price.ToString("0.00");
            }
            else
            {
                lbEraser.Text = "0.00";
            }
        }

        private void tbRuler_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbRuler.Text.Length > 0)
            {
                int quantity = int.Parse(tbRuler.Text);
                double price = 2.00 * quantity;
                lbRuler.Text = price.ToString("0.00");
            }
            else
            {
                lbRuler.Text = "0.00";
            }
        }

        private void tbBook_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbBook.Text.Length > 0)
            {
                int quantity = int.Parse(tbBook.Text);
                double price = 10.25 * quantity;
                lbBook.Text = price.ToString("0.00");
            }
            else
            {
                lbBook.Text = "0.00";
            }
        }

        private void btCal_Click(object sender, EventArgs e)
        {
           double totalPay = 
                    double.Parse(lbPen.Text) +
                    double.Parse(lbPencil.Text) +
                    double.Parse(lbEraser.Text) +
                    double.Parse(lbRuler.Text) +
                    double.Parse(lbBook.Text);
            
            if (cbbDiscount.SelectedIndex == 0) {
                totalPay = totalPay - (totalPay * 0.05);
            }
            else if (cbbDiscount.SelectedIndex == 1)
            {
                totalPay = totalPay - (totalPay * 0.10);
            }
            else if (cbbDiscount.SelectedIndex == 2)
            {
                totalPay = totalPay - (totalPay * 0.15);
            }
            lbResult.Text = totalPay.ToString("#,###,###,##0.00");

        }
    }
}
