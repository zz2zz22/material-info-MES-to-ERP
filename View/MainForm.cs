using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialMES2ERP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dtgv.DataSource = GetMESdata.getWarehouse_books_data();
            dtgvSetting();
        }
        public void dtgvSetting()
        {
            dtgv.RowHeadersVisible = false;
            dtgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 14.5F, FontStyle.Bold);
            dtgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;         
        }
    }
}
