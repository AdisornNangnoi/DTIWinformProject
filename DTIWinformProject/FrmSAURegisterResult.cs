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
    public partial class FrmSAURegisterResult : Form
    {
        public FrmSAURegisterResult(Image picture, DateTime regDate, string number, string name, string type, string level, string subjects)
        {
            InitializeComponent();

            pbImageRegisShow.Image = picture;
            lbDateShow.Text = regDate.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyy", new CultureInfo("th-TH"));  // แสดงวันที่
            lbNoShow.Text = number;
            lbNameShow.Text = name;
            lbTypeShow.Text = type;
            lbLevelShow.Text = level;
            lbSubjectShow.Text = subjects;

        }

        private void FrmSAURegisterResult_Load(object sender, EventArgs e)
        {

        }
    }
}
