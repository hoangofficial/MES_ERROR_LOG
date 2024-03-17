using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using Oracle.ManagedDataAccess.Client;


namespace PID_Converter
{
    public partial class frmMain : Form
    {
        SQL_Class.cls_CRUD cls = new SQL_Class.cls_CRUD();
        SQL_Class.cls_sql_query query = new SQL_Class.cls_sql_query();
        SQL_Class.cls_Connection_Directory conn = new SQL_Class.cls_Connection_Directory();
        public frmMain()
        {
            InitializeComponent();
            dataGridView1.RowPrePaint += dataGridView1_RowPrePaint;
        }             

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text =="HN")
            {
                if (rbPID.Checked)
                {
                    txtMate.Text = "";
                    pid_to_materials(conn.HN);
                }
                else 
                {
                    txtPID.Text = "";
                    mat_to_pid(conn.HN);
                }               
            }
            else if (comboBox1.Text == "HW")
            {
                if (rbPID.Checked)
                {
                    txtMate.Text = "";
                    pid_to_materials(conn.HW);
                }
                else
                {
                    txtPID.Text = "";
                    mat_to_pid(conn.HW);
                }
            }
            else if (comboBox1.Text == "H9")
            {
                if (rbPID.Checked)
                {
                    txtMate.Text = "";
                    pid_to_materials(conn.H9);
                }
                else
                {
                    txtPID.Text = "";
                    mat_to_pid(conn.H9);
                }
            }
            else if (comboBox1.Text == "HT")
            {
                if (rbPID.Checked)
                {
                    txtMate.Text = "";
                    pid_to_materials(conn.HT);
                }
                else
                {
                    txtPID.Text = "";
                    mat_to_pid(conn.HT);
                }
            }
            else if (comboBox1.Text == "HB")
            {
                if (rbPID.Checked)
                {
                    txtMate.Text = "";
                    pid_to_materials(conn.HB);
                }
                else
                {
                    txtPID.Text = "";
                    mat_to_pid(conn.HB);
                }
            }                   
        }
        public void pid_to_materials(string factory)
        {
            dataGridView1.DataSource = cls.getData(query.pid_to_mat(comboBox1.Text,txtPID.Text),factory);
        }
        public void mat_to_pid(string factory)
        {
            dataGridView1.DataSource = cls.getData(query.mat_to_pid(txtMate.Text),factory);
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (!e.RowIndex.Equals(dataGridView1.NewRowIndex))
            {
                dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMate.Text = "";
            txtPID.Text = "";            
        }
    }
}
