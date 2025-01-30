namespace DTIWinformProject
{
    partial class FrmShapeArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShapeArea));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.วงกลม = new System.Windows.Forms.TabPage();
            this.btCircleCancel = new System.Windows.Forms.Button();
            this.btCircleCal = new System.Windows.Forms.Button();
            this.lbCircleResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbCircleRound = new System.Windows.Forms.RadioButton();
            this.rdbCircleArea = new System.Windows.Forms.RadioButton();
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.สี่เหลี่ยม = new System.Windows.Forms.TabPage();
            this.tbRectHeight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btRectCancel = new System.Windows.Forms.Button();
            this.btRectCal = new System.Windows.Forms.Button();
            this.lbRectResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbRectRound = new System.Windows.Forms.RadioButton();
            this.rdbRectArea = new System.Windows.Forms.RadioButton();
            this.tbRectWidth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.สามเหลี่ยมมุมฉาก = new System.Windows.Forms.TabPage();
            this.tbTriSideAngle = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbTriLong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btTriCancel = new System.Windows.Forms.Button();
            this.btTriCal = new System.Windows.Forms.Button();
            this.lbTriResult = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rdbTriRound = new System.Windows.Forms.RadioButton();
            this.rdbTriArea = new System.Windows.Forms.RadioButton();
            this.tbTriWidth = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.วงกลม.SuspendLayout();
            this.สี่เหลี่ยม.SuspendLayout();
            this.สามเหลี่ยมมุมฉาก.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.วงกลม);
            this.tabControl1.Controls.Add(this.สี่เหลี่ยม);
            this.tabControl1.Controls.Add(this.สามเหลี่ยมมุมฉาก);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(86, 177);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(915, 391);
            this.tabControl1.TabIndex = 0;
            // 
            // วงกลม
            // 
            this.วงกลม.Controls.Add(this.btCircleCancel);
            this.วงกลม.Controls.Add(this.btCircleCal);
            this.วงกลม.Controls.Add(this.lbCircleResult);
            this.วงกลม.Controls.Add(this.label3);
            this.วงกลม.Controls.Add(this.rdbCircleRound);
            this.วงกลม.Controls.Add(this.rdbCircleArea);
            this.วงกลม.Controls.Add(this.tbRadius);
            this.วงกลม.Controls.Add(this.label2);
            this.วงกลม.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.วงกลม.Location = new System.Drawing.Point(4, 33);
            this.วงกลม.Name = "วงกลม";
            this.วงกลม.Padding = new System.Windows.Forms.Padding(3);
            this.วงกลม.Size = new System.Drawing.Size(907, 354);
            this.วงกลม.TabIndex = 0;
            this.วงกลม.Text = "วงกลม";
            this.วงกลม.UseVisualStyleBackColor = true;
            // 
            // btCircleCancel
            // 
            this.btCircleCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCircleCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCircleCancel.Image = global::DTIWinformProject.Properties.Resources.cancel5;
            this.btCircleCancel.Location = new System.Drawing.Point(657, 206);
            this.btCircleCancel.Name = "btCircleCancel";
            this.btCircleCancel.Size = new System.Drawing.Size(160, 50);
            this.btCircleCancel.TabIndex = 58;
            this.btCircleCancel.Text = "ยกเลิก";
            this.btCircleCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCircleCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCircleCancel.UseVisualStyleBackColor = false;
            this.btCircleCancel.Click += new System.EventHandler(this.btCircleCancel_Click);
            // 
            // btCircleCal
            // 
            this.btCircleCal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCircleCal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCircleCal.Image = global::DTIWinformProject.Properties.Resources.calculator22;
            this.btCircleCal.Location = new System.Drawing.Point(657, 123);
            this.btCircleCal.Name = "btCircleCal";
            this.btCircleCal.Size = new System.Drawing.Size(160, 50);
            this.btCircleCal.TabIndex = 57;
            this.btCircleCal.Text = "คำนวณ";
            this.btCircleCal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCircleCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCircleCal.UseVisualStyleBackColor = false;
            this.btCircleCal.Click += new System.EventHandler(this.btCircleCal_Click);
            // 
            // lbCircleResult
            // 
            this.lbCircleResult.BackColor = System.Drawing.Color.Yellow;
            this.lbCircleResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCircleResult.ForeColor = System.Drawing.Color.Red;
            this.lbCircleResult.Location = new System.Drawing.Point(87, 257);
            this.lbCircleResult.Name = "lbCircleResult";
            this.lbCircleResult.Size = new System.Drawing.Size(481, 61);
            this.lbCircleResult.TabIndex = 28;
            this.lbCircleResult.Text = "0.00";
            this.lbCircleResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "ผลลัพธ์";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdbCircleRound
            // 
            this.rdbCircleRound.AutoSize = true;
            this.rdbCircleRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCircleRound.Location = new System.Drawing.Point(93, 168);
            this.rdbCircleRound.Name = "rdbCircleRound";
            this.rdbCircleRound.Size = new System.Drawing.Size(128, 28);
            this.rdbCircleRound.TabIndex = 55;
            this.rdbCircleRound.Text = "เส้นรอบวงกลม";
            this.rdbCircleRound.UseVisualStyleBackColor = true;
            // 
            // rdbCircleArea
            // 
            this.rdbCircleArea.AutoSize = true;
            this.rdbCircleArea.Checked = true;
            this.rdbCircleArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCircleArea.Location = new System.Drawing.Point(93, 123);
            this.rdbCircleArea.Name = "rdbCircleArea";
            this.rdbCircleArea.Size = new System.Drawing.Size(110, 28);
            this.rdbCircleArea.TabIndex = 54;
            this.rdbCircleArea.TabStop = true;
            this.rdbCircleArea.Text = "พื้นที่วงกลม";
            this.rdbCircleArea.UseVisualStyleBackColor = true;
            this.rdbCircleArea.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tbRadius
            // 
            this.tbRadius.Location = new System.Drawing.Point(93, 71);
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(475, 26);
            this.tbRadius.TabIndex = 4;
            this.tbRadius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRadius_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "ป้อนรัศมี";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // สี่เหลี่ยม
            // 
            this.สี่เหลี่ยม.Controls.Add(this.tbRectHeight);
            this.สี่เหลี่ยม.Controls.Add(this.label8);
            this.สี่เหลี่ยม.Controls.Add(this.btRectCancel);
            this.สี่เหลี่ยม.Controls.Add(this.btRectCal);
            this.สี่เหลี่ยม.Controls.Add(this.lbRectResult);
            this.สี่เหลี่ยม.Controls.Add(this.label6);
            this.สี่เหลี่ยม.Controls.Add(this.rdbRectRound);
            this.สี่เหลี่ยม.Controls.Add(this.rdbRectArea);
            this.สี่เหลี่ยม.Controls.Add(this.tbRectWidth);
            this.สี่เหลี่ยม.Controls.Add(this.label7);
            this.สี่เหลี่ยม.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.สี่เหลี่ยม.Location = new System.Drawing.Point(4, 33);
            this.สี่เหลี่ยม.Name = "สี่เหลี่ยม";
            this.สี่เหลี่ยม.Padding = new System.Windows.Forms.Padding(3);
            this.สี่เหลี่ยม.Size = new System.Drawing.Size(907, 354);
            this.สี่เหลี่ยม.TabIndex = 1;
            this.สี่เหลี่ยม.Text = "สี่เหลี่ยม";
            this.สี่เหลี่ยม.UseVisualStyleBackColor = true;
            // 
            // tbRectHeight
            // 
            this.tbRectHeight.Location = new System.Drawing.Point(355, 72);
            this.tbRectHeight.Name = "tbRectHeight";
            this.tbRectHeight.Size = new System.Drawing.Size(211, 26);
            this.tbRectHeight.TabIndex = 68;
            this.tbRectHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRectHeight_KeyPress);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(351, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 67;
            this.label8.Text = "ป้อนยาว";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btRectCancel
            // 
            this.btRectCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btRectCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRectCancel.Image = global::DTIWinformProject.Properties.Resources.cancel5;
            this.btRectCancel.Location = new System.Drawing.Point(658, 207);
            this.btRectCancel.Name = "btRectCancel";
            this.btRectCancel.Size = new System.Drawing.Size(160, 50);
            this.btRectCancel.TabIndex = 66;
            this.btRectCancel.Text = "ยกเลิก";
            this.btRectCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRectCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRectCancel.UseVisualStyleBackColor = false;
            this.btRectCancel.Click += new System.EventHandler(this.btRectCancel_Click);
            // 
            // btRectCal
            // 
            this.btRectCal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btRectCal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRectCal.Image = global::DTIWinformProject.Properties.Resources.calculator22;
            this.btRectCal.Location = new System.Drawing.Point(658, 124);
            this.btRectCal.Name = "btRectCal";
            this.btRectCal.Size = new System.Drawing.Size(160, 50);
            this.btRectCal.TabIndex = 65;
            this.btRectCal.Text = "คำนวณ";
            this.btRectCal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRectCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRectCal.UseVisualStyleBackColor = false;
            this.btRectCal.Click += new System.EventHandler(this.btRectCal_Click);
            // 
            // lbRectResult
            // 
            this.lbRectResult.BackColor = System.Drawing.Color.Yellow;
            this.lbRectResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRectResult.ForeColor = System.Drawing.Color.Red;
            this.lbRectResult.Location = new System.Drawing.Point(88, 258);
            this.lbRectResult.Name = "lbRectResult";
            this.lbRectResult.Size = new System.Drawing.Size(481, 61);
            this.lbRectResult.TabIndex = 61;
            this.lbRectResult.Text = "0.00";
            this.lbRectResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 64;
            this.label6.Text = "ผลลัพธ์";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdbRectRound
            // 
            this.rdbRectRound.AutoSize = true;
            this.rdbRectRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRectRound.Location = new System.Drawing.Point(94, 169);
            this.rdbRectRound.Name = "rdbRectRound";
            this.rdbRectRound.Size = new System.Drawing.Size(139, 28);
            this.rdbRectRound.TabIndex = 63;
            this.rdbRectRound.Text = "เส้นรอบสี่เหลี่ยม";
            this.rdbRectRound.UseVisualStyleBackColor = true;
            // 
            // rdbRectArea
            // 
            this.rdbRectArea.AutoSize = true;
            this.rdbRectArea.Checked = true;
            this.rdbRectArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRectArea.Location = new System.Drawing.Point(94, 124);
            this.rdbRectArea.Name = "rdbRectArea";
            this.rdbRectArea.Size = new System.Drawing.Size(121, 28);
            this.rdbRectArea.TabIndex = 62;
            this.rdbRectArea.TabStop = true;
            this.rdbRectArea.Text = "พื้นที่สี่เหลี่ยม";
            this.rdbRectArea.UseVisualStyleBackColor = true;
            // 
            // tbRectWidth
            // 
            this.tbRectWidth.Location = new System.Drawing.Point(94, 72);
            this.tbRectWidth.Name = "tbRectWidth";
            this.tbRectWidth.Size = new System.Drawing.Size(211, 26);
            this.tbRectWidth.TabIndex = 60;
            this.tbRectWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRectWidth_KeyPress);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 59;
            this.label7.Text = "ป้อนกว้าง";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // สามเหลี่ยมมุมฉาก
            // 
            this.สามเหลี่ยมมุมฉาก.Controls.Add(this.tbTriSideAngle);
            this.สามเหลี่ยมมุมฉาก.Controls.Add(this.label13);
            this.สามเหลี่ยมมุมฉาก.Controls.Add(this.tbTriLong);
            this.สามเหลี่ยมมุมฉาก.Controls.Add(this.label9);
            this.สามเหลี่ยมมุมฉาก.Controls.Add(this.btTriCancel);
            this.สามเหลี่ยมมุมฉาก.Controls.Add(this.btTriCal);
            this.สามเหลี่ยมมุมฉาก.Controls.Add(this.lbTriResult);
            this.สามเหลี่ยมมุมฉาก.Controls.Add(this.label11);
            this.สามเหลี่ยมมุมฉาก.Controls.Add(this.rdbTriRound);
            this.สามเหลี่ยมมุมฉาก.Controls.Add(this.rdbTriArea);
            this.สามเหลี่ยมมุมฉาก.Controls.Add(this.tbTriWidth);
            this.สามเหลี่ยมมุมฉาก.Controls.Add(this.label12);
            this.สามเหลี่ยมมุมฉาก.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.สามเหลี่ยมมุมฉาก.Location = new System.Drawing.Point(4, 33);
            this.สามเหลี่ยมมุมฉาก.Name = "สามเหลี่ยมมุมฉาก";
            this.สามเหลี่ยมมุมฉาก.Size = new System.Drawing.Size(907, 354);
            this.สามเหลี่ยมมุมฉาก.TabIndex = 2;
            this.สามเหลี่ยมมุมฉาก.Text = "สามเหลี่ยมมุมฉาก";
            this.สามเหลี่ยมมุมฉาก.UseVisualStyleBackColor = true;
            // 
            // tbTriSideAngle
            // 
            this.tbTriSideAngle.Location = new System.Drawing.Point(616, 72);
            this.tbTriSideAngle.Name = "tbTriSideAngle";
            this.tbTriSideAngle.Size = new System.Drawing.Size(211, 26);
            this.tbTriSideAngle.TabIndex = 80;
            this.tbTriSideAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTriSideAngle_KeyPress);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(612, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(205, 33);
            this.label13.TabIndex = 79;
            this.label13.Text = "ป้อนด้านตรงข้ามมุมฉาก";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbTriLong
            // 
            this.tbTriLong.Location = new System.Drawing.Point(355, 72);
            this.tbTriLong.Name = "tbTriLong";
            this.tbTriLong.Size = new System.Drawing.Size(211, 26);
            this.tbTriLong.TabIndex = 78;
            this.tbTriLong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTriLong_KeyPress);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(351, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 77;
            this.label9.Text = "ป้อนยาว";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btTriCancel
            // 
            this.btTriCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btTriCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTriCancel.Image = global::DTIWinformProject.Properties.Resources.cancel5;
            this.btTriCancel.Location = new System.Drawing.Point(657, 230);
            this.btTriCancel.Name = "btTriCancel";
            this.btTriCancel.Size = new System.Drawing.Size(160, 50);
            this.btTriCancel.TabIndex = 76;
            this.btTriCancel.Text = "ยกเลิก";
            this.btTriCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTriCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTriCancel.UseVisualStyleBackColor = false;
            this.btTriCancel.Click += new System.EventHandler(this.btTriCancel_Click);
            // 
            // btTriCal
            // 
            this.btTriCal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btTriCal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTriCal.Image = global::DTIWinformProject.Properties.Resources.calculator22;
            this.btTriCal.Location = new System.Drawing.Point(657, 147);
            this.btTriCal.Name = "btTriCal";
            this.btTriCal.Size = new System.Drawing.Size(160, 50);
            this.btTriCal.TabIndex = 75;
            this.btTriCal.Text = "คำนวณ";
            this.btTriCal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTriCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTriCal.UseVisualStyleBackColor = false;
            this.btTriCal.Click += new System.EventHandler(this.btTriCal_Click);
            // 
            // lbTriResult
            // 
            this.lbTriResult.BackColor = System.Drawing.Color.Yellow;
            this.lbTriResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTriResult.ForeColor = System.Drawing.Color.Red;
            this.lbTriResult.Location = new System.Drawing.Point(88, 258);
            this.lbTriResult.Name = "lbTriResult";
            this.lbTriResult.Size = new System.Drawing.Size(481, 61);
            this.lbTriResult.TabIndex = 71;
            this.lbTriResult.Text = "0.00";
            this.lbTriResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(104, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 74;
            this.label11.Text = "ผลลัพธ์";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdbTriRound
            // 
            this.rdbTriRound.AutoSize = true;
            this.rdbTriRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTriRound.Location = new System.Drawing.Point(94, 169);
            this.rdbTriRound.Name = "rdbTriRound";
            this.rdbTriRound.Size = new System.Drawing.Size(158, 28);
            this.rdbTriRound.TabIndex = 73;
            this.rdbTriRound.Text = "เส้นรอบสามเหลี่ยม";
            this.rdbTriRound.UseVisualStyleBackColor = true;
            // 
            // rdbTriArea
            // 
            this.rdbTriArea.AutoSize = true;
            this.rdbTriArea.Checked = true;
            this.rdbTriArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTriArea.Location = new System.Drawing.Point(94, 124);
            this.rdbTriArea.Name = "rdbTriArea";
            this.rdbTriArea.Size = new System.Drawing.Size(140, 28);
            this.rdbTriArea.TabIndex = 72;
            this.rdbTriArea.TabStop = true;
            this.rdbTriArea.Text = "พื้นที่สามเหลี่ยม";
            this.rdbTriArea.UseVisualStyleBackColor = true;
            // 
            // tbTriWidth
            // 
            this.tbTriWidth.Location = new System.Drawing.Point(94, 72);
            this.tbTriWidth.Name = "tbTriWidth";
            this.tbTriWidth.Size = new System.Drawing.Size(211, 26);
            this.tbTriWidth.TabIndex = 70;
            this.tbTriWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTriWidth_KeyPress);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(90, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 69;
            this.label12.Text = "ป้อนกว้าง";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(80, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(750, 119);
            this.label1.TabIndex = 25;
            this.label1.Text = "คำนวณรูปทรง";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.toolStrip1.TabIndex = 27;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.button1.Location = new System.Drawing.Point(863, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 119);
            this.button1.TabIndex = 26;
            this.button1.Text = "คำนวณรูปทรง";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmShapeArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmShapeArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "คำนวณรูปทรง - DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmShapeArea_Load);
            this.tabControl1.ResumeLayout(false);
            this.วงกลม.ResumeLayout(false);
            this.วงกลม.PerformLayout();
            this.สี่เหลี่ยม.ResumeLayout(false);
            this.สี่เหลี่ยม.PerformLayout();
            this.สามเหลี่ยมมุมฉาก.ResumeLayout(false);
            this.สามเหลี่ยมมุมฉาก.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage วงกลม;
        private System.Windows.Forms.TabPage สี่เหลี่ยม;
        private System.Windows.Forms.TabPage สามเหลี่ยมมุมฉาก;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRadius;
        private System.Windows.Forms.RadioButton rdbCircleArea;
        private System.Windows.Forms.RadioButton rdbCircleRound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCircleResult;
        private System.Windows.Forms.Button btCircleCal;
        private System.Windows.Forms.Button btCircleCancel;
        private System.Windows.Forms.TextBox tbRectHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btRectCancel;
        private System.Windows.Forms.Button btRectCal;
        private System.Windows.Forms.Label lbRectResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbRectRound;
        private System.Windows.Forms.RadioButton rdbRectArea;
        private System.Windows.Forms.TextBox tbRectWidth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTriSideAngle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbTriLong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btTriCancel;
        private System.Windows.Forms.Button btTriCal;
        private System.Windows.Forms.Label lbTriResult;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rdbTriRound;
        private System.Windows.Forms.RadioButton rdbTriArea;
        private System.Windows.Forms.TextBox tbTriWidth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer1;
    }
}