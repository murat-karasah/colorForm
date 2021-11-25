﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://www.c-sharpcorner.com/article/colordialog-in-C-Sharp/
namespace colorForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();  
            if (colorDlg.ShowDialog()==DialogResult.OK)
            {
                button1.ForeColor = colorDlg.Color;
                this.BackColor = colorDlg.Color;
            }

        }
    }
}
