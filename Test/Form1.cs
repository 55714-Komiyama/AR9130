using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dtrRtn = null;

            using (AR9130.AR9130 objSearch = new AR9130.AR9130())
            {
                objSearch.ShowDialog();
                dtrRtn= objSearch.GetDepartmentInfo();
                if (dtrRtn == null)
                {
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    return;
                }
                textBox1.Text = dtrRtn.ItemArray[0].ToString();
                textBox2.Text = dtrRtn.ItemArray[1].ToString();
            }
        }
    }
}
