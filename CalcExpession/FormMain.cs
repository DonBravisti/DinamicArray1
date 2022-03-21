using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DinList;

namespace CalcExpession
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCalcExpression_Click(object sender, EventArgs e)
        {
            var stack = new Stack<string>();
            foreach (var item in textBoxBackExpression.Text)
            {
                if (item >= '0' && item <= '9')
                    stack.Push(item.ToString());
                else
                {
                    int a = Convert.ToInt32(stack.Pop());
                    int b = Convert.ToInt32(stack.Pop());
                    switch (item)
                    {
                        case '+':
                            a = a + b;
                            break;
                        case '-':
                            a = b - a;
                            break;
                        case '*':
                            a = a * b;
                            break;
                        case '/':
                            a = b / a;
                            break;
                    }
                    stack.Push(a.ToString());
                }
            }
            labelResult.Text = stack.Pop().ToString();
        }

        Dictionary<char, byte> priority = new Dictionary<char, byte>()
        {
            {'+', 1 },
            {'-', 1 },
            {'*', 2 },
            {'/', 2 },
            {'(', 0 }
        };

        private void buttonExpression_Click(object sender, EventArgs e)
        {
            Queue<string> backExpression = new Queue<string>();
            string temp = string.Empty;
            foreach (var item in textBoxExpression.Text)
            {
                if (item >= '0' && item <= '9')
                    temp += item;
                else
                {
                    if (string.IsNullOrEmpty(temp)) backExpression.Append(temp);
                    temp = string.Empty;

                }
            }
        }

        private void textBoxExpression_TextChanged(object sender, EventArgs e)
        {
            string temp = "";
            foreach (var item in textBoxExpression.Text)
            {
                if (item >= '0' && item <= '9')
                {
                    temp += item;
                }
            }
        }
    }
}
