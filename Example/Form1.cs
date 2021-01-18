using CPM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Form1 : Form
    {
        DataPool dp = new DataPool();
        int checks = 0;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            dp.Clear();
            checks = 0;
            for (int i = 0; i < 50; i++)
            {
                Thread thread = new Thread(() => { Config(); }) { IsBackground = true };
                thread.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCheck.Text = $"Checked : {checks}";
            lblCpm.Text = $"CPM : {dp.CPM}";
        }

        private void Config()
        {
            for (int i = 0; i < 100; i++)
            {
                checks++;
                dp.Add();
                Thread.Sleep(1000);
            }
        }
    }
}
