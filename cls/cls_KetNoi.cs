using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using Oracle.ManagedDataAccess.Client;

namespace PID_Converter.cls
{
    class cls_KetNoi
    {
        public OracleConnection connection = new OracleConnection();
        //string connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.121.61.111)(PORT=3521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=HNMESP1)));User Id=HNMES_VEW;Password=qhdks!202312;";        
        public bool KetNoi(string connectionString)
        {
            try
            {
                connection = new OracleConnection(connectionString);
                connection.Open();
                //MessageBox.Show("Kết nối thành công!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.ToString());
                return false;
            }

        }
        public void DongKetNoi()
        {
            connection.Close();
        }
    }
}
