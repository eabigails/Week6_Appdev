using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sdhtdkkuat
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public int a;
        public Form1()
        {
            InitializeComponent();
            instance = this;

        }

        private void txtbox_howmuch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txtbox_howmuch.Text);
            if ((System.Text.RegularExpressions.Regex.IsMatch(txtbox_howmuch.Text, "[^0-9]")))
            {
                MessageBox.Show("Please input number only");
            }
            else
            {

                Form2 form2 = new Form2( a);
                form2.b = a;
                form2.Show();
            }


        }
    }
}

