using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MaterialMES2ERP
{
    public class VariablesSave
    {
        //Window type
        public static int type { get; set; }
        //QR Scan
        public static String qrScanResult { get; set; }
        //Weight Data
        public static String scaleResult { get; set; }
        //Scale Information
        public static String PortName { get; set; }
        public static String BaudRate { get; set; }
        public static String DataBits { get; set; }
        public static String StopBits { get; set; }
        public static String Parity { get; set; }
        //Employee Information
        public static String EmpUUID { get; set; }
        public static String EmpCode { get; set; }
        public static String EmpName { get; set; }

        //MES Order save
        public static String WorkOrderUUID { get; set; }
        public static String JobOrderUUID { get; set; }
        public static String OrderNo { get; set; }
        public static String ProdNo { get; set; }
        public static double PlanQty { get; set; }
        public static double FinishQty { get; set; }
        public static DataTable matTempDatatable { get; set; }

        public static void GenerateMatTempDatatable()
        {
            matTempDatatable = new DataTable();
            matTempDatatable.Columns.Add("matNo");
            matTempDatatable.Columns.Add("matName");
            matTempDatatable.Columns.Add("totalDosage");
            matTempDatatable.Columns.Add("scaleDosage");
        }

        public static void ResetMatTempDatatable()
        {
            matTempDatatable.Clear();
            matTempDatatable.AcceptChanges();
        }

        public static void ResetWindowType()
        {
            type = 0;
        }
        public static void ResetScanResult()
        {
            qrScanResult = null;
        }

        public static void ResetScaleResult()
        {
            scaleResult = null;
        }
        public static void ResetScale()
        {
            PortName = null;
            BaudRate = null;
            DataBits = null;
            StopBits = null;
            Parity = null;
        }
        public static void ResetEmployee()
        {
            EmpUUID = null;
            EmpCode = null;
            EmpName = null;
        }
        public static void ResetSelectOrder()
        {
            WorkOrderUUID = null;
            JobOrderUUID = null;
            OrderNo = null;
            ProdNo = null;
            PlanQty = 0;
            FinishQty = 0;
        }

        public static void ResetAll()
        {
            ResetScanResult();
            ResetScaleResult();
            ResetScale();
            ResetEmployee();
        }
    }
}
