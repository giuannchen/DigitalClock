namespace CreditcardVerification
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCathy = new System.Windows.Forms.RadioButton();
            this.radioCtbc = new System.Windows.Forms.RadioButton();
            this.radioNccc = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.inputNum = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "驗證";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioNccc);
            this.groupBox1.Controls.Add(this.radioCtbc);
            this.groupBox1.Controls.Add(this.radioCathy);
            this.groupBox1.Location = new System.Drawing.Point(23, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "選擇銀行";
            // 
            // radioCathy
            // 
            this.radioCathy.AutoSize = true;
            this.radioCathy.Checked = true;
            this.radioCathy.Location = new System.Drawing.Point(6, 24);
            this.radioCathy.Name = "radioCathy";
            this.radioCathy.Size = new System.Drawing.Size(88, 19);
            this.radioCathy.TabIndex = 2;
            this.radioCathy.TabStop = true;
            this.radioCathy.Text = "國泰世華";
            this.radioCathy.UseVisualStyleBackColor = true;
            // 
            // radioCtbc
            // 
            this.radioCtbc.AutoSize = true;
            this.radioCtbc.Location = new System.Drawing.Point(6, 49);
            this.radioCtbc.Name = "radioCtbc";
            this.radioCtbc.Size = new System.Drawing.Size(88, 19);
            this.radioCtbc.TabIndex = 3;
            this.radioCtbc.Text = "中國信託";
            this.radioCtbc.UseVisualStyleBackColor = true;
            // 
            // radioNccc
            // 
            this.radioNccc.AutoSize = true;
            this.radioNccc.Location = new System.Drawing.Point(6, 74);
            this.radioNccc.Name = "radioNccc";
            this.radioNccc.Size = new System.Drawing.Size(56, 19);
            this.radioNccc.TabIndex = 4;
            this.radioNccc.Text = "NCC";
            this.radioNccc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(182, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "卡號";
            // 
            // inputNum
            // 
            this.inputNum.Location = new System.Drawing.Point(248, 43);
            this.inputNum.Name = "inputNum";
            this.inputNum.Size = new System.Drawing.Size(167, 25);
            this.inputNum.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(483, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(238, 184);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 255);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.inputNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "DP05";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioNccc;
        private System.Windows.Forms.RadioButton radioCtbc;
        private System.Windows.Forms.RadioButton radioCathy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNum;
        private System.Windows.Forms.ListBox listBox1;
    }
}

