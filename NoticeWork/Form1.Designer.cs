namespace NoticeWork
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoticeTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.neoNoticeWorkDataSet = new NoticeWork.NeoNoticeWorkDataSet();
            this.tagsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagsTableAdapter = new NoticeWork.NeoNoticeWorkDataSetTableAdapters.TagsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.neoNoticeWorkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "提醒频率：";
            // 
            // txtNoticeTime
            // 
            this.txtNoticeTime.Location = new System.Drawing.Point(152, 198);
            this.txtNoticeTime.Name = "txtNoticeTime";
            this.txtNoticeTime.Size = new System.Drawing.Size(100, 28);
            this.txtNoticeTime.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "每X分钟提醒1次";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(70, 293);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 84);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = " 开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(247, 293);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(109, 84);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "结束";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // neoNoticeWorkDataSet
            // 
            this.neoNoticeWorkDataSet.DataSetName = "NeoNoticeWorkDataSet";
            this.neoNoticeWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tagsBindingSource
            // 
            this.tagsBindingSource.DataMember = "Tags";
            this.tagsBindingSource.DataSource = this.neoNoticeWorkDataSet;
            // 
            // tagsTableAdapter
            // 
            this.tagsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 409);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNoticeTime);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "努力每一天！";
            ((System.ComponentModel.ISupportInitialize)(this.neoNoticeWorkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoticeTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Timer timer1;
        private NeoNoticeWorkDataSet neoNoticeWorkDataSet;
        private System.Windows.Forms.BindingSource tagsBindingSource;
        private NeoNoticeWorkDataSetTableAdapters.TagsTableAdapter tagsTableAdapter;
    }
}

