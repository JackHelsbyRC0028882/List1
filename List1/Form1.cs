﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List1
{
    public partial class Form1 : Form
    {
        void printNums(List<int> ns)
        {
            foreach (int i in ns)
            {
                richTextBox1.AppendText(i + ",");
            }
        }
        public Form1()
        {
            InitializeComponent();
            List<int> ints = new List<int>();
            nums.Add(3);
            nums.Add(5);
            nums.Add(3);
            printNums(nums);
            richTextBox1.AppendText("\n================\n");
            ints.Remove(3);
            printNums(nums);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
