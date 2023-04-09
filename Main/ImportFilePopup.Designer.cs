namespace Main
{
    partial class ImportFilePopup
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
            this.labelPP1 = new System.Windows.Forms.Label();
            this.textBoxPP1 = new System.Windows.Forms.TextBox();
            this.btnImportPP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPP1
            // 
            this.labelPP1.AutoSize = true;
            this.labelPP1.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPP1.Location = new System.Drawing.Point(12, 50);
            this.labelPP1.Name = "labelPP1";
            this.labelPP1.Size = new System.Drawing.Size(103, 23);
            this.labelPP1.TabIndex = 0;
            this.labelPP1.Text = "File path:";
            // 
            // textBoxPP1
            // 
            this.textBoxPP1.Location = new System.Drawing.Point(12, 78);
            this.textBoxPP1.Name = "textBoxPP1";
            this.textBoxPP1.Size = new System.Drawing.Size(540, 31);
            this.textBoxPP1.TabIndex = 1;
            this.textBoxPP1.Text = "C:\\Users\\User\\Desktop\\Zhumws\\My Training Projects\\Stock MGMT files\\bigdata.txt";
            // 
            // btnImportPP
            // 
            this.btnImportPP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportPP.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImportPP.Location = new System.Drawing.Point(440, 115);
            this.btnImportPP.Name = "btnImportPP";
            this.btnImportPP.Size = new System.Drawing.Size(112, 34);
            this.btnImportPP.TabIndex = 2;
            this.btnImportPP.Text = "Import";
            this.btnImportPP.UseVisualStyleBackColor = true;
            this.btnImportPP.Click += new System.EventHandler(this.btnImportPP_Click);
            // 
            // ImportFilePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 180);
            this.Controls.Add(this.btnImportPP);
            this.Controls.Add(this.textBoxPP1);
            this.Controls.Add(this.labelPP1);
            this.Name = "ImportFilePopup";
            this.Text = "ImportFilePopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelPP1;
        private TextBox textBoxPP1;
        private Button btnImportPP;
    }
}