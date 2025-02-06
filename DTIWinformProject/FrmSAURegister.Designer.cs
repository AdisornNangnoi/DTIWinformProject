namespace DTIWinformProject
{
    partial class FrmSAURegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSAURegister));
            this.mcdRegis = new System.Windows.Forms.MonthCalendar();
            this.lsbSubjectRegis = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNoRegis = new System.Windows.Forms.TextBox();
            this.tbNameRegis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdFundRegis = new System.Windows.Forms.RadioButton();
            this.rdNormalRegis = new System.Windows.Forms.RadioButton();
            this.btImageSelectRegis = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbLevelRegis = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.btSelectSub = new System.Windows.Forms.Button();
            this.btSelectAllSub = new System.Windows.Forms.Button();
            this.btUnselectSub = new System.Windows.Forms.Button();
            this.btUnselctAllSub = new System.Windows.Forms.Button();
            this.lsbSubjectSelectRegis = new System.Windows.Forms.ListBox();
            this.cbConfirm = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbImageRegis = new System.Windows.Forms.PictureBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btRegis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageRegis)).BeginInit();
            this.SuspendLayout();
            // 
            // mcdRegis
            // 
            this.mcdRegis.Location = new System.Drawing.Point(75, 195);
            this.mcdRegis.Name = "mcdRegis";
            this.mcdRegis.TabIndex = 0;
            // 
            // lsbSubjectRegis
            // 
            this.lsbSubjectRegis.FormattingEnabled = true;
            this.lsbSubjectRegis.Items.AddRange(new object[] {
            "ภาษาไทย",
            "ภาษาอังกฤษ",
            "ภาษาญี่ปุ่ม",
            "ภาษาจีน",
            "สังคมศึกษา",
            "คณิตศาสตร์",
            "พลศึกษา",
            "ประวัติศาสตร์",
            "คอมพิวเตอร์เบื้องต้น",
            "บัญชีเบื้องต้น",
            "กฏหมายเบื้องต้น",
            "เศรษฐศาสตร์เบื้องต้น",
            "หลักการบริหาร",
            "เคมี",
            "ชีววิทยา"});
            this.lsbSubjectRegis.Location = new System.Drawing.Point(75, 451);
            this.lsbSubjectRegis.Name = "lsbSubjectRegis";
            this.lsbSubjectRegis.Size = new System.Drawing.Size(178, 173);
            this.lsbSubjectRegis.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(69, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(750, 119);
            this.label1.TabIndex = 27;
            this.label1.Text = "ลงทะเบียนเรียน";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "วันที่ลงทะเบียน";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "เลขประจำตัวนักเรียน";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbNoRegis
            // 
            this.tbNoRegis.Location = new System.Drawing.Point(302, 189);
            this.tbNoRegis.MaxLength = 13;
            this.tbNoRegis.Name = "tbNoRegis";
            this.tbNoRegis.Size = new System.Drawing.Size(239, 20);
            this.tbNoRegis.TabIndex = 49;
            this.tbNoRegis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNoRegis_KeyPress);
            // 
            // tbNameRegis
            // 
            this.tbNameRegis.Location = new System.Drawing.Point(302, 245);
            this.tbNameRegis.Name = "tbNameRegis";
            this.tbNameRegis.Size = new System.Drawing.Size(239, 20);
            this.tbNameRegis.TabIndex = 51;
            this.tbNameRegis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNameRegis_KeyPress);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 23);
            this.label4.TabIndex = 50;
            this.label4.Text = "ชื่อ-สกุล";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 23);
            this.label5.TabIndex = 52;
            this.label5.Text = "ประเภทนักเรียน";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdFundRegis
            // 
            this.rdFundRegis.AutoSize = true;
            this.rdFundRegis.Location = new System.Drawing.Point(374, 316);
            this.rdFundRegis.Name = "rdFundRegis";
            this.rdFundRegis.Size = new System.Drawing.Size(64, 17);
            this.rdFundRegis.TabIndex = 54;
            this.rdFundRegis.Text = "กองทุนฯ";
            this.rdFundRegis.UseVisualStyleBackColor = true;
            // 
            // rdNormalRegis
            // 
            this.rdNormalRegis.AutoSize = true;
            this.rdNormalRegis.Checked = true;
            this.rdNormalRegis.Location = new System.Drawing.Point(302, 316);
            this.rdNormalRegis.Name = "rdNormalRegis";
            this.rdNormalRegis.Size = new System.Drawing.Size(46, 17);
            this.rdNormalRegis.TabIndex = 53;
            this.rdNormalRegis.TabStop = true;
            this.rdNormalRegis.Text = "ปกติ";
            this.rdNormalRegis.UseVisualStyleBackColor = true;
            // 
            // btImageSelectRegis
            // 
            this.btImageSelectRegis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btImageSelectRegis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btImageSelectRegis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btImageSelectRegis.Location = new System.Drawing.Point(942, 366);
            this.btImageSelectRegis.Name = "btImageSelectRegis";
            this.btImageSelectRegis.Size = new System.Drawing.Size(48, 42);
            this.btImageSelectRegis.TabIndex = 55;
            this.btImageSelectRegis.Text = "...";
            this.btImageSelectRegis.UseVisualStyleBackColor = false;
            this.btImageSelectRegis.Click += new System.EventHandler(this.btImageSelectRegis_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 23);
            this.label6.TabIndex = 56;
            this.label6.Text = "ระดับชั้น";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbLevelRegis
            // 
            this.cbbLevelRegis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLevelRegis.FormattingEnabled = true;
            this.cbbLevelRegis.Items.AddRange(new object[] {
            "ชั้นมัธยมศึกษาปีที่ 1",
            "ชั้นมัธยมศึกษาปีที่ 2",
            "ชั้นมัธยมศึกษาปีที่ 3",
            "ชั้นมัธยมศึกษาปีที่ 4",
            "ชั้นมัธยมศึกษาปีที่ 5",
            "ชั้นมัธยมศึกษาปีที่ 6"});
            this.cbbLevelRegis.Location = new System.Drawing.Point(75, 392);
            this.cbbLevelRegis.Name = "cbbLevelRegis";
            this.cbbLevelRegis.Size = new System.Drawing.Size(159, 21);
            this.cbbLevelRegis.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 23);
            this.label7.TabIndex = 58;
            this.label7.Text = "รายวิชาที่ลงทะเบียน";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.toolStrip1.TabIndex = 59;
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
            // btSelectSub
            // 
            this.btSelectSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btSelectSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSelectSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelectSub.ForeColor = System.Drawing.Color.Lime;
            this.btSelectSub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSelectSub.Location = new System.Drawing.Point(283, 451);
            this.btSelectSub.Name = "btSelectSub";
            this.btSelectSub.Size = new System.Drawing.Size(65, 35);
            this.btSelectSub.TabIndex = 60;
            this.btSelectSub.Text = ">";
            this.btSelectSub.UseVisualStyleBackColor = false;
            this.btSelectSub.Click += new System.EventHandler(this.btSelectSub_Click);
            // 
            // btSelectAllSub
            // 
            this.btSelectAllSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btSelectAllSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSelectAllSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelectAllSub.ForeColor = System.Drawing.Color.Lime;
            this.btSelectAllSub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSelectAllSub.Location = new System.Drawing.Point(283, 496);
            this.btSelectAllSub.Name = "btSelectAllSub";
            this.btSelectAllSub.Size = new System.Drawing.Size(65, 35);
            this.btSelectAllSub.TabIndex = 61;
            this.btSelectAllSub.Text = ">>";
            this.btSelectAllSub.UseVisualStyleBackColor = false;
            this.btSelectAllSub.Click += new System.EventHandler(this.btSelectAllSub_Click);
            // 
            // btUnselectSub
            // 
            this.btUnselectSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btUnselectSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btUnselectSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUnselectSub.ForeColor = System.Drawing.Color.Red;
            this.btUnselectSub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUnselectSub.Location = new System.Drawing.Point(283, 542);
            this.btUnselectSub.Name = "btUnselectSub";
            this.btUnselectSub.Size = new System.Drawing.Size(65, 35);
            this.btUnselectSub.TabIndex = 62;
            this.btUnselectSub.Text = "<";
            this.btUnselectSub.UseVisualStyleBackColor = false;
            this.btUnselectSub.Click += new System.EventHandler(this.btUnselectSub_Click);
            // 
            // btUnselctAllSub
            // 
            this.btUnselctAllSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btUnselctAllSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btUnselctAllSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUnselctAllSub.ForeColor = System.Drawing.Color.Red;
            this.btUnselctAllSub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUnselctAllSub.Location = new System.Drawing.Point(283, 587);
            this.btUnselctAllSub.Name = "btUnselctAllSub";
            this.btUnselctAllSub.Size = new System.Drawing.Size(65, 35);
            this.btUnselctAllSub.TabIndex = 63;
            this.btUnselctAllSub.Text = "<<";
            this.btUnselctAllSub.UseVisualStyleBackColor = false;
            this.btUnselctAllSub.Click += new System.EventHandler(this.btUnselctAllSub_Click);
            // 
            // lsbSubjectSelectRegis
            // 
            this.lsbSubjectSelectRegis.FormattingEnabled = true;
            this.lsbSubjectSelectRegis.Location = new System.Drawing.Point(374, 452);
            this.lsbSubjectSelectRegis.Name = "lsbSubjectSelectRegis";
            this.lsbSubjectSelectRegis.Size = new System.Drawing.Size(196, 173);
            this.lsbSubjectSelectRegis.TabIndex = 64;
            // 
            // cbConfirm
            // 
            this.cbConfirm.AutoSize = true;
            this.cbConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConfirm.Location = new System.Drawing.Point(614, 467);
            this.cbConfirm.Name = "cbConfirm";
            this.cbConfirm.Size = new System.Drawing.Size(118, 20);
            this.cbConfirm.TabIndex = 65;
            this.cbConfirm.Text = "ยืนยันการลงทะเบียน";
            this.cbConfirm.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbImageRegis
            // 
            this.pbImageRegis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImageRegis.Location = new System.Drawing.Point(614, 163);
            this.pbImageRegis.Name = "pbImageRegis";
            this.pbImageRegis.Size = new System.Drawing.Size(298, 245);
            this.pbImageRegis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageRegis.TabIndex = 69;
            this.pbImageRegis.TabStop = false;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Image = global::DTIWinformProject.Properties.Resources.cancel4;
            this.btCancel.Location = new System.Drawing.Point(614, 511);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(376, 51);
            this.btCancel.TabIndex = 68;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Image = global::DTIWinformProject.Properties.Resources.exit31;
            this.btExit.Location = new System.Drawing.Point(614, 571);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(376, 51);
            this.btExit.TabIndex = 67;
            this.btExit.Text = "ปิดโปรแกรม";
            this.btExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btRegis
            // 
            this.btRegis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btRegis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegis.Image = global::DTIWinformProject.Properties.Resources.add1;
            this.btRegis.Location = new System.Drawing.Point(790, 451);
            this.btRegis.Name = "btRegis";
            this.btRegis.Size = new System.Drawing.Size(200, 51);
            this.btRegis.TabIndex = 66;
            this.btRegis.Text = "ลงทะเบียน";
            this.btRegis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRegis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRegis.UseVisualStyleBackColor = false;
            this.btRegis.Click += new System.EventHandler(this.btRegis_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.button1.Location = new System.Drawing.Point(852, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 119);
            this.button1.TabIndex = 28;
            this.button1.Text = "หน้าจอหลัก";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSAURegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.pbImageRegis);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btRegis);
            this.Controls.Add(this.cbConfirm);
            this.Controls.Add(this.lsbSubjectSelectRegis);
            this.Controls.Add(this.btUnselctAllSub);
            this.Controls.Add(this.btUnselectSub);
            this.Controls.Add(this.btSelectAllSub);
            this.Controls.Add(this.btSelectSub);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbLevelRegis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btImageSelectRegis);
            this.Controls.Add(this.rdFundRegis);
            this.Controls.Add(this.rdNormalRegis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNameRegis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNoRegis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbSubjectRegis);
            this.Controls.Add(this.mcdRegis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSAURegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ลงทะเบียนเรียน - DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmSAURegister_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageRegis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcdRegis;
        private System.Windows.Forms.ListBox lsbSubjectRegis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNoRegis;
        private System.Windows.Forms.TextBox tbNameRegis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdFundRegis;
        private System.Windows.Forms.RadioButton rdNormalRegis;
        private System.Windows.Forms.Button btImageSelectRegis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbLevelRegis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.Button btSelectSub;
        private System.Windows.Forms.Button btSelectAllSub;
        private System.Windows.Forms.Button btUnselectSub;
        private System.Windows.Forms.Button btUnselctAllSub;
        private System.Windows.Forms.ListBox lsbSubjectSelectRegis;
        private System.Windows.Forms.CheckBox cbConfirm;
        private System.Windows.Forms.Button btRegis;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbImageRegis;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}