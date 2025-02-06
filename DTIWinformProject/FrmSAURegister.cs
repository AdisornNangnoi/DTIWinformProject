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
using System.Xml.Linq;

namespace DTIWinformProject
{
    public partial class FrmSAURegister : Form
    {
        public FrmSAURegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide();
        }

        private void FrmSAURegister_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = shareData.loginName + " (" + shareData.loginType + ")";
            timer1.Enabled = true;
            btCancel.PerformClick();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("th-TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyy เวลา HH:mm:ss น.", culture);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            mcdRegis.SetDate(DateTime.Now);

            tbNameRegis.Text = "";
            tbNoRegis.Text = "";

            rdNormalRegis.Checked = true;

            cbbLevelRegis.SelectedIndex = 0;

            cbConfirm.Checked = false;

            lsbSubjectRegis.SelectedIndex = -1;
            lsbSubjectRegis.Items.AddRange(lsbSubjectSelectRegis.Items);
            lsbSubjectSelectRegis.Items.Clear();

            pbImageRegis.Image = null;
        }

        private void btSelectSub_Click(object sender, EventArgs e)
        {
            if (lsbSubjectRegis.SelectedIndex < 0)
            {
                shareData.showWarningMsg("เลือกวิชาที่จะลงทะเบียนด้วย");
            }
            else
            {
                lsbSubjectSelectRegis.Items.Add(lsbSubjectRegis.Items[lsbSubjectRegis.SelectedIndex]);
                lsbSubjectRegis.Items.RemoveAt(lsbSubjectRegis.SelectedIndex);
            }
        }

        private void btSelectAllSub_Click(object sender, EventArgs e)
        {
            lsbSubjectSelectRegis.Items.AddRange(lsbSubjectRegis.Items);
            lsbSubjectRegis.Items.Clear();
        }

        private void btUnselectSub_Click(object sender, EventArgs e)
        {
            if (lsbSubjectSelectRegis.SelectedIndex < 0)
            {
                shareData.showWarningMsg("เลือกวิชาที่จะยกเลิกลงทะเบียนด้วย");
            }
            else
            {
                lsbSubjectRegis.Items.Add(lsbSubjectSelectRegis.Items[lsbSubjectSelectRegis.SelectedIndex]);
                lsbSubjectSelectRegis.Items.RemoveAt(lsbSubjectSelectRegis.SelectedIndex);
            }
        }

        private void btUnselctAllSub_Click(object sender, EventArgs e)
        {
            lsbSubjectRegis.Items.AddRange(lsbSubjectSelectRegis.Items);
            lsbSubjectSelectRegis.Items.Clear();
        }

        private void btImageSelectRegis_Click(object sender, EventArgs e)
        {
                openFileDialog1.Filter = "Image filter(*.jpg,*.png, *.jpeg)|*.jpg; *.png; *.jpeg;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbImageRegis.Image = new Bitmap(openFileDialog1.FileName);
            }
            
                
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide();
        }

        private void btRegis_Click(object sender, EventArgs e)
        {
            if (tbNoRegis.Text.Trim().Length == 0)
            {
                shareData.showWarningMsg("ป้อนรหัสนักศึกษาด้วย");
            }
            else if (tbNameRegis.Text.Trim().Length == 0)
            {
                shareData.showWarningMsg("ป้อนชื่อด้วย");
            }
            else if (lsbSubjectSelectRegis.Items.Count <= 0)
            {
                shareData.showWarningMsg("เลือกวิชาที่จะลงทะเบียนอย่างน้อย 1 วิชา");
            }
            else if (lsbSubjectSelectRegis.Items.Count > 7)
            {
                shareData.showWarningMsg("วิชาที่จะลงทะเบียนต้องไม่เกิน 7 วิชา");
            }
            else if (pbImageRegis.Image == null)
            {
                shareData.showWarningMsg("เลือกรูปภาพด้วย");
            }
            else if (cbConfirm.Checked == false)
            {
                shareData.showWarningMsg("ยืนยันการลงทะเบียนด้วย");
            }
            else
            {
                string selectedType = "";
                if (rdNormalRegis.Checked) selectedType = rdNormalRegis.Text;
                else if (rdFundRegis.Checked) selectedType = rdFundRegis.Text;

                string selectedSubjects = string.Join("\n", lsbSubjectSelectRegis.Items.Cast<string>());


                FrmSAURegisterResult frmSAURegisterResult = new FrmSAURegisterResult(
                    pbImageRegis.Image,
                    mcdRegis.SelectionStart,
                    tbNoRegis.Text.Trim(),
                    tbNameRegis.Text.Trim(),
                    selectedType,
                    cbbLevelRegis.SelectedItem?.ToString(),
                    selectedSubjects.ToString()
                );
                frmSAURegisterResult.Show();
                Hide();

            }

        }

        private void tbNoRegis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbNameRegis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
