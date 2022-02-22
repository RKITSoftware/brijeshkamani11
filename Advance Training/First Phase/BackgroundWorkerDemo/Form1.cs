using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace BackgroundWorkerDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Will Run after Background worker starts
        /// </summary>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            for (int i = 0; i < 100; i++)
            {
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                Thread.Sleep(100);
                backgroundWorker1.ReportProgress(i);
            }
        }

        /// <summary>
        /// Will call after save button clicked
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            backgroundWorker1.RunWorkerAsync();

        }

        /// <summary>
        /// will run after ReportProgress called
        /// </summary>
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        /// <summary>
        /// will run after cancel clicked
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        /// <summary>
        /// will run after background worker completes
        /// </summary>

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Progress Canceled");
            }
            else
            {
                MessageBox.Show("Progress Completed");
            }

            button1.Enabled = true;
            progressBar1.Value = 0;
        }
    }
}
