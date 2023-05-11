using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace IncidentsApp
{
    public partial class MainForm : Form
    {
        DataTable table;
        ExcelHelper excelHelper;
        List<Incident> incidents;

        public MainForm()
        {
            InitializeComponent();
            excelHelper = new ExcelHelper();
        }


        private void checkWorsheet()
        {
            if (excelHelper.getCurrentWorksheet() == null)
            {
                clusterButton.Enabled = false;
                saveButton.Enabled = false;
                saveAsButton.Enabled = false;
            }
            else
            {
                clusterButton.Enabled = true;
                saveButton.Enabled = true;
                saveAsButton.Enabled = true;
            }
        }

        public void loadDataFromFile(string filename="")
        {
            if ((excelHelper.getCurrentWorksheet() == null))
            {
                excelHelper.setupExcelPackage(new FileInfo(filename));
            }
            table = excelHelper.readTableFromExcel();
            tableView.DataSource = table;
            tableView.Columns[0].DefaultCellStyle.Format = "dd.MM.yyyy hh:mm:ss";
            checkWorsheet();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            checkWorsheet();
            this.WindowState = FormWindowState.Maximized;
            highPriorityLabel.Text = "";
            middlePriorityLabel.Text = "";
            lowPriorityLabel.Text = "";
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (excelHelper.getCurrentWorksheet() != null)
            {
                excelHelper.clearData();
                highPriorityLabel.Text = "";
                middlePriorityLabel.Text = "";
                lowPriorityLabel.Text = "";
            }

            using (OpenFileDialog dialog = new OpenFileDialog() 
            {Filter = "Excel files | *.xlsx", ValidateNames = true })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    loadDataFromFile(dialog.FileName);
                }
            }
        }

        private void clusterButton_Click(object sender, EventArgs e)
        {
            incidents = excelHelper.getIncidentsList();
            var tuple = Model.calculatePriorityForList(incidents);
            incidents = tuple.Item1;
            highPriorityLabel.Text = $"Инцидентов высокой опасности: {tuple.Item2[0]} ({Math.Round(((double)tuple.Item2[0] / (double)incidents.Count) * 100)}%)";
            middlePriorityLabel.Text = $"Инцидентов средней опасности: {tuple.Item2[1]} ({Math.Round(((double)tuple.Item2[1] / (double)incidents.Count) * 100)}%)";
            lowPriorityLabel.Text = $"Инцидентов низкой опасности: {tuple.Item2[2]} ({Math.Round(((double)tuple.Item2[2] / (double)incidents.Count) * 100)}%)";
            excelHelper.writeDataToWorksheet(incidents);
            loadDataFromFile();
            checkWorsheet();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            excelHelper.saveDataToFile();
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog()
            { Filter = "Excel files | *.xlsx", ValidateNames = true })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    excelHelper.saveDataToNewFile(dialog.FileName);
                }
            }
        }
    }
}
