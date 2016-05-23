namespace NoticeWork
{
    partial class Notice
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.tagsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.neoNoticeWorkDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.neoNoticeWorkDataSet = new NoticeWork.NeoNoticeWorkDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.tagsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbTags = new System.Windows.Forms.ComboBox();
            this.tagsTableAdapter = new NoticeWork.NeoNoticeWorkDataSetTableAdapters.TagsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tagsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neoNoticeWorkDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neoNoticeWorkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "大胖胖，你刚才做了什么？";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(178, 172);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(209, 129);
            this.txtRemark.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(178, 325);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(209, 71);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoEllipsis = true;
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(52, 42);
            this.lblResult.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 24);
            this.lblResult.TabIndex = 3;
            // 
            // tagsBindingSource
            // 
            this.tagsBindingSource.DataMember = "Tags";
            this.tagsBindingSource.DataSource = this.neoNoticeWorkDataSetBindingSource;
            // 
            // neoNoticeWorkDataSetBindingSource
            // 
            this.neoNoticeWorkDataSetBindingSource.DataSource = this.neoNoticeWorkDataSet;
            this.neoNoticeWorkDataSetBindingSource.Position = 0;
            // 
            // neoNoticeWorkDataSet
            // 
            this.neoNoticeWorkDataSet.DataSetName = "NeoNoticeWorkDataSet";
            this.neoNoticeWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "标签：";
            // 
            // tagsBindingSource1
            // 
            this.tagsBindingSource1.DataMember = "Tags";
            this.tagsBindingSource1.DataSource = this.neoNoticeWorkDataSetBindingSource;
            // 
            // cbTags
            // 
            this.cbTags.FormattingEnabled = true;
            this.cbTags.Location = new System.Drawing.Point(189, 92);
            this.cbTags.Name = "cbTags";
            this.cbTags.Size = new System.Drawing.Size(198, 26);
            this.cbTags.TabIndex = 7;
            // 
            // tagsTableAdapter
            // 
            this.tagsTableAdapter.ClearBeforeFill = true;
            // 
            // Notice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 442);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbTags);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label1);
            this.Name = "Notice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加油奋斗哦~";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Notice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tagsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neoNoticeWorkDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neoNoticeWorkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource neoNoticeWorkDataSetBindingSource;
        private NeoNoticeWorkDataSet neoNoticeWorkDataSet;
        private System.Windows.Forms.BindingSource tagsBindingSource;
        private NeoNoticeWorkDataSetTableAdapters.TagsTableAdapter tagsTableAdapter;
        private System.Windows.Forms.BindingSource tagsBindingSource1;
        private System.Windows.Forms.ComboBox cbTags;
    }
}