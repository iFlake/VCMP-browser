﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCMP_browser
{
    public partial class Init : Form
    {
        public Init()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Init_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Init_Shown(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new Action(() => { LabelProcess.Text = "Reading configuration file"; }));
            ConfigurationManager.Load();

            this.Invoke(new Action(() => { LabelProcess.Text = "Checking for updates"; }));

            this.Invoke(new Action(() => { LabelProcess.Text = "No update functionality"; }));

            this.Invoke(new Action(() => { LabelProcess.Text = "Transferring over"; }));

            this.Invoke(new Action(() => { Dashboard dashboard = new Dashboard(); dashboard.Show(); Hide(); }));
        }
    }
}
