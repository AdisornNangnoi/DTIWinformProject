namespace DTIWinformProject
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.btLogout = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.btArea = new System.Windows.Forms.Button();
            this.btDooduang = new System.Windows.Forms.Button();
            this.btLotto = new System.Windows.Forms.Button();
            this.btShop = new System.Windows.Forms.Button();
            this.btCal = new System.Windows.Forms.Button();
            this.btWelcome = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(80, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(910, 119);
            this.label1.TabIndex = 1;
            this.label1.Text = "DTI Soft V.1.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btLogout.Image = global::DTIWinformProject.Properties.Resources.exitapp;
            this.btLogout.Location = new System.Drawing.Point(807, 425);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(180, 170);
            this.btLogout.TabIndex = 16;
            this.btLogout.Text = "ออกจากระบบ";
            this.btLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btRegister.Image = global::DTIWinformProject.Properties.Resources.menu6;
            this.btRegister.Location = new System.Drawing.Point(560, 425);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(180, 170);
            this.btRegister.TabIndex = 15;
            this.btRegister.Text = "Go to Register";
            this.btRegister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btArea
            // 
            this.btArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btArea.Image = global::DTIWinformProject.Properties.Resources.menu7;
            this.btArea.Location = new System.Drawing.Point(324, 425);
            this.btArea.Name = "btArea";
            this.btArea.Size = new System.Drawing.Size(180, 170);
            this.btArea.TabIndex = 14;
            this.btArea.Text = "Go to Shape Area";
            this.btArea.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btArea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btArea.UseVisualStyleBackColor = false;
            this.btArea.Click += new System.EventHandler(this.btArea_Click);
            // 
            // btDooduang
            // 
            this.btDooduang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btDooduang.Image = global::DTIWinformProject.Properties.Resources.menu5;
            this.btDooduang.Location = new System.Drawing.Point(83, 425);
            this.btDooduang.Name = "btDooduang";
            this.btDooduang.Size = new System.Drawing.Size(180, 170);
            this.btDooduang.TabIndex = 13;
            this.btDooduang.Text = "Go to Dooduang";
            this.btDooduang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btDooduang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btDooduang.UseVisualStyleBackColor = false;
            this.btDooduang.Click += new System.EventHandler(this.btDooduang_Click);
            // 
            // btLotto
            // 
            this.btLotto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btLotto.Image = global::DTIWinformProject.Properties.Resources.menu4;
            this.btLotto.Location = new System.Drawing.Point(807, 203);
            this.btLotto.Name = "btLotto";
            this.btLotto.Size = new System.Drawing.Size(180, 170);
            this.btLotto.TabIndex = 12;
            this.btLotto.Text = "Go to Lotto";
            this.btLotto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLotto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btLotto.UseVisualStyleBackColor = false;
            this.btLotto.Click += new System.EventHandler(this.btLotto_Click);
            // 
            // btShop
            // 
            this.btShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btShop.Image = global::DTIWinformProject.Properties.Resources.menu3;
            this.btShop.Location = new System.Drawing.Point(560, 203);
            this.btShop.Name = "btShop";
            this.btShop.Size = new System.Drawing.Size(180, 170);
            this.btShop.TabIndex = 11;
            this.btShop.Text = "Go to SAU Shop";
            this.btShop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btShop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btShop.UseVisualStyleBackColor = false;
            this.btShop.Click += new System.EventHandler(this.btShop_Click);
            // 
            // btCal
            // 
            this.btCal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCal.Image = global::DTIWinformProject.Properties.Resources.menu2;
            this.btCal.Location = new System.Drawing.Point(323, 203);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(180, 170);
            this.btCal.TabIndex = 10;
            this.btCal.Text = "Go to Calculator";
            this.btCal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCal.UseVisualStyleBackColor = false;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // btWelcome
            // 
            this.btWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btWelcome.Image = global::DTIWinformProject.Properties.Resources.menu1;
            this.btWelcome.Location = new System.Drawing.Point(83, 203);
            this.btWelcome.Name = "btWelcome";
            this.btWelcome.Size = new System.Drawing.Size(180, 170);
            this.btWelcome.TabIndex = 9;
            this.btWelcome.Text = "Go to Welcome";
            this.btWelcome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btWelcome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btWelcome.UseVisualStyleBackColor = false;
            this.btWelcome.Click += new System.EventHandler(this.btWelcome_Click);
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
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslbUsername
            // 
            this.tslbUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.btArea);
            this.Controls.Add(this.btDooduang);
            this.Controls.Add(this.btLotto);
            this.Controls.Add(this.btShop);
            this.Controls.Add(this.btCal);
            this.Controls.Add(this.btWelcome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอหลัก - DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btWelcome;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.Button btShop;
        private System.Windows.Forms.Button btLotto;
        private System.Windows.Forms.Button btDooduang;
        private System.Windows.Forms.Button btArea;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.Timer timer1;
    }
}