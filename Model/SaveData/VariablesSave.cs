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
        public static string matCustomNo { get; set; }
        public static DataTable matTempDatatable { get; set; }
        public static DataTable tempMat { get; set; }

        //
        //Settings
        //
        public static String replenishmentType { get; set; }


        //Job order material UUIDs save 
        public static String[] MatOrder { get; set; }

        public static bool isAddSubMat { get; set; }
        public static int scaleTimes { get; set; }
        public static double totalScaleWeight { get; set; }

        //Material Save
        public static String matCode { get; set; }
        public static String matLotNo { get; set; }
        public static String matExpDate { get; set; }
        public static double matScanQuantity { get; set; } //Quantity on QR code scan
        public static double matActualQuantity { get; set; } //On scale quantity 

        public static string returnValue { get;set; }
        public static string tempMatCode { get; set; } 
        public static int subRowIndex  { get; set; } 

        public static void ResetMaterial()
        {
            matCode = null;
            matExpDate = null;
            matLotNo = null;
            matScanQuantity = 0;
            matActualQuantity = 0;
        }

        public static void ResetJobOrdMat()
        {
            MatOrder = null;
        }

        public static void GenerateMatTempDatatable()
        {
            matTempDatatable = new DataTable();
            matTempDatatable.Columns.Add("matUUID");
            matTempDatatable.Columns.Add("matNo");
            matTempDatatable.Columns.Add("actualMatUUID");
            matTempDatatable.Columns.Add("actualMatNo");
            matTempDatatable.Columns.Add("totalDosage");
            matTempDatatable.Columns.Add("scaleDosage");
        }

        public static void ResetMatTempDatatable()
        {

            matTempDatatable.Clear();
            matTempDatatable.AcceptChanges();
        }

        public static void addTempMatColumn()
        {
            tempMat = new DataTable();
            DataColumn tempMatCol;
            tempMatCol = new DataColumn();
            tempMatCol.DataType = Type.GetType("System.String");
            tempMatCol.ColumnName = "MatCode";//2
            tempMat.Columns.Add(tempMatCol);

            tempMatCol = new DataColumn();
            tempMatCol.DataType = Type.GetType("System.String");
            tempMatCol.ColumnName = "MatUUID";//3
            tempMat.Columns.Add(tempMatCol);

            tempMatCol = new DataColumn();
            tempMatCol.DataType = Type.GetType("System.String");
            tempMatCol.ColumnName = "SubMat";//4
            tempMat.Columns.Add(tempMatCol);

            tempMatCol = new DataColumn();
            tempMatCol.DataType = Type.GetType("System.String");
            tempMatCol.ColumnName = "SubMatUUID";//5
            tempMat.Columns.Add(tempMatCol);

            tempMatCol = new DataColumn();
            tempMatCol.DataType = Type.GetType("System.String");
            tempMatCol.ColumnName = "ExpDate";
            tempMat.Columns.Add(tempMatCol);

            tempMatCol = new DataColumn();
            tempMatCol.DataType = Type.GetType("System.String");
            tempMatCol.ColumnName = "LOT";
            tempMat.Columns.Add(tempMatCol);

            tempMatCol = new DataColumn();
            tempMatCol.DataType = Type.GetType("System.Double");
            tempMatCol.ColumnName = "SumScale";
            tempMat.Columns.Add(tempMatCol);

            tempMatCol = new DataColumn();
            tempMatCol.DataType = Type.GetType("System.String");
            tempMatCol.ColumnName = "JOMatUUID";
            tempMat.Columns.Add(tempMatCol);
        }
        public static void  ResetTempMat()
        {
            tempMat.Clear();
            tempMat.AcceptChanges();
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
            matCustomNo = null;
        }

        public static void ResetAll()
        {
            ResetScanResult();
            ResetScaleResult();
            ResetScale();
            ResetSelectOrder();
            ResetTempMat();
            ResetMaterial();
        }
    }
}
