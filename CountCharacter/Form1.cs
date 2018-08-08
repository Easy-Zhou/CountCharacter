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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "0/500";
        }

        string save;
        int count = 0;
        int flag = 0;
        public static int count_length = 500;
        int R_count = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text;
            string temp;
            string message = null;
            timer1.Enabled = false;
            text = textBox1.Text;
            string t = text.Replace("\r", "");
            R_count = text.Length - t.Length;
            //textBox1.Text = t;
            //text = t;
            count = text.Length;
            if (count >= count_length)
            {
                if(flag != 1)
                    textBox1.Text = textBox1.Text.Substring(0,count_length);
                message = "超出输入限制!";
                //MessageBox.Show("超出输入限制!", "PIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //text = textBox1.Text;
                //t = text.Replace("\r", "");
                //R_count = text.Length - t.Length;
                count = count_length;
            }
            //else
            //{
            //    save = textBox1.Text;
            //}
            if (count < count_length)
                flag = 0;
            temp = string.Format("{0}   {1}/{2}",message,count,count_length);
            toolStripStatusLabel1.Text = temp;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != (char)Keys.Back && count >= count_length)
            {
                e.Handled = true;
                flag = 1;
            }
            //if (e.KeyChar == (char)Keys.Enter && count < count_length)
            //    count_flag = 1;
        }

        private void 限制长度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Length form_length = new Length();
            form_length.Show();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string temp = null;
            string message = null;
            if (count >= count_length)
            {
                textBox1.Text = textBox1.Text.Substring(0, count_length);
                message = "超出输入限制!";
            }
            else
                message = null;
            temp = string.Format("{0}   {1}/{2}", message, count, count_length);
            //MessageBox.Show();
            toolStripStatusLabel1.Text = temp;
        }
    }
}

