using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTIWinformProject
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการออกจากโปรแกรมใช่หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                == DialogResult.Yes)
            {
                Application.Exit();
            } 
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbUsername.Clear();
            tbPassword.Clear();
            rdStudent.Checked = true;
            tbUsername.Focus();
        }

        private void showWarningMsg(String msg) { 
            MessageBox.Show(msg, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if ( tbUsername.Text.Trim().Length == 0 )
            {
                showWarningMsg("ป้อนชื่อผู้ใช้ด้วย");
            }else if (tbPassword.Text.Trim().Length == 0 )
            {
                showWarningMsg("ป้อนรหัสผ่านด้วย");
            }
            else if (tbPassword.Text.Trim().Length < 6 )
            {
                showWarningMsg("รหัสผ่านต้องไม่ต่ำกว่า 6 ตัว");
            }else
            {
                if ((tbUsername.Text.Trim().ToLower() != "sau" || tbPassword.Text.Trim().ToLower() != "123456") &&
                    (tbUsername.Text.Trim().ToLower() != "dti" || tbPassword.Text.Trim().ToLower() != "654321"))
                {
                    showWarningMsg("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง");
                }
                else
                {
                    shareData.loginName = tbUsername.Text.Trim();
                    if (rdStudent.Checked == true)
                    {
                        shareData.loginType = "student";
                    }
                    else
                    {
                        shareData.loginType = "teacher";
                    }
                    FrmMainMenu frmMainMenu = new FrmMainMenu();
                    frmMainMenu.Show();
                    Hide();
                }
            }
        }
    }
}
