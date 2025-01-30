namespace DTIWinformProject
{
    partial class FrmLotto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLotto));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btLotto1 = new System.Windows.Forms.Button();
            this.lbLotto1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbLotto2_2 = new System.Windows.Forms.Label();
            this.btLotto2 = new System.Windows.Forms.Button();
            this.lbLotto2_1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btLotto3 = new System.Windows.Forms.Button();
            this.lbLotto3_2 = new System.Windows.Forms.Label();
            this.lbLotto3_1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btLotto4 = new System.Windows.Forms.Button();
            this.lbLotto4 = new System.Windows.Forms.Label();
            this.rdbClose = new System.Windows.Forms.RadioButton();
            this.rdbOpen = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStrip1.TabIndex = 19;
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(72, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(750, 119);
            this.label1.TabIndex = 23;
            this.label1.Text = "Lotto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(400, 166);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(380, 20);
            this.dtpDate.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "ประจำงวดวันที่";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btLotto1);
            this.groupBox1.Controls.Add(this.lbLotto1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(153, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 101);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "รางวัลที่ 1";
            // 
            // btLotto1
            // 
            this.btLotto1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btLotto1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLotto1.Image = global::DTIWinformProject.Properties.Resources.start2;
            this.btLotto1.Location = new System.Drawing.Point(675, 22);
            this.btLotto1.Name = "btLotto1";
            this.btLotto1.Size = new System.Drawing.Size(71, 63);
            this.btLotto1.TabIndex = 28;
            this.btLotto1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLotto1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btLotto1.UseVisualStyleBackColor = false;
            this.btLotto1.Click += new System.EventHandler(this.btLotto1_Click);
            // 
            // lbLotto1
            // 
            this.lbLotto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLotto1.ForeColor = System.Drawing.Color.Red;
            this.lbLotto1.Location = new System.Drawing.Point(272, 22);
            this.lbLotto1.Name = "lbLotto1";
            this.lbLotto1.Size = new System.Drawing.Size(211, 69);
            this.lbLotto1.TabIndex = 28;
            this.lbLotto1.Text = "??????";
            this.lbLotto1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.button1.Location = new System.Drawing.Point(855, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 119);
            this.button1.TabIndex = 24;
            this.button1.Text = "หน้าจอหลัก";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbLotto2_2);
            this.groupBox2.Controls.Add(this.btLotto2);
            this.groupBox2.Controls.Add(this.lbLotto2_1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(153, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 140);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "รางววัล 3 ตัวบน";
            // 
            // lbLotto2_2
            // 
            this.lbLotto2_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLotto2_2.ForeColor = System.Drawing.Color.Red;
            this.lbLotto2_2.Location = new System.Drawing.Point(72, 88);
            this.lbLotto2_2.Name = "lbLotto2_2";
            this.lbLotto2_2.Size = new System.Drawing.Size(155, 42);
            this.lbLotto2_2.TabIndex = 29;
            this.lbLotto2_2.Text = "???";
            this.lbLotto2_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btLotto2
            // 
            this.btLotto2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btLotto2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLotto2.Image = global::DTIWinformProject.Properties.Resources.start2;
            this.btLotto2.Location = new System.Drawing.Point(278, 38);
            this.btLotto2.Name = "btLotto2";
            this.btLotto2.Size = new System.Drawing.Size(71, 63);
            this.btLotto2.TabIndex = 28;
            this.btLotto2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLotto2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btLotto2.UseVisualStyleBackColor = false;
            this.btLotto2.Click += new System.EventHandler(this.btLotto2_Click);
            // 
            // lbLotto2_1
            // 
            this.lbLotto2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLotto2_1.ForeColor = System.Drawing.Color.Red;
            this.lbLotto2_1.Location = new System.Drawing.Point(72, 25);
            this.lbLotto2_1.Name = "lbLotto2_1";
            this.lbLotto2_1.Size = new System.Drawing.Size(155, 42);
            this.lbLotto2_1.TabIndex = 28;
            this.lbLotto2_1.Text = "???";
            this.lbLotto2_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btLotto3);
            this.groupBox3.Controls.Add(this.lbLotto3_2);
            this.groupBox3.Controls.Add(this.lbLotto3_1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(554, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 140);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "รางววัล 3 ตัวล่าง";
            // 
            // btLotto3
            // 
            this.btLotto3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btLotto3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLotto3.Image = global::DTIWinformProject.Properties.Resources.start2;
            this.btLotto3.Location = new System.Drawing.Point(274, 38);
            this.btLotto3.Name = "btLotto3";
            this.btLotto3.Size = new System.Drawing.Size(71, 63);
            this.btLotto3.TabIndex = 30;
            this.btLotto3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLotto3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btLotto3.UseVisualStyleBackColor = false;
            this.btLotto3.Click += new System.EventHandler(this.btLotto3_Click);
            // 
            // lbLotto3_2
            // 
            this.lbLotto3_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLotto3_2.ForeColor = System.Drawing.Color.Red;
            this.lbLotto3_2.Location = new System.Drawing.Point(71, 88);
            this.lbLotto3_2.Name = "lbLotto3_2";
            this.lbLotto3_2.Size = new System.Drawing.Size(155, 42);
            this.lbLotto3_2.TabIndex = 29;
            this.lbLotto3_2.Text = "???";
            this.lbLotto3_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLotto3_1
            // 
            this.lbLotto3_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLotto3_1.ForeColor = System.Drawing.Color.Red;
            this.lbLotto3_1.Location = new System.Drawing.Point(71, 25);
            this.lbLotto3_1.Name = "lbLotto3_1";
            this.lbLotto3_1.Size = new System.Drawing.Size(155, 42);
            this.lbLotto3_1.TabIndex = 28;
            this.lbLotto3_1.Text = "???";
            this.lbLotto3_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btLotto4);
            this.groupBox4.Controls.Add(this.lbLotto4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(153, 529);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(374, 93);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "รางวัล 2 ตัวล่าง";
            // 
            // btLotto4
            // 
            this.btLotto4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btLotto4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLotto4.Image = global::DTIWinformProject.Properties.Resources.start2;
            this.btLotto4.Location = new System.Drawing.Point(278, 19);
            this.btLotto4.Name = "btLotto4";
            this.btLotto4.Size = new System.Drawing.Size(71, 63);
            this.btLotto4.TabIndex = 28;
            this.btLotto4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLotto4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btLotto4.UseVisualStyleBackColor = false;
            this.btLotto4.Click += new System.EventHandler(this.btLotto4_Click);
            // 
            // lbLotto4
            // 
            this.lbLotto4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLotto4.ForeColor = System.Drawing.Color.Red;
            this.lbLotto4.Location = new System.Drawing.Point(72, 40);
            this.lbLotto4.Name = "lbLotto4";
            this.lbLotto4.Size = new System.Drawing.Size(155, 42);
            this.lbLotto4.TabIndex = 28;
            this.lbLotto4.Text = "??";
            this.lbLotto4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbClose
            // 
            this.rdbClose.AutoSize = true;
            this.rdbClose.Checked = true;
            this.rdbClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbClose.Location = new System.Drawing.Point(653, 591);
            this.rdbClose.Name = "rdbClose";
            this.rdbClose.Size = new System.Drawing.Size(98, 20);
            this.rdbClose.TabIndex = 31;
            this.rdbClose.TabStop = true;
            this.rdbClose.Text = "ปิดการจับรางวัล";
            this.rdbClose.UseVisualStyleBackColor = true;
            this.rdbClose.Click += new System.EventHandler(this.rdbClose_Click);
            // 
            // rdbOpen
            // 
            this.rdbOpen.AutoSize = true;
            this.rdbOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOpen.Location = new System.Drawing.Point(653, 545);
            this.rdbOpen.Name = "rdbOpen";
            this.rdbOpen.Size = new System.Drawing.Size(101, 20);
            this.rdbOpen.TabIndex = 32;
            this.rdbOpen.Text = "เปิดการจับรางวัล";
            this.rdbOpen.UseVisualStyleBackColor = true;
            this.rdbOpen.Click += new System.EventHandler(this.rdbOpen_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmLotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.rdbOpen);
            this.Controls.Add(this.rdbClose);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLotto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lotto -- SAU Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmLotto_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbLotto1;
        private System.Windows.Forms.Button btLotto1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btLotto2;
        private System.Windows.Forms.Label lbLotto2_1;
        private System.Windows.Forms.Label lbLotto2_2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbLotto3_2;
        private System.Windows.Forms.Label lbLotto3_1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btLotto4;
        private System.Windows.Forms.Label lbLotto4;
        private System.Windows.Forms.RadioButton rdbClose;
        private System.Windows.Forms.RadioButton rdbOpen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btLotto3;
    }
}