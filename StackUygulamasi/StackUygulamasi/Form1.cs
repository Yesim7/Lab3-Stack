using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string test = txtOrginal.Text;
            char[] chrArr = test.ToCharArray();
            ArrayTypedStack ats = new ArrayTypedStack(chrArr.Length);

            for (int i = 0; i < chrArr.Length; i++)
            {
                ats.Push(chrArr[i]);
            }
            test = "";
            for (int i = 0; i < chrArr.Length; i++)
            {
                test += Convert.ToChar(ats.Pop()).ToString();
            }
            txtReverse.Text = test;
        }
    }
}
