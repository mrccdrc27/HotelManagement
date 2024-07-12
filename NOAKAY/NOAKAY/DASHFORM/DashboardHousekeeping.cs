using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOAKAY.DASHFORM
{
    public partial class DashboardHousekeeping : Form
    {
        public DashboardHousekeeping()
        {
            InitializeComponent();
        }

        private void btnImportCSV_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;
                    DataTable dataTable = LoadCsvData(filePath);
                    dgvImportFiles.DataSource = dataTable;

                }
            }
        }

        private DataTable LoadCsvData(string filePath)
        {
            DataTable dataTable = new DataTable();
            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length > 0)
            {
                string[] headerColumns = lines[0].Split(',');
                foreach (string headerColumn in headerColumns)
                {
                    dataTable.Columns.Add(headerColumn);
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataColumns = lines[i].Split(',');
                    dataTable.Rows.Add(dataColumns);
                }
            }

            return dataTable;
        }

    }
}
