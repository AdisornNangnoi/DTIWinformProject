namespace DTIWinformProject
{
    partial class FrmDooDuang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDooDuang));
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.mtbID = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbBMI = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbHeight = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btDooduang = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nudWeight
            // 
            this.nudWeight.DecimalPlaces = 2;
            this.nudWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWeight.Location = new System.Drawing.Point(122, 152);
            this.nudWeight.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(120, 24);
            this.nudWeight.TabIndex = 0;
            // 
            // mtbID
            // 
            this.mtbID.Location = new System.Drawing.Point(122, 37);
            this.mtbID.Mask = "0-0000-00000-00-0";
            this.mtbID.Name = "mtbID";
            this.mtbID.Size = new System.Drawing.Size(305, 26);
            this.mtbID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(70, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(750, 119);
            this.label1.TabIndex = 25;
            this.label1.Text = "ดูดวงแม่นๆ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.nudHeight);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudWeight);
            this.groupBox1.Controls.Add(this.mtbID);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(76, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 236);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลส่วนตัว";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(122, 74);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(305, 26);
            this.tbName.TabIndex = 37;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(122, 113);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(305, 24);
            this.dtpDate.TabIndex = 36;
            // 
            // nudHeight
            // 
            this.nudHeight.DecimalPlaces = 2;
            this.nudHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHeight.Location = new System.Drawing.Point(122, 189);
            this.nudHeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(120, 24);
            this.nudHeight.TabIndex = 35;
            this.nudHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-1, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "ส่วนสูง";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "น้ำหนัก";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "ว/ด/ป เกิด";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "ชื่อ-สกุล";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "ID Card";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(464, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 451);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "รางวัลที่ 1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbUsername,
            this.tslbDateTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 656);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1064, 25);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslbUsername
            // 
            this.tslbUsername.ForeColor = System.Drawing.Color.Blue;
            this.tslbUsername.Name = "tslbUsername";
            this.tslbUsername.Size = new System.Drawing.Size(42, 22);
            this.tslbUsername.Text = "name?";
            // 
            // tslbDateTime
            // 
            this.tslbDateTime.Name = "tslbDateTime";
            this.tslbDateTime.Size = new System.Drawing.Size(59, 22);
            this.tslbDateTime.Text = "datetime?";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.lbBMI);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.lbHeight);
            this.groupBox3.Controls.Add(this.lbWeight);
            this.groupBox3.Controls.Add(this.lbAge);
            this.groupBox3.Controls.Add(this.lbDate);
            this.groupBox3.Controls.Add(this.lbName);
            this.groupBox3.Controls.Add(this.lbID);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(546, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(445, 439);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ผลดวงของคุณ";
            // 
            // lbBMI
            // 
            this.lbBMI.BackColor = System.Drawing.SystemColors.Control;
            this.lbBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBMI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbBMI.Location = new System.Drawing.Point(149, 264);
            this.lbBMI.Name = "lbBMI";
            this.lbBMI.Size = new System.Drawing.Size(253, 23);
            this.lbBMI.TabIndex = 49;
            this.lbBMI.Text = "XXXXXXXXXX";
            this.lbBMI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 264);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(106, 23);
            this.label21.TabIndex = 48;
            this.label21.Text = "BMI";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbResult);
            this.panel1.Location = new System.Drawing.Point(25, 304);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 115);
            this.panel1.TabIndex = 47;
            // 
            // lbResult
            // 
            this.lbResult.BackColor = System.Drawing.SystemColors.Control;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbResult.Location = new System.Drawing.Point(12, 11);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(365, 93);
            this.lbResult.TabIndex = 48;
            this.lbResult.Text = "ผลดวง";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHeight
            // 
            this.lbHeight.BackColor = System.Drawing.SystemColors.Control;
            this.lbHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbHeight.Location = new System.Drawing.Point(149, 227);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(253, 23);
            this.lbHeight.TabIndex = 46;
            this.lbHeight.Text = "XXXXXXXXXX";
            this.lbHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbWeight
            // 
            this.lbWeight.BackColor = System.Drawing.SystemColors.Control;
            this.lbWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbWeight.Location = new System.Drawing.Point(149, 190);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(253, 23);
            this.lbWeight.TabIndex = 45;
            this.lbWeight.Text = "XXXXXXXXXX";
            this.lbWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbAge
            // 
            this.lbAge.BackColor = System.Drawing.SystemColors.Control;
            this.lbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbAge.Location = new System.Drawing.Point(149, 153);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(253, 23);
            this.lbAge.TabIndex = 44;
            this.lbAge.Text = "XXXXXXXXXX";
            this.lbAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDate
            // 
            this.lbDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbDate.Location = new System.Drawing.Point(149, 117);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(253, 23);
            this.lbDate.TabIndex = 43;
            this.lbDate.Text = "XXXXXXXXXX";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.SystemColors.Control;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbName.Location = new System.Drawing.Point(149, 77);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(253, 23);
            this.lbName.TabIndex = 42;
            this.lbName.Text = "XXXXXXXXXX";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbID
            // 
            this.lbID.BackColor = System.Drawing.SystemColors.Control;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbID.Location = new System.Drawing.Point(149, 40);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(253, 23);
            this.lbID.TabIndex = 41;
            this.lbID.Text = "XXXXXXXXXX";
            this.lbID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 23);
            this.label12.TabIndex = 40;
            this.label12.Text = "อายุ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 39;
            this.label7.Text = "ส่วนสูง";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 38;
            this.label8.Text = "น้ำหนัก";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 23);
            this.label9.TabIndex = 37;
            this.label9.Text = "ว/ด/ป เกิด";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 23);
            this.label10.TabIndex = 36;
            this.label10.Text = "ชื่อ-สกุล";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 23);
            this.label11.TabIndex = 35;
            this.label11.Text = "ID Card";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox4
            // 
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(464, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(451, 451);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "รางวัลที่ 1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btImage);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(341, 427);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(193, 188);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            // 
            // btImage
            // 
            this.btImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btImage.Location = new System.Drawing.Point(145, 133);
            this.btImage.Name = "btImage";
            this.btImage.Size = new System.Drawing.Size(35, 35);
            this.btImage.TabIndex = 35;
            this.btImage.Text = "...";
            this.btImage.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::DTIWinformProject.Properties.Resources.marvel1;
            this.pictureBox1.Location = new System.Drawing.Point(15, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(464, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(451, 451);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "รางวัลที่ 1";
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btExit.Image = global::DTIWinformProject.Properties.Resources.exit1;
            this.btExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExit.Location = new System.Drawing.Point(76, 565);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(227, 50);
            this.btExit.TabIndex = 33;
            this.btExit.Text = "จบโปรแกรม";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btDooduang
            // 
            this.btDooduang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btDooduang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDooduang.Image = global::DTIWinformProject.Properties.Resources.find1;
            this.btDooduang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDooduang.Location = new System.Drawing.Point(76, 491);
            this.btDooduang.Name = "btDooduang";
            this.btDooduang.Size = new System.Drawing.Size(227, 50);
            this.btDooduang.TabIndex = 32;
            this.btDooduang.Text = "ดูดวง";
            this.btDooduang.UseVisualStyleBackColor = false;
            this.btDooduang.Click += new System.EventHandler(this.btDooduang_Click);
            // 
            // btNew
            // 
            this.btNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btNew.Image = global::DTIWinformProject.Properties.Resources.new1;
            this.btNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNew.Location = new System.Drawing.Point(76, 427);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(227, 50);
            this.btNew.TabIndex = 31;
            this.btNew.Text = "ใหม่";
            this.btNew.UseVisualStyleBackColor = false;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.button1.Location = new System.Drawing.Point(853, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 119);
            this.button1.TabIndex = 26;
            this.button1.Text = "หน้าจอหลัก";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(262, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 23);
            this.label13.TabIndex = 38;
            this.label13.Text = "กิโลกรัม";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(262, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 23);
            this.label14.TabIndex = 39;
            this.label14.Text = "เซนติเมตร";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(270, 225);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 23);
            this.label15.TabIndex = 41;
            this.label15.Text = "เซนติเมตร";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(270, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 23);
            this.label16.TabIndex = 40;
            this.label16.Text = "กิโลกรัม";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmDooDuang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDooduang);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmDooDuang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ดูดวงแม่นๆ - DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmDooDuang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.MaskedTextBox mtbID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btDooduang;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btImage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbBMI;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}