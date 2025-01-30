namespace DTIWinformProject
{
    partial class FrmSAUShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSAUShop));
            this.label1 = new System.Windows.Forms.Label();
            this.cbPen = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCal = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPencil = new System.Windows.Forms.TextBox();
            this.cbPencil = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbEraser = new System.Windows.Forms.TextBox();
            this.cbEraser = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbRuler = new System.Windows.Forms.TextBox();
            this.cbRuler = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbBook = new System.Windows.Forms.TextBox();
            this.cbBook = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbbDiscount = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbPen = new System.Windows.Forms.Label();
            this.lbPencil = new System.Windows.Forms.Label();
            this.lbEraser = new System.Windows.Forms.Label();
            this.lbRuler = new System.Windows.Forms.Label();
            this.lbBook = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(76, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(750, 119);
            this.label1.TabIndex = 23;
            this.label1.Text = "SAU Shop";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbPen
            // 
            this.cbPen.AutoSize = true;
            this.cbPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPen.Location = new System.Drawing.Point(168, 254);
            this.cbPen.Name = "cbPen";
            this.cbPen.Size = new System.Drawing.Size(131, 22);
            this.cbPen.TabIndex = 25;
            this.cbPen.Text = "ปากกา 5 บาท/ด้าม";
            this.cbPen.UseVisualStyleBackColor = true;
            this.cbPen.Click += new System.EventHandler(this.cbPen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbResult);
            this.groupBox1.Controls.Add(this.btCancel);
            this.groupBox1.Controls.Add(this.btCal);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(107, 516);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 104);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // lbResult
            // 
            this.lbResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.Color.Red;
            this.lbResult.Location = new System.Drawing.Point(221, 39);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(190, 38);
            this.lbResult.TabIndex = 62;
            this.lbResult.Text = "0.00";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancel.Image = global::DTIWinformProject.Properties.Resources.cancel3;
            this.btCancel.Location = new System.Drawing.Point(695, 34);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(138, 51);
            this.btCancel.TabIndex = 58;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCal
            // 
            this.btCal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCal.Image = global::DTIWinformProject.Properties.Resources.calculator21;
            this.btCal.Location = new System.Drawing.Point(528, 34);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(138, 51);
            this.btCal.TabIndex = 56;
            this.btCal.Text = "คำนวณ";
            this.btCal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCal.UseVisualStyleBackColor = false;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(420, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 23);
            this.label17.TabIndex = 57;
            this.label17.Text = "บาท";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(25, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(183, 23);
            this.label16.TabIndex = 56;
            this.label16.Text = "รวมเป็นเงินทั้งสิ้น";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "รายการสินค้า";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "จำนวน";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(635, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "คิดเป็นเงิน";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPen
            // 
            this.tbPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPen.Location = new System.Drawing.Point(391, 252);
            this.tbPen.MaxLength = 3;
            this.tbPen.Name = "tbPen";
            this.tbPen.Size = new System.Drawing.Size(127, 24);
            this.tbPen.TabIndex = 30;
            this.tbPen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPen_KeyPress);
            this.tbPen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPen_KeyUp);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(524, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "ด้าม";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(759, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "บาท";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(759, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 38;
            this.label7.Text = "บาท";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(524, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 23);
            this.label8.TabIndex = 36;
            this.label8.Text = "ด้าม";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPencil
            // 
            this.tbPencil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPencil.Location = new System.Drawing.Point(391, 294);
            this.tbPencil.MaxLength = 3;
            this.tbPencil.Name = "tbPencil";
            this.tbPencil.Size = new System.Drawing.Size(127, 24);
            this.tbPencil.TabIndex = 35;
            this.tbPencil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPencil_KeyPress);
            this.tbPencil.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPencil_KeyUp);
            // 
            // cbPencil
            // 
            this.cbPencil.AutoSize = true;
            this.cbPencil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPencil.Location = new System.Drawing.Point(168, 296);
            this.cbPencil.Name = "cbPencil";
            this.cbPencil.Size = new System.Drawing.Size(147, 22);
            this.cbPencil.TabIndex = 34;
            this.cbPencil.Text = "ดินสอ 1.50 บาท/ด้าม";
            this.cbPencil.UseVisualStyleBackColor = true;
            this.cbPencil.Click += new System.EventHandler(this.cbPencil_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(759, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 23);
            this.label9.TabIndex = 43;
            this.label9.Text = "บาท";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(524, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 23);
            this.label10.TabIndex = 41;
            this.label10.Text = "ก้อน";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbEraser
            // 
            this.tbEraser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEraser.Location = new System.Drawing.Point(391, 337);
            this.tbEraser.MaxLength = 3;
            this.tbEraser.Name = "tbEraser";
            this.tbEraser.Size = new System.Drawing.Size(127, 24);
            this.tbEraser.TabIndex = 40;
            this.tbEraser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEraser_KeyPress);
            this.tbEraser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbEraser_KeyUp);
            // 
            // cbEraser
            // 
            this.cbEraser.AutoSize = true;
            this.cbEraser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEraser.Location = new System.Drawing.Point(168, 339);
            this.cbEraser.Name = "cbEraser";
            this.cbEraser.Size = new System.Drawing.Size(152, 22);
            this.cbEraser.TabIndex = 39;
            this.cbEraser.Text = "ยางลบ 2.50 บาท/ก้อน";
            this.cbEraser.UseVisualStyleBackColor = true;
            this.cbEraser.Click += new System.EventHandler(this.cbEraser_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(759, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 23);
            this.label11.TabIndex = 48;
            this.label11.Text = "บาท";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(524, 377);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 23);
            this.label12.TabIndex = 46;
            this.label12.Text = "อัน";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbRuler
            // 
            this.tbRuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRuler.Location = new System.Drawing.Point(391, 378);
            this.tbRuler.MaxLength = 3;
            this.tbRuler.Name = "tbRuler";
            this.tbRuler.Size = new System.Drawing.Size(127, 24);
            this.tbRuler.TabIndex = 45;
            this.tbRuler.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRuler_KeyPress);
            this.tbRuler.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRuler_KeyUp);
            // 
            // cbRuler
            // 
            this.cbRuler.AutoSize = true;
            this.cbRuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRuler.Location = new System.Drawing.Point(168, 380);
            this.cbRuler.Name = "cbRuler";
            this.cbRuler.Size = new System.Drawing.Size(144, 22);
            this.cbRuler.TabIndex = 44;
            this.cbRuler.Text = "ไม้บรรทัด 2 บาท/อัน";
            this.cbRuler.UseVisualStyleBackColor = true;
            this.cbRuler.Click += new System.EventHandler(this.cbRuler_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(759, 418);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 23);
            this.label13.TabIndex = 53;
            this.label13.Text = "บาท";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(524, 418);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 23);
            this.label14.TabIndex = 51;
            this.label14.Text = "เล่ม";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBook
            // 
            this.tbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBook.Location = new System.Drawing.Point(391, 419);
            this.tbBook.MaxLength = 3;
            this.tbBook.Name = "tbBook";
            this.tbBook.Size = new System.Drawing.Size(127, 24);
            this.tbBook.TabIndex = 50;
            this.tbBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBook_KeyPress);
            this.tbBook.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbBook_KeyUp);
            // 
            // cbBook
            // 
            this.cbBook.AutoSize = true;
            this.cbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBook.Location = new System.Drawing.Point(168, 421);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(144, 22);
            this.cbBook.TabIndex = 49;
            this.cbBook.Text = "สมุด 10.25 บาท/เล่ม";
            this.cbBook.UseVisualStyleBackColor = true;
            this.cbBook.Click += new System.EventHandler(this.cbBook_Click);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(260, 467);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 23);
            this.label15.TabIndex = 54;
            this.label15.Text = "ส่วนลด";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbDiscount
            // 
            this.cbbDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDiscount.FormattingEnabled = true;
            this.cbbDiscount.Items.AddRange(new object[] {
            "ส่วนลด 5%",
            "ส่วนลด 10%",
            "ส่วนลด 15%"});
            this.cbbDiscount.Location = new System.Drawing.Point(391, 469);
            this.cbbDiscount.Name = "cbbDiscount";
            this.cbbDiscount.Size = new System.Drawing.Size(127, 21);
            this.cbbDiscount.TabIndex = 55;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.button1.Location = new System.Drawing.Point(859, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 119);
            this.button1.TabIndex = 24;
            this.button1.Text = "หน้าจอหลัก";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.toolStrip1.TabIndex = 56;
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbPen
            // 
            this.lbPen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPen.ForeColor = System.Drawing.Color.Red;
            this.lbPen.Location = new System.Drawing.Point(588, 254);
            this.lbPen.Name = "lbPen";
            this.lbPen.Size = new System.Drawing.Size(165, 22);
            this.lbPen.TabIndex = 57;
            this.lbPen.Text = "0.00";
            this.lbPen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPencil
            // 
            this.lbPencil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbPencil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPencil.ForeColor = System.Drawing.Color.Red;
            this.lbPencil.Location = new System.Drawing.Point(588, 296);
            this.lbPencil.Name = "lbPencil";
            this.lbPencil.Size = new System.Drawing.Size(165, 22);
            this.lbPencil.TabIndex = 58;
            this.lbPencil.Text = "0.00";
            this.lbPencil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbEraser
            // 
            this.lbEraser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbEraser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEraser.ForeColor = System.Drawing.Color.Red;
            this.lbEraser.Location = new System.Drawing.Point(588, 339);
            this.lbEraser.Name = "lbEraser";
            this.lbEraser.Size = new System.Drawing.Size(165, 22);
            this.lbEraser.TabIndex = 59;
            this.lbEraser.Text = "0.00";
            this.lbEraser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbRuler
            // 
            this.lbRuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbRuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRuler.ForeColor = System.Drawing.Color.Red;
            this.lbRuler.Location = new System.Drawing.Point(588, 380);
            this.lbRuler.Name = "lbRuler";
            this.lbRuler.Size = new System.Drawing.Size(165, 22);
            this.lbRuler.TabIndex = 60;
            this.lbRuler.Text = "0.00";
            this.lbRuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbBook
            // 
            this.lbBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBook.ForeColor = System.Drawing.Color.Red;
            this.lbBook.Location = new System.Drawing.Point(588, 421);
            this.lbBook.Name = "lbBook";
            this.lbBook.Size = new System.Drawing.Size(165, 22);
            this.lbBook.TabIndex = 61;
            this.lbBook.Text = "0.00";
            this.lbBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmSAUShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.lbBook);
            this.Controls.Add(this.lbRuler);
            this.Controls.Add(this.lbEraser);
            this.Controls.Add(this.lbPencil);
            this.Controls.Add(this.lbPen);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cbbDiscount);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbBook);
            this.Controls.Add(this.cbBook);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbRuler);
            this.Controls.Add(this.cbRuler);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbEraser);
            this.Controls.Add(this.cbEraser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPencil);
            this.Controls.Add(this.cbPencil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbPen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSAUShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop - SAU Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmSAUShop_Load);
            this.groupBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbPen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPencil;
        private System.Windows.Forms.CheckBox cbPencil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbEraser;
        private System.Windows.Forms.CheckBox cbEraser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbRuler;
        private System.Windows.Forms.CheckBox cbRuler;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbBook;
        private System.Windows.Forms.CheckBox cbBook;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbbDiscount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbPen;
        private System.Windows.Forms.Label lbPencil;
        private System.Windows.Forms.Label lbEraser;
        private System.Windows.Forms.Label lbRuler;
        private System.Windows.Forms.Label lbBook;
    }
}