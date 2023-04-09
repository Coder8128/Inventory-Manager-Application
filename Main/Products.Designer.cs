namespace Main
{
    partial class Products
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPProdCode = new System.Windows.Forms.TextBox();
            this.textBoxPProdName = new System.Windows.Forms.TextBox();
            this.comboBox1P = new System.Windows.Forms.ComboBox();
            this.btnPDel = new System.Windows.Forms.Button();
            this.btnPAdd = new System.Windows.Forms.Button();
            this.dataGridView1P = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPReset = new System.Windows.Forms.Button();
            this.btnPClearAll = new System.Windows.Forms.Button();
            this.btnPUpdateData = new System.Windows.Forms.Button();
            this.comboBoxP2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1P)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(212, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(412, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            // 
            // textBoxPProdCode
            // 
            this.textBoxPProdCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxPProdCode.Location = new System.Drawing.Point(12, 46);
            this.textBoxPProdCode.Name = "textBoxPProdCode";
            this.textBoxPProdCode.Size = new System.Drawing.Size(194, 31);
            this.textBoxPProdCode.TabIndex = 4;
            this.textBoxPProdCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPProdCode_KeyPress);
            // 
            // textBoxPProdName
            // 
            this.textBoxPProdName.Location = new System.Drawing.Point(212, 46);
            this.textBoxPProdName.Name = "textBoxPProdName";
            this.textBoxPProdName.Size = new System.Drawing.Size(194, 31);
            this.textBoxPProdName.TabIndex = 3;
            // 
            // comboBox1P
            // 
            this.comboBox1P.FormattingEnabled = true;
            this.comboBox1P.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comboBox1P.Location = new System.Drawing.Point(412, 44);
            this.comboBox1P.Name = "comboBox1P";
            this.comboBox1P.Size = new System.Drawing.Size(194, 33);
            this.comboBox1P.TabIndex = 5;
            // 
            // btnPDel
            // 
            this.btnPDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.btnPDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDel.ForeColor = System.Drawing.Color.White;
            this.btnPDel.Location = new System.Drawing.Point(956, 42);
            this.btnPDel.Name = "btnPDel";
            this.btnPDel.Size = new System.Drawing.Size(80, 35);
            this.btnPDel.TabIndex = 6;
            this.btnPDel.Text = "Delete";
            this.btnPDel.UseVisualStyleBackColor = false;
            this.btnPDel.Click += new System.EventHandler(this.btnPDel_Click);
            // 
            // btnPAdd
            // 
            this.btnPAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.btnPAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPAdd.ForeColor = System.Drawing.Color.White;
            this.btnPAdd.Location = new System.Drawing.Point(1042, 42);
            this.btnPAdd.Name = "btnPAdd";
            this.btnPAdd.Size = new System.Drawing.Size(80, 35);
            this.btnPAdd.TabIndex = 7;
            this.btnPAdd.Text = "Update";
            this.btnPAdd.UseVisualStyleBackColor = false;
            this.btnPAdd.Click += new System.EventHandler(this.btnPAdd_Click);
            // 
            // dataGridView1P
            // 
            this.dataGridView1P.AllowUserToAddRows = false;
            this.dataGridView1P.AllowUserToDeleteRows = false;
            this.dataGridView1P.AllowUserToResizeRows = false;
            this.dataGridView1P.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1P.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1P.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1P.Name = "dataGridView1P";
            this.dataGridView1P.ReadOnly = true;
            this.dataGridView1P.RowHeadersVisible = false;
            this.dataGridView1P.RowHeadersWidth = 62;
            this.dataGridView1P.RowTemplate.Height = 33;
            this.dataGridView1P.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1P.Size = new System.Drawing.Size(1110, 541);
            this.dataGridView1P.TabIndex = 8;
            this.dataGridView1P.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1P_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Code";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 160;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Product Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Category";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Status";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // btnPReset
            // 
            this.btnPReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.btnPReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPReset.ForeColor = System.Drawing.Color.White;
            this.btnPReset.Location = new System.Drawing.Point(812, 42);
            this.btnPReset.Name = "btnPReset";
            this.btnPReset.Size = new System.Drawing.Size(35, 35);
            this.btnPReset.TabIndex = 9;
            this.btnPReset.Text = "R";
            this.btnPReset.UseVisualStyleBackColor = false;
            this.btnPReset.Click += new System.EventHandler(this.btnPReset_Click);
            // 
            // btnPClearAll
            // 
            this.btnPClearAll.Location = new System.Drawing.Point(872, 42);
            this.btnPClearAll.Name = "btnPClearAll";
            this.btnPClearAll.Size = new System.Drawing.Size(36, 34);
            this.btnPClearAll.TabIndex = 10;
            this.btnPClearAll.Text = "C";
            this.btnPClearAll.UseVisualStyleBackColor = true;
            this.btnPClearAll.Visible = false;
            this.btnPClearAll.Click += new System.EventHandler(this.btnPClearAll_Click);
            // 
            // btnPUpdateData
            // 
            this.btnPUpdateData.Location = new System.Drawing.Point(914, 42);
            this.btnPUpdateData.Name = "btnPUpdateData";
            this.btnPUpdateData.Size = new System.Drawing.Size(36, 34);
            this.btnPUpdateData.TabIndex = 11;
            this.btnPUpdateData.Text = "Update";
            this.btnPUpdateData.UseVisualStyleBackColor = true;
            this.btnPUpdateData.Visible = false;
            this.btnPUpdateData.Click += new System.EventHandler(this.btnPUpdateData_Click);
            // 
            // comboBoxP2
            // 
            this.comboBoxP2.BackColor = System.Drawing.Color.White;
            this.comboBoxP2.DropDownHeight = 150;
            this.comboBoxP2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxP2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxP2.FormattingEnabled = true;
            this.comboBoxP2.IntegralHeight = false;
            this.comboBoxP2.Location = new System.Drawing.Point(612, 44);
            this.comboBoxP2.Name = "comboBoxP2";
            this.comboBoxP2.Size = new System.Drawing.Size(194, 33);
            this.comboBoxP2.TabIndex = 12;
            this.comboBoxP2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxP2_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(612, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Category";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1134, 638);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxP2);
            this.Controls.Add(this.btnPUpdateData);
            this.Controls.Add(this.btnPClearAll);
            this.Controls.Add(this.btnPReset);
            this.Controls.Add(this.dataGridView1P);
            this.Controls.Add(this.btnPAdd);
            this.Controls.Add(this.btnPDel);
            this.Controls.Add(this.comboBox1P);
            this.Controls.Add(this.textBoxPProdName);
            this.Controls.Add(this.textBoxPProdCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Products";
            this.ShowIcon = false;
            this.Text = "Products";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1P)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxPProdCode;
        private TextBox textBoxPProdName;
        private ComboBox comboBox1P;
        private Button btnPDel;
        private Button btnPAdd;
        private DataGridView dataGridView1P;
        private Button btnPReset;
        private Button btnPClearAll;
        private Button btnPUpdateData;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ComboBox comboBoxP2;
        private Label label4;
    }
}