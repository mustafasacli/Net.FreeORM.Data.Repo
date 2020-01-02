namespace Net.FreeORM.TestWFA
{
    partial class Form1
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
            this.grdTable = new System.Windows.Forms.DataGridView();
            this.lblConnStr = new System.Windows.Forms.Label();
            this.lblQuery = new System.Windows.Forms.Label();
            this.txtConnStr = new System.Windows.Forms.TextBox();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnGetData = new System.Windows.Forms.Button();
            this.cmbxConnTypes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdTable)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTable
            // 
            this.grdTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdTable.Location = new System.Drawing.Point(0, 0);
            this.grdTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdTable.Name = "grdTable";
            this.grdTable.Size = new System.Drawing.Size(856, 428);
            this.grdTable.TabIndex = 0;
            // 
            // lblConnStr
            // 
            this.lblConnStr.AutoSize = true;
            this.lblConnStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblConnStr.Location = new System.Drawing.Point(16, 458);
            this.lblConnStr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnStr.Name = "lblConnStr";
            this.lblConnStr.Size = new System.Drawing.Size(128, 17);
            this.lblConnStr.TabIndex = 1;
            this.lblConnStr.Text = "Connection String :";
            // 
            // lblQuery
            // 
            this.lblQuery.AutoSize = true;
            this.lblQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblQuery.Location = new System.Drawing.Point(16, 502);
            this.lblQuery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(55, 17);
            this.lblQuery.TabIndex = 1;
            this.lblQuery.Text = "Query :";
            // 
            // txtConnStr
            // 
            this.txtConnStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtConnStr.Location = new System.Drawing.Point(153, 449);
            this.txtConnStr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConnStr.Name = "txtConnStr";
            this.txtConnStr.Size = new System.Drawing.Size(685, 23);
            this.txtConnStr.TabIndex = 2;
            // 
            // txtQuery
            // 
            this.txtQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtQuery.Location = new System.Drawing.Point(153, 493);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(685, 23);
            this.txtQuery.TabIndex = 2;
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(379, 536);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(130, 37);
            this.btnGetData.TabIndex = 3;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // cmbxConnTypes
            // 
            this.cmbxConnTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxConnTypes.FormattingEnabled = true;
            this.cmbxConnTypes.Location = new System.Drawing.Point(102, 548);
            this.cmbxConnTypes.Name = "cmbxConnTypes";
            this.cmbxConnTypes.Size = new System.Drawing.Size(179, 25);
            this.cmbxConnTypes.TabIndex = 4;
            this.cmbxConnTypes.SelectedIndexChanged += new System.EventHandler(this.cmbxConnTypes_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 585);
            this.Controls.Add(this.cmbxConnTypes);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.txtConnStr);
            this.Controls.Add(this.lblQuery);
            this.Controls.Add(this.lblConnStr);
            this.Controls.Add(this.grdTable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdTable;
        private System.Windows.Forms.Label lblConnStr;
        private System.Windows.Forms.Label lblQuery;
        private System.Windows.Forms.TextBox txtConnStr;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.ComboBox cmbxConnTypes;
    }
}

