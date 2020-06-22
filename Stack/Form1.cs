using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack
{
    public partial class Form1 : Form
    {
        Stack<char> stack;

        public Form1()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    stack = new Stack<char>(Convert.ToInt32(textBox1.Text));
                    panel1.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                stack.Push(Convert.ToChar(textBox2.Text));
            }
            catch(StackOverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = stack.Pop().ToString();
            }
            catch (StackEmptyException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = !textBox1.Enabled;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = stack.Top.ToString();
            }
            catch (StackEmptyException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (stack.IsEmpty)
                MessageBox.Show("Стек пуст");
            else
                MessageBox.Show("Стек не пуст");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            stack.Clear();
            MessageBox.Show("Стек очищен");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            string s = textBox4.Text;
            Stack<char> stack = new Stack<char>(s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '(':
                        stack.Push(s[i]);
                        break;
                    case '[':
                        stack.Push(s[i]);
                        break;
                    case '{':
                        stack.Push(s[i]);
                        break;
                    case ')':
                        if (stack.IsEmpty || stack.Pop() != '(')
                        {
                            MessageBox.Show("Not right");
                            return;
                        }
                        break;
                    case ']':
                        if (stack.IsEmpty || stack.Pop() != '[')
                        {
                            MessageBox.Show("Not right");
                            return;
                        }
                        break;
                    case '}':
                        if (stack.IsEmpty || stack.Pop() != '{')
                        {
                            MessageBox.Show("Not right");
                            return;
                        }
                        break;
                }
            }
            if (stack.IsEmpty)
                MessageBox.Show("All right");
            else
                MessageBox.Show("Not right");
        }

        private void Form1_Load(object sender, EventArgs e)
        {       
        }
    }
}
