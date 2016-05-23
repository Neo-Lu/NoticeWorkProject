using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace NoticeWork
{

    public partial class Notice : Form
    {
        
        private DateTime BeginTime;
        private DateTime EndTime;
        public Notice(DateTime beginTime,DateTime endTime)
        {
            BeginTime = beginTime;
            EndTime = endTime;
            InitializeComponent();
        }
        /// <summary>
        /// Handles the Click event of the btnOK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            using (NeoNoticeWorkEntities entity = new NeoNoticeWorkEntities())
            {
                NoticeLog model = new NoticeLog();
                model.BeginTime = BeginTime;
                model.EndTime = EndTime;
                model.CreateTime = DateTime.Now;
                model.Remark = txtRemark.Text.Trim();
                model.TagID = (int)cbTags.SelectedValue;
                model.TagName = cbTags.Text;
                entity.NoticeLog.Add(model);
                entity.SaveChanges();
                this.Close();
            }
        }

        private void Notice_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“neoNoticeWorkDataSet.Tags”中。您可以根据需要移动或删除它。
            
            using (NeoNoticeWorkEntities db=new NeoNoticeWorkEntities())
            {
                var tagSource = from b in db.Tags
                                orderby b.Sort descending
                           select b;
                cbTags.DataSource = tagSource.ToList();
                cbTags.ValueMember = "ID";
                cbTags.DisplayMember = "Name";
                int dbCount = db.InspirationalQuotes.Count();
                int randomRowNumber = (new Random()).Next(1, dbCount);
                var togice = from a in db.InspirationalQuotes
                             where a.ID==randomRowNumber
                             select a;
                lblResult.Text = togice.First().Name;
            }
        }
        
    }
}
