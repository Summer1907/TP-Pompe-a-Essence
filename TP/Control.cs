﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP
{
    public partial class Control : Form
    {
        Waiting f2 = new Waiting();
        ChoixFuel f3 = new ChoixFuel();
        CodeCb f4 = new CodeCb();
        public Control()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2.Show();
            Thread.Sleep(1000);
            f2.Close();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f4.Show();
        }
    }
}