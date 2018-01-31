namespace Paint
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioText = new System.Windows.Forms.RadioButton();
            this.radioRectangle = new System.Windows.Forms.RadioButton();
            this.radioRound = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioWin32API = new System.Windows.Forms.RadioButton();
            this.radioGDIPlus = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(27, 170);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(827, 199);
            this.listBox1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.radioText);
            this.groupBox1.Controls.Add(this.radioRectangle);
            this.groupBox1.Controls.Add(this.radioRound);
            this.groupBox1.Location = new System.Drawing.Point(27, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 59);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "畫圖方法";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 25);
            this.textBox1.TabIndex = 8;
            // 
            // radioText
            // 
            this.radioText.AutoSize = true;
            this.radioText.Checked = true;
            this.radioText.Location = new System.Drawing.Point(182, 25);
            this.radioText.Name = "radioText";
            this.radioText.Size = new System.Drawing.Size(58, 19);
            this.radioText.TabIndex = 2;
            this.radioText.TabStop = true;
            this.radioText.Text = "文字";
            this.radioText.UseVisualStyleBackColor = true;
            // 
            // radioRectangle
            // 
            this.radioRectangle.AutoSize = true;
            this.radioRectangle.Checked = true;
            this.radioRectangle.Location = new System.Drawing.Point(103, 24);
            this.radioRectangle.Name = "radioRectangle";
            this.radioRectangle.Size = new System.Drawing.Size(73, 19);
            this.radioRectangle.TabIndex = 1;
            this.radioRectangle.TabStop = true;
            this.radioRectangle.Text = "長方形";
            this.radioRectangle.UseVisualStyleBackColor = true;
            // 
            // radioRound
            // 
            this.radioRound.AutoSize = true;
            this.radioRound.Checked = true;
            this.radioRound.Location = new System.Drawing.Point(7, 25);
            this.radioRound.Name = "radioRound";
            this.radioRound.Size = new System.Drawing.Size(58, 19);
            this.radioRound.TabIndex = 0;
            this.radioRound.TabStop = true;
            this.radioRound.Text = "圓形";
            this.radioRound.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "畫圖";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioWin32API);
            this.groupBox2.Controls.Add(this.radioGDIPlus);
            this.groupBox2.Location = new System.Drawing.Point(27, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 59);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "解析度";
            // 
            // radioWin32API
            // 
            this.radioWin32API.AutoSize = true;
            this.radioWin32API.Checked = true;
            this.radioWin32API.Location = new System.Drawing.Point(103, 24);
            this.radioWin32API.Name = "radioWin32API";
            this.radioWin32API.Size = new System.Drawing.Size(89, 19);
            this.radioWin32API.TabIndex = 1;
            this.radioWin32API.TabStop = true;
            this.radioWin32API.Text = "Win32API";
            this.radioWin32API.UseVisualStyleBackColor = true;
            // 
            // radioGDIPlus
            // 
            this.radioGDIPlus.AutoSize = true;
            this.radioGDIPlus.Checked = true;
            this.radioGDIPlus.Location = new System.Drawing.Point(7, 25);
            this.radioGDIPlus.Name = "radioGDIPlus";
            this.radioGDIPlus.Size = new System.Drawing.Size(77, 19);
            this.radioGDIPlus.TabIndex = 0;
            this.radioGDIPlus.TabStop = true;
            this.radioGDIPlus.Text = "GDIPlus";
            this.radioGDIPlus.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "列印";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 381);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "DP08";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioRectangle;
        private System.Windows.Forms.RadioButton radioRound;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioWin32API;
        private System.Windows.Forms.RadioButton radioGDIPlus;
        private System.Windows.Forms.RadioButton radioText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

