using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetVendorID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbSystemSerialNo.Text == "") tbSystemSerialNo.Text = "系统序列号未输入！";
            ID vend = new ID();
            tbHwId.Text = vend.getVendorId();
            tbLicenseIdentifier.Text = vend.getVendorId() + tbSystemSerialNo.Text;
            tbLicenseIdentifier.Focus();
        }
    }
}
