using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7MSSM
{
    public partial class opHistory : Form
    {
        public opHistory(List<string> fetchedData)
        {
            InitializeComponent();
            DataTable operationData = new DataTable();

            operationData.Columns.Add("Operacion", typeof(string));

            if (fetchedData != null)
            {
                for (int i = 0; i < fetchedData.Count; i++)
                {
                    operationData.Rows.Add(fetchedData[i]);
                }
                dataGridView1.DataSource = operationData;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
