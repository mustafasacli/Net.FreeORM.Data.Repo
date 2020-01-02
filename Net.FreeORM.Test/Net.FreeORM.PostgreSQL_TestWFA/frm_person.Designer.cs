namespace Net.FreeORM.PostgreSQL_TestWFA
{
    partial class frm_person
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
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
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
            this.grdPerson.Size = new System.Drawing.Size(255, 183);
            this.grdPerson.TabIndex = 0;
            this.grdPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPerson_CellClick);
            this.grdPerson.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdPerson_CellMouseClick);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(12, 202);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 13);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "id :";
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Location = new System.Drawing.Point(12, 237);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(55, 13);
            this.lbl_firstname.TabIndex = 1;
            this.lbl_firstname.Text = "firstname :";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Location = new System.Drawing.Point(12, 276);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(55, 13);
            this.lbl_lastname.TabIndex = 1;
            this.lbl_lastname.Text = "lastname :";
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(105, 234);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(100, 20);
            this.txt_firstname.TabIndex = 2;
            this.txt_firstname.TextChanged += new System.EventHandler(this.txt_firstname_TextChanged);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(105, 195);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 2;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(105, 269);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(100, 20);
            this.txt_lastname.TabIndex = 2;
            this.txt_lastname.TextChanged += new System.EventHandler(this.txt_lastname_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(25, 318);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(128, 320);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(73, 368);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // frm_person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 403);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_firstname);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.grdPerson);
            this.Name = "frm_person";
            this.Text = "frm_person";
            ((System.ComponentModel.ISupportInitialize)(this.grdPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPerson;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
    }
}