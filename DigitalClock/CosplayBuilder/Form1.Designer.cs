namespace CosplayBuilder
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioPokemon = new System.Windows.Forms.RadioButton();
            this.radioWar = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(53, 118);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(543, 199);
            this.listBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "生產服裝";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioWar);
            this.groupBox1.Controls.Add(this.radioPokemon);
            this.groupBox1.Location = new System.Drawing.Point(53, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 66);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "選擇公司";
            // 
            // radioPokemon
            // 
            this.radioPokemon.AutoSize = true;
            this.radioPokemon.Checked = true;
            this.radioPokemon.Location = new System.Drawing.Point(7, 25);
            this.radioPokemon.Name = "radioPokemon";
            this.radioPokemon.Size = new System.Drawing.Size(73, 19);
            this.radioPokemon.TabIndex = 0;
            this.radioPokemon.TabStop = true;
            this.radioPokemon.Text = "寶可夢";
            this.radioPokemon.UseVisualStyleBackColor = true;
            // 
            // radioWar
            // 
            this.radioWar.AutoSize = true;
            this.radioWar.Checked = true;
            this.radioWar.Location = new System.Drawing.Point(103, 24);
            this.radioWar.Name = "radioWar";
            this.radioWar.Size = new System.Drawing.Size(58, 19);
            this.radioWar.TabIndex = 1;
            this.radioWar.TabStop = true;
            this.radioWar.Text = "魔獸";
            this.radioWar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 329);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "DP06";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioPokemon;
        private System.Windows.Forms.RadioButton radioWar;
    }
}

