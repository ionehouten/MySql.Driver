namespace Example.Views
{
    partial class ucEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eMPLOYEENUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXTENSIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oFFICECODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEPORTSTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBTITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Example.Entities.Employee);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPLOYEENUMBERDataGridViewTextBoxColumn,
            this.lASTNAMEDataGridViewTextBoxColumn,
            this.fIRSTNAMEDataGridViewTextBoxColumn,
            this.eXTENSIONDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.oFFICECODEDataGridViewTextBoxColumn,
            this.rEPORTSTODataGridViewTextBoxColumn,
            this.jOBTITLEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(706, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // eMPLOYEENUMBERDataGridViewTextBoxColumn
            // 
            this.eMPLOYEENUMBERDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEENUMBER";
            this.eMPLOYEENUMBERDataGridViewTextBoxColumn.HeaderText = "EMPLOYEENUMBER";
            this.eMPLOYEENUMBERDataGridViewTextBoxColumn.Name = "eMPLOYEENUMBERDataGridViewTextBoxColumn";
            // 
            // lASTNAMEDataGridViewTextBoxColumn
            // 
            this.lASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LASTNAME";
            this.lASTNAMEDataGridViewTextBoxColumn.HeaderText = "LASTNAME";
            this.lASTNAMEDataGridViewTextBoxColumn.Name = "lASTNAMEDataGridViewTextBoxColumn";
            // 
            // fIRSTNAMEDataGridViewTextBoxColumn
            // 
            this.fIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRSTNAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRSTNAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.Name = "fIRSTNAMEDataGridViewTextBoxColumn";
            // 
            // eXTENSIONDataGridViewTextBoxColumn
            // 
            this.eXTENSIONDataGridViewTextBoxColumn.DataPropertyName = "EXTENSION";
            this.eXTENSIONDataGridViewTextBoxColumn.HeaderText = "EXTENSION";
            this.eXTENSIONDataGridViewTextBoxColumn.Name = "eXTENSIONDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // oFFICECODEDataGridViewTextBoxColumn
            // 
            this.oFFICECODEDataGridViewTextBoxColumn.DataPropertyName = "OFFICECODE";
            this.oFFICECODEDataGridViewTextBoxColumn.HeaderText = "OFFICECODE";
            this.oFFICECODEDataGridViewTextBoxColumn.Name = "oFFICECODEDataGridViewTextBoxColumn";
            // 
            // rEPORTSTODataGridViewTextBoxColumn
            // 
            this.rEPORTSTODataGridViewTextBoxColumn.DataPropertyName = "REPORTSTO";
            this.rEPORTSTODataGridViewTextBoxColumn.HeaderText = "REPORTSTO";
            this.rEPORTSTODataGridViewTextBoxColumn.Name = "rEPORTSTODataGridViewTextBoxColumn";
            // 
            // jOBTITLEDataGridViewTextBoxColumn
            // 
            this.jOBTITLEDataGridViewTextBoxColumn.DataPropertyName = "JOBTITLE";
            this.jOBTITLEDataGridViewTextBoxColumn.HeaderText = "JOBTITLE";
            this.jOBTITLEDataGridViewTextBoxColumn.Name = "jOBTITLEDataGridViewTextBoxColumn";
            // 
            // ucEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "ucEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEENUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXTENSIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oFFICECODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEPORTSTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBTITLEDataGridViewTextBoxColumn;
    }
}
