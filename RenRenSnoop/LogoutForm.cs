﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenRenSnoop
{
    public partial class LogoutForm : Form
    {
        public LogoutForm()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            radioButton2.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                radioButton2.Checked = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                radioButton1.Checked = false;

        }


        private void confirm_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                this.Close();
            else if (radioButton2.Checked)
            {
                Properties.Settings.Default.AcessToken = string.Empty;
                Properties.Settings.Default.Save();
                this.Close();
            }
        }
    }
}
