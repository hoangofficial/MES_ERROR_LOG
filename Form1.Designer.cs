namespace PID_Converter
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShow = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.txtMate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbPID = new System.Windows.Forms.RadioButton();
            this.rbMat = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(749, 73);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Check";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "HN",
            "HT",
            "HB",
            "HW",
            "H9"});
            this.comboBox1.Location = new System.Drawing.Point(14, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "HN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT});
            this.dataGridView1.Location = new System.Drawing.Point(12, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(905, 674);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(841, 72);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(137, 74);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(186, 20);
            this.txtPID.TabIndex = 0;
            // 
            // txtMate
            // 
            this.txtMate.Location = new System.Drawing.Point(339, 74);
            this.txtMate.Name = "txtMate";
            this.txtMate.Size = new System.Drawing.Size(391, 20);
            this.txtMate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Factory Code";
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 53;
            // 
            // rbPID
            // 
            this.rbPID.AutoSize = true;
            this.rbPID.Location = new System.Drawing.Point(138, 44);
            this.rbPID.Name = "rbPID";
            this.rbPID.Size = new System.Drawing.Size(71, 17);
            this.rbPID.TabIndex = 9;
            this.rbPID.TabStop = true;
            this.rbPID.Text = "Enter PID";
            this.rbPID.UseVisualStyleBackColor = true;
            // 
            // rbMat
            // 
            this.rbMat.AutoSize = true;
            this.rbMat.Location = new System.Drawing.Point(341, 41);
            this.rbMat.Name = "rbMat";
            this.rbMat.Size = new System.Drawing.Size(108, 17);
            this.rbMat.TabIndex = 10;
            this.rbMat.TabStop = true;
            this.rbMat.Text = "Enter materials ID";
            this.rbMat.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(928, 820);
            this.Controls.Add(this.rbMat);
            this.Controls.Add(this.rbPID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMate);
            this.Controls.Add(this.txtPID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnShow);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PID Converter";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.TextBox txtMate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.RadioButton rbPID;
        private System.Windows.Forms.RadioButton rbMat;
    }
}

