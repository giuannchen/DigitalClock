﻿namespace OrderDiscount3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCard3 = new System.Windows.Forms.RadioButton();
            this.radioCard2 = new System.Windows.Forms.RadioButton();
            this.radioCard1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buyer = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCard3);
            this.groupBox1.Controls.Add(this.radioCard2);
            this.groupBox1.Controls.Add(this.radioCard1);
            this.groupBox1.Location = new System.Drawing.Point(35, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "折扣方法";
            // 
            // radioCard3
            // 
            this.radioCard3.AutoSize = true;
            this.radioCard3.Checked = true;
            this.radioCard3.Location = new System.Drawing.Point(182, 25);
            this.radioCard3.Name = "radioCard3";
            this.radioCard3.Size = new System.Drawing.Size(73, 19);
            this.radioCard3.TabIndex = 2;
            this.radioCard3.TabStop = true;
            this.radioCard3.Text = "花旗卡";
            this.radioCard3.UseVisualStyleBackColor = true;
            // 
            // radioCard2
            // 
            this.radioCard2.AutoSize = true;
            this.radioCard2.Checked = true;
            this.radioCard2.Location = new System.Drawing.Point(103, 24);
            this.radioCard2.Name = "radioCard2";
            this.radioCard2.Size = new System.Drawing.Size(73, 19);
            this.radioCard2.TabIndex = 1;
            this.radioCard2.TabStop = true;
            this.radioCard2.Text = "台新卡";
            this.radioCard2.UseVisualStyleBackColor = true;
            // 
            // radioCard1
            // 
            this.radioCard1.AutoSize = true;
            this.radioCard1.Checked = true;
            this.radioCard1.Location = new System.Drawing.Point(7, 25);
            this.radioCard1.Name = "radioCard1";
            this.radioCard1.Size = new System.Drawing.Size(73, 19);
            this.radioCard1.TabIndex = 0;
            this.radioCard1.TabStop = true;
            this.radioCard1.Text = "中信卡";
            this.radioCard1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(35, 195);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(193, 25);
            this.amount.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "購買金額";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(422, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(516, 229);
            this.listBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "購買人";
            // 
            // buyer
            // 
            this.buyer.Location = new System.Drawing.Point(35, 129);
            this.buyer.Name = "buyer";
            this.buyer.Size = new System.Drawing.Size(193, 25);
            this.buyer.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 288);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buyer);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "DP12";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioCard2;
        private System.Windows.Forms.RadioButton radioCard1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radioCard3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox buyer;
    }
}

