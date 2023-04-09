namespace Main
{
    partial class Stock
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSAdd = new System.Windows.Forms.Button();
            this.btnSDelete = new System.Windows.Forms.Button();
            this.btnSReset = new System.Windows.Forms.Button();
            this.textBoxS1 = new System.Windows.Forms.TextBox();
            this.textBoxS2 = new System.Windows.Forms.TextBox();
            this.textBoxS3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxS1 = new System.Windows.Forms.ComboBox();
            this.labelS1 = new System.Windows.Forms.Label();
            this.labelS2 = new System.Windows.Forms.Label();
            this.LabelS3 = new System.Windows.Forms.Label();
            this.labelS4 = new System.Windows.Forms.Label();
            this.labelS5 = new System.Windows.Forms.Label();
            this.labelS6 = new System.Windows.Forms.Label();
            this.labelS7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxS2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchBarS1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(212, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(910, 564);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "S.No";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Product Name";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 280;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Category";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Status";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 120;
            // 
            // btnSAdd
            // 
            this.btnSAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.btnSAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSAdd.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSAdd.ForeColor = System.Drawing.Color.White;
            this.btnSAdd.Location = new System.Drawing.Point(12, 419);
            this.btnSAdd.Name = "btnSAdd";
            this.btnSAdd.Size = new System.Drawing.Size(80, 35);
            this.btnSAdd.TabIndex = 5;
            this.btnSAdd.Text = "Add";
            this.btnSAdd.UseVisualStyleBackColor = false;
            this.btnSAdd.Click += new System.EventHandler(this.btnSAdd_Click);
            // 
            // btnSDelete
            // 
            this.btnSDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.btnSDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSDelete.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSDelete.ForeColor = System.Drawing.Color.White;
            this.btnSDelete.Location = new System.Drawing.Point(98, 419);
            this.btnSDelete.Name = "btnSDelete";
            this.btnSDelete.Size = new System.Drawing.Size(80, 35);
            this.btnSDelete.TabIndex = 6;
            this.btnSDelete.Text = "Delete";
            this.btnSDelete.UseVisualStyleBackColor = false;
            this.btnSDelete.Click += new System.EventHandler(this.btnSDelete_Click);
            // 
            // btnSReset
            // 
            this.btnSReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.btnSReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSReset.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSReset.ForeColor = System.Drawing.Color.White;
            this.btnSReset.Location = new System.Drawing.Point(184, 419);
            this.btnSReset.Name = "btnSReset";
            this.btnSReset.Size = new System.Drawing.Size(25, 35);
            this.btnSReset.TabIndex = 7;
            this.btnSReset.Text = "Reset";
            this.btnSReset.UseVisualStyleBackColor = false;
            this.btnSReset.Click += new System.EventHandler(this.btnSReset_Click);
            // 
            // textBoxS1
            // 
            this.textBoxS1.Location = new System.Drawing.Point(12, 123);
            this.textBoxS1.Name = "textBoxS1";
            this.textBoxS1.Size = new System.Drawing.Size(194, 31);
            this.textBoxS1.TabIndex = 1;
            this.textBoxS1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBoxS2
            // 
            this.textBoxS2.Location = new System.Drawing.Point(12, 56);
            this.textBoxS2.Name = "textBoxS2";
            this.textBoxS2.Size = new System.Drawing.Size(194, 31);
            this.textBoxS2.TabIndex = 2;
            // 
            // textBoxS3
            // 
            this.textBoxS3.Location = new System.Drawing.Point(12, 189);
            this.textBoxS3.Name = "textBoxS3";
            this.textBoxS3.Size = new System.Drawing.Size(194, 31);
            this.textBoxS3.TabIndex = 3;
            this.textBoxS3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 382);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 31);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // comboBoxS1
            // 
            this.comboBoxS1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxS1.FormattingEnabled = true;
            this.comboBoxS1.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comboBoxS1.Location = new System.Drawing.Point(12, 320);
            this.comboBoxS1.Name = "comboBoxS1";
            this.comboBoxS1.Size = new System.Drawing.Size(194, 33);
            this.comboBoxS1.TabIndex = 4;
            // 
            // labelS1
            // 
            this.labelS1.AutoSize = true;
            this.labelS1.Location = new System.Drawing.Point(145, 480);
            this.labelS1.Name = "labelS1";
            this.labelS1.Size = new System.Drawing.Size(22, 25);
            this.labelS1.TabIndex = 9;
            this.labelS1.Text = "0";
            // 
            // labelS2
            // 
            this.labelS2.AutoSize = true;
            this.labelS2.Location = new System.Drawing.Point(145, 505);
            this.labelS2.Name = "labelS2";
            this.labelS2.Size = new System.Drawing.Size(22, 25);
            this.labelS2.TabIndex = 10;
            this.labelS2.Text = "0";
            // 
            // LabelS3
            // 
            this.LabelS3.AutoSize = true;
            this.LabelS3.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelS3.Location = new System.Drawing.Point(12, 359);
            this.LabelS3.Name = "LabelS3";
            this.LabelS3.Size = new System.Drawing.Size(50, 20);
            this.LabelS3.TabIndex = 11;
            this.LabelS3.Text = "Date";
            // 
            // labelS4
            // 
            this.labelS4.AutoSize = true;
            this.labelS4.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelS4.Location = new System.Drawing.Point(12, 100);
            this.labelS4.Name = "labelS4";
            this.labelS4.Size = new System.Drawing.Size(127, 20);
            this.labelS4.TabIndex = 12;
            this.labelS4.Text = "Product Code";
            // 
            // labelS5
            // 
            this.labelS5.AutoSize = true;
            this.labelS5.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelS5.Location = new System.Drawing.Point(12, 33);
            this.labelS5.Name = "labelS5";
            this.labelS5.Size = new System.Drawing.Size(132, 20);
            this.labelS5.TabIndex = 13;
            this.labelS5.Text = "Product Name";
            // 
            // labelS6
            // 
            this.labelS6.AutoSize = true;
            this.labelS6.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelS6.Location = new System.Drawing.Point(12, 166);
            this.labelS6.Name = "labelS6";
            this.labelS6.Size = new System.Drawing.Size(86, 20);
            this.labelS6.TabIndex = 14;
            this.labelS6.Text = "Quantity";
            // 
            // labelS7
            // 
            this.labelS7.AutoSize = true;
            this.labelS7.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelS7.Location = new System.Drawing.Point(12, 297);
            this.labelS7.Name = "labelS7";
            this.labelS7.Size = new System.Drawing.Size(67, 20);
            this.labelS7.TabIndex = 15;
            this.labelS7.Text = "Status";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total Products:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Total Quantity:";
            // 
            // comboBoxS2
            // 
            this.comboBoxS2.DropDownHeight = 150;
            this.comboBoxS2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxS2.DropDownWidth = 184;
            this.comboBoxS2.FormattingEnabled = true;
            this.comboBoxS2.IntegralHeight = false;
            this.comboBoxS2.Location = new System.Drawing.Point(12, 256);
            this.comboBoxS2.Name = "comboBoxS2";
            this.comboBoxS2.Size = new System.Drawing.Size(194, 33);
            this.comboBoxS2.TabIndex = 18;
            this.comboBoxS2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxS2_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Category";
            // 
            // SearchBarS1
            // 
            this.SearchBarS1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchBarS1.Location = new System.Drawing.Point(692, 19);
            this.SearchBarS1.Name = "SearchBarS1";
            this.SearchBarS1.Size = new System.Drawing.Size(430, 29);
            this.SearchBarS1.TabIndex = 20;
            this.SearchBarS1.Text = "Search...";
            this.SearchBarS1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchBarS1_MouseClick);
            this.SearchBarS1.TextChanged += new System.EventHandler(this.SearchBarS1_TextChanged);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1134, 620);
            this.Controls.Add(this.SearchBarS1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxS2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelS7);
            this.Controls.Add(this.labelS6);
            this.Controls.Add(this.labelS5);
            this.Controls.Add(this.labelS4);
            this.Controls.Add(this.LabelS3);
            this.Controls.Add(this.labelS2);
            this.Controls.Add(this.labelS1);
            this.Controls.Add(this.comboBoxS1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxS3);
            this.Controls.Add(this.textBoxS2);
            this.Controls.Add(this.textBoxS1);
            this.Controls.Add(this.btnSReset);
            this.Controls.Add(this.btnSDelete);
            this.Controls.Add(this.btnSAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Stock";
            this.ShowIcon = false;
            this.Text = "Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSAdd;
        private Button btnSDelete;
        private Button btnSReset;
        private TextBox textBoxS1;
        private TextBox textBoxS2;
        private TextBox textBoxS3;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxS1;
        private Label labelS1;
        private Label labelS2;
        private Label LabelS3;
        private Label labelS4;
        private Label labelS5;
        private Label labelS6;
        private Label labelS7;
        private ErrorProvider errorProvider1;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxS2;
        private Label label3;
        private TextBox SearchBarS1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}