using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncidentsApp
{
    public partial class ProgressBarForm : Form
    {
        public ProgressBarForm(int rowsCount)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            setupProgressBar(rowsCount);
        }

        private void ProgressBarForm_Load(object sender, EventArgs e)
        {
        }

        private void setupProgressBar(int max)
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = max;
            progressBar.Value = 0;
            progressBar.Step = 1;
            progressBar.Style = ProgressBarStyle.Continuous;
        }

        public void performStep()
        {
            progressBar.PerformStep();
        }
    }
}
