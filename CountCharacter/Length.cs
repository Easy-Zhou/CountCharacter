using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CountCharacter
{
    public partial class Length : Form
    {
        public Length()
        {
            InitializeComponent();
        }
        //public int length = 500;
        //Form1 form1 = new Form1();
        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int temp = 500;
            int flag = 0;
            try
            {
                temp = Convert.ToInt32(text);
            }
            catch
            {
                MessageBox.Show("你要上天 ¿", "PIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            if (temp <= 0)
            {
                MessageBox.Show("你要上天 ¿¿¿", "PIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
                Form1.count_length = temp;
            if(flag == 0)
                Application.OpenForms["Length"].Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Length"].Close();
        }
    }
}
