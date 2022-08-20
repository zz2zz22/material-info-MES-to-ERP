using MiniExcelLibs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace MaterialMES2ERP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string directPath;
        private void MainForm_Load(object sender, EventArgs e)
        {
            dtgv.DataSource = GetMESdata.GetWHFs();
            dtgvSetting();
        }
        public void dtgvSetting()
        {
            dtgv.RowHeadersVisible = false;
            dtgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 14.5F, FontStyle.Bold);
            dtgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dtgv.Columns["uuid"].Visible = false;
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            saveFile();
        }
        public void saveFile()
        {
            using (SaveFileDialog dlgSave = new SaveFileDialog())
                try
                {
                    dlgSave.CheckFileExists = false;
                    // SaveFileDialog title
                    dlgSave.Title = "Save File";
                    // Available file extensions
                    dlgSave.Filter = "Execl files (*.xlsx)|*.xlsx|Execl files (*.xls)|*.xls";
                    if (dlgSave.ShowDialog() == DialogResult.OK && dlgSave.FileName.Length > 0)
                    {
                        string filePath = dlgSave.FileName;
                        directPath = Path.GetFullPath(filePath);
                        txtTest.Text = directPath;
                        List<SaveWHB> l1 = GetMESdata.GetWHBs();
                        List<SaveWHF> l2 = GetMESdata.GetWHFs();
                        List<SaveBillList> l3 = GetMESdata.GetBLs();
                        var sheets = new Dictionary<string, object>
                        {
                            ["WH001"] = l1,
                            ["WH002"] = l2,
                            ["WH003"] = l3
                        };
                        MiniExcel.SaveAs(directPath, sheets, true, "null", ExcelType.XLSX, null, true);
                        DialogResult dialogResult = MessageBox.Show("The excel file was saved. Would you like to access the file?", "Alert", MessageBoxButtons.OKCancel);
                        if (dialogResult == DialogResult.OK)
                        {
                            Process.Start(directPath);
                        }
                    }
                }
                catch (Exception errorMsg)
                {
                    MessageBox.Show(errorMsg.Message);
                }
        }
    }
}
