namespace Net.FreeORM.TestWFA
{
    partial class FrmPerson
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
            this.grdPerson = new System.Windows.Forms.DataGridView();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblCreatedUser = new System.Windows.Forms.Label();
            this.lblCreationTime = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cmbxCreatedBy = new System.Windows.Forms.ComboBox();
            this.txtCreationTime = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPerson
            // 
            this.grdPerson.AllowUserToAddRows = false;
            this.grdPerson.AllowUserToDeleteRows = false;
            this.grdPerson.AllowUserToResizeRows = false;
            this.grdPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPerson.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdPerson.Location = new System.Drawing.Point(0, 0);
            this.grdPerson.Name = "grdPerson";
            this.grdPerson.ReadOnly = true;
            this.grdPerson.RowHeadersVisible = false;
            this.grdPerson.RowHeadersWidth = 4;
            this.grdPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPerson.Size = new System.Drawing.Size(388, 229);
            this.grdPerson.TabIndex = 7;
            this.grdPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPerson_CellClick);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblFirstName.Location = new System.Drawing.Point(12, 249);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(84, 17);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "First Name :";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblLastName.Location = new System.Drawing.Point(12, 286);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 17);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name :";
            // 
            // lblCreatedUser
            // 
            this.lblCreatedUser.AutoSize = true;
            this.lblCreatedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblCreatedUser.Location = new System.Drawing.Point(12, 324);
            this.lblCreatedUser.Name = "lblCreatedUser";
            this.lblCreatedUser.Size = new System.Drawing.Size(100, 17);
            this.lblCreatedUser.TabIndex = 8;
            this.lblCreatedUser.Text = "Created User :";
            // 
            // lblCreationTime
            // 
            this.lblCreationTime.AutoSize = true;
            this.lblCreationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblCreationTime.Location = new System.Drawing.Point(8, 359);
            this.lblCreationTime.Name = "lblCreationTime";
            this.lblCreationTime.Size = new System.Drawing.Size(104, 17);
            this.lblCreationTime.TabIndex = 8;
            this.lblCreationTime.Text = "Creation Time :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtFirstName.Location = new System.Drawing.Point(148, 246);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(163, 23);
            this.txtFirstName.TabIndex = 9;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtLastName.Location = new System.Drawing.Point(148, 280);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(163, 23);
            this.txtLastName.TabIndex = 10;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // cmbxCreatedBy
            // 
            this.cmbxCreatedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmbxCreatedBy.FormattingEnabled = true;
            this.cmbxCreatedBy.Location = new System.Drawing.Point(148, 316);
            this.cmbxCreatedBy.Name = "cmbxCreatedBy";
            this.cmbxCreatedBy.Size = new System.Drawing.Size(163, 25);
            this.cmbxCreatedBy.TabIndex = 11;
            this.cmbxCreatedBy.SelectedIndexChanged += new System.EventHandler(this.txtCreatedUser_SelectedIndexChanged);
            // 
            // txtCreationTime
            // 
            this.txtCreationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtCreationTime.Location = new System.Drawing.Point(148, 353);
            this.txtCreationTime.Name = "txtCreationTime";
            this.txtCreationTime.ReadOnly = true;
            this.txtCreationTime.Size = new System.Drawing.Size(163, 23);
            this.txtCreationTime.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAdd.Location = new System.Drawing.Point(11, 405);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 25);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnUpdate.Location = new System.Drawing.Point(122, 405);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 25);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnDelete.Location = new System.Drawing.Point(226, 405);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 25);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 459);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCreationTime);
            this.Controls.Add(this.cmbxCreatedBy);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblCreationTime);
            this.Controls.Add(this.lblCreatedUser);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.grdPerson);
            this.Name = "FrmPerson";
            this.Text = "FrmPerson";
            ((System.ComponentModel.ISupportInitialize)(this.grdPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPerson;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblCreatedUser;
        private System.Windows.Forms.Label lblCreationTime;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cmbxCreatedBy;
        private System.Windows.Forms.TextBox txtCreationTime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}