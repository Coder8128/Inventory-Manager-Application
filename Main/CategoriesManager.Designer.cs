namespace Main
{
    partial class CategoriesManager
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
            this.CatDatagridview = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnManPopup1 = new System.Windows.Forms.Button();
            this.btnManPopup2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CatDatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // CatDatagridview
            // 
            this.CatDatagridview.AllowUserToAddRows = false;
            this.CatDatagridview.AllowUserToDeleteRows = false;
            this.CatDatagridview.AllowUserToResizeColumns = false;
            this.CatDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatDatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.CatDatagridview.Location = new System.Drawing.Point(12, 54);
            this.CatDatagridview.Name = "CatDatagridview";
            this.CatDatagridview.RowHeadersVisible = false;
            this.CatDatagridview.RowHeadersWidth = 62;
            this.CatDatagridview.RowTemplate.Height = 33;
            this.CatDatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CatDatagridview.Size = new System.Drawing.Size(440, 329);
            this.CatDatagridview.TabIndex = 0;
            this.CatDatagridview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CatDatagridview_MouseClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory Categories";
            // 
            // btnManPopup1
            // 
            this.btnManPopup1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManPopup1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManPopup1.Location = new System.Drawing.Point(340, 426);
            this.btnManPopup1.Name = "btnManPopup1";
            this.btnManPopup1.Size = new System.Drawing.Size(112, 34);
            this.btnManPopup1.TabIndex = 2;
            this.btnManPopup1.Text = "Add";
            this.btnManPopup1.UseVisualStyleBackColor = true;
            this.btnManPopup1.Click += new System.EventHandler(this.btnManPopup1_Click);
            // 
            // btnManPopup2
            // 
            this.btnManPopup2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManPopup2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManPopup2.Location = new System.Drawing.Point(222, 426);
            this.btnManPopup2.Name = "btnManPopup2";
            this.btnManPopup2.Size = new System.Drawing.Size(112, 34);
            this.btnManPopup2.TabIndex = 3;
            this.btnManPopup2.Text = "Delete";
            this.btnManPopup2.UseVisualStyleBackColor = true;
            this.btnManPopup2.Click += new System.EventHandler(this.btnManPopup2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 389);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(440, 31);
            this.textBox1.TabIndex = 4;
            // 
            // CategoriesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 467);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnManPopup2);
            this.Controls.Add(this.btnManPopup1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CatDatagridview);
            this.Name = "CategoriesManager";
            this.Text = "CategoriesManager";
            this.Load += new System.EventHandler(this.CategoriesManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CatDatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView CatDatagridview;
        private Label label1;
        private Button btnManPopup1;
        private Button btnManPopup2;
        private DataGridViewTextBoxColumn Column1;
        private TextBox textBox1;
    }
}