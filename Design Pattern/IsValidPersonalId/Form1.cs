using IsValidPersonalId.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsValidPersonalId
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private PersonalIdChecker MyPersonalIdChecker = new PersonalIdChecker();

        private void Button1_Click(object sender, EventArgs e)
        {

            if (this.MyPersonalIdChecker.CheckPersonalId(this.PersonalId.Text))
                this.listBox1.Items.Add(this.PersonalId.Text + "檢查:成功");
            else
                this.listBox1.Items.Add(this.PersonalId.Text + "檢查:失敗");

        }
    }
}
