namespace SystemHR
{
    partial class Main
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.cbFiltering = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDissmiss = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToResizeRows = false;
            this.dgvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(958, 403);
            this.dgvEmployees.TabIndex = 0;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddEmployee.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnAddEmployee.Location = new System.Drawing.Point(12, 421);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(93, 42);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Dodaj pracownika(ów)";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditEmployee.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnEditEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnEditEmployee.Location = new System.Drawing.Point(111, 421);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(89, 42);
            this.btnEditEmployee.TabIndex = 2;
            this.btnEditEmployee.Text = "Aktualizuj dane pracownika";
            this.btnEditEmployee.UseVisualStyleBackColor = false;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // cbFiltering
            // 
            this.cbFiltering.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.cbFiltering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFiltering.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbFiltering.FormattingEnabled = true;
            this.cbFiltering.Location = new System.Drawing.Point(3, 16);
            this.cbFiltering.Name = "cbFiltering";
            this.cbFiltering.Size = new System.Drawing.Size(101, 21);
            this.cbFiltering.TabIndex = 3;
            this.cbFiltering.SelectedIndexChanged += new System.EventHandler(this.cbFiltering_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.cbFiltering);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(206, 417);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 45);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtr pracowników:";
            // 
            // btnDissmiss
            // 
            this.btnDissmiss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDissmiss.BackColor = System.Drawing.Color.Red;
            this.btnDissmiss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDissmiss.ForeColor = System.Drawing.Color.Black;
            this.btnDissmiss.Location = new System.Drawing.Point(881, 422);
            this.btnDissmiss.Name = "btnDissmiss";
            this.btnDissmiss.Size = new System.Drawing.Size(89, 42);
            this.btnDissmiss.TabIndex = 5;
            this.btnDissmiss.Text = "Zwolnij pracownika";
            this.btnDissmiss.UseVisualStyleBackColor = false;
            this.btnDissmiss.Click += new System.EventHandler(this.btnDissmiss_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(979, 475);
            this.Controls.Add(this.btnDissmiss);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.dgvEmployees);
            this.MinimumSize = new System.Drawing.Size(995, 514);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System HR";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.ComboBox cbFiltering;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDissmiss;
    }
}

