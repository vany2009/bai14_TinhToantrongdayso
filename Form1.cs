using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai14_TinhToantrongdayso
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int nho = Convert.ToInt32(txtso1.Text);
            int lon = Convert.ToInt32(txtso2.Text);
            int chan = 0, le = 0;

            txttongchan.Text = "";
            txttongle.Text = "";

            for (int i = nho; i <= lon; i++)
            {
                if (i % 2 == 0)
                {
                    chan += i;
                }
                else
                {
                    le += i;
                }
            }
            txttongchan.Text = chan.ToString();
            txttongle.Text = le.ToString();
            txttong.Text = (chan + le).ToString();
        }
    }
}
