using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialMES2ERP
{
    public class EmailJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            //MessageBox.Show("Trigger");//Replace with send mail logic ?? // should check on if have data but shudown the program early ?
            //DataReport.SaveExcel("", Properties.Settings.Default.excelFileName);

            //Properties.Settings.Default.excelFileName = "Report_" + DateTime.Now.ToString("yyyyMMdd-hhmmss") + ".xlsx";
            //Properties.Settings.Default.Save();
            return null;
        }
    }
}
