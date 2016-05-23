namespace NoticeWork
{
    partial class ImportData
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
            this.btnImportData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnImportData
            // 
            this.btnImportData.Location = new System.Drawing.Point(177, 179);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(198, 135);
            this.btnImportData.TabIndex = 0;
            this.btnImportData.Text = "导入数据";
            this.btnImportData.UseVisualStyleBackColor = true;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "导入网页的ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(177, 122);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(198, 28);
            this.txtID.TabIndex = 2;
            // 
            // ImportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 493);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImportData);
            this.Name = "ImportData";
            this.Text = "ImportData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
    }
}