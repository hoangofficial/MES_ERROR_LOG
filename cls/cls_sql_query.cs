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

namespace PID_Converter.SQL_Class
{
    class cls_sql_query
    {
        public string pid_to_mat(string factory_code ,string PID)
        {
            //string sql = "SELECT DB_CHANGE_DATE, EQUIPMENT_ID, ERROR_CODE, ERROR_MESSAGE_CONTENT, MESSAGE_CONTENT FROM tb_mes_error_log WHERE equipment_id like 'HNBCGA53ZA%' and nanotrack_timekey between '2023120501' and '2023120510' order by db_change_date asc";
            string sql = "SELECT representative_factory_code, LOT_ID, LOT_ITEM_ID, LOT_ITEM_VALUE FROM tb_egn_lot_item_info WHERE representative_factory_code = '" + factory_code + "' AND lot_id = '" + PID + "'";
            return sql;
        }
        public string mat_to_pid(string mate)
        {            
            string sql = "SELECT * FROM tb_egn_lot_item_info WHERE lot_item_value in '" + mate + "'";
            return sql;
        }
        
    }
}
