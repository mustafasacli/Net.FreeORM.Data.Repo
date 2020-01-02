namespace Net.FreeORM.VistaDB_TestWFA
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
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnOpenPersons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsers
            // 
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnUsers.Location = new System.Drawing.Point(86, 47);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(117, 35);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Open Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnOpenPersons
            // 
            this.btnOpenPersons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnOpenPersons.Location = new System.Drawing.Point(86, 114);
            this.btnOpenPersons.Name = "btnOpenPersons";
            this.btnOpenPersons.Size = new System.Drawing.Size(117, 37);
            this.btnOpenPersons.TabIndex = 1;
            this.btnOpenPersons.Text = "Open Persons";
            this.btnOpenPersons.UseVisualStyleBackColor = true;
            this.btnOpenPersons.Click += new System.EventHandler(this.btnOpenPersons_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnOpenPersons);
            this.Controls.Add(this.btnUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnOpenPersons;
    }
}

