using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;
using PID_Converter.cls;

namespace PID_Converter.SQL_Class
{
    class cls_CRUD
    {
        public DataTable getData(string sql,string connectionString)
        {
            cls_KetNoi cn = new cls_KetNoi();
            cn.KetNoi(connectionString);
            DataSet ds = new DataSet();
            try
            {
                OracleDataAdapter dta = new OracleDataAdapter(sql, cn.connection);
                dta.Fill(ds, sql);
                DataTable tbl = ds.Tables[0];
                if (tbl.Rows.Count != 0)
                    return tbl;
                else
                    return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}
