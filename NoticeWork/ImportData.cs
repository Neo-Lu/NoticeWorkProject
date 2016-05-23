using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using Java2Dotnet.Spider.Core;
using Java2Dotnet.Spider.Core.Downloader;
using Java2Dotnet.Spider.Core.Pipeline;
using Java2Dotnet.Spider.Core.Processor;
using Java2Dotnet.Spider.Core.Selector;

namespace NoticeWork
{
    public partial class ImportData : Form
    {
        public ImportData()
        {
            InitializeComponent();
        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            using (var db=new NeoNoticeWorkEntities())
            {
                List<string> nameList = GetHtmlContent(id);
                foreach (string name in nameList)
                {
                    InspirationalQuotes model = new InspirationalQuotes();
                    model.Name = name;
                    db.InspirationalQuotes.Add(model);
                }
                db.SaveChanges();
                MessageBox.Show("导入成功！");
            }
        }

        private List<string> GetHtmlContent(string id)
        {
            List<string> list = new List<string>();
            HttpClientDownloader downloader = new HttpClientDownloader();
            /*
             * http://lizhi.yjbys.com/mingyan/373438.html
             * http://lizhi.yjbys.com/mingyan/373443.html
             * http://lizhi.yjbys.com/mingyan/221755.html
             */
            string url = "http://lizhi.yjbys.com/mingyan/"+ id + ".html";
            Java2Dotnet.Spider.Core.Spider spider = Java2Dotnet.Spider.Core.Spider.Create(new Site() { EncodingName = "UTF-8" },
                new SimplePageProcessor(url, url +"/* ")).AddPipeline(new TestPipeline()).SetThreadNum(1);
            Page p = downloader.Download(new Request(url, 2, new Dictionary<string, dynamic>()), spider);
            //Console.WriteLine(p.Content);

            var s = Selectors.Css("div p").SelectList(p.Content);
            for (int i = 0; i < s.Count; i++)
            {
                Match m = Regex.Match(s[i].OuterHtml, @"<p>([\s\S]*)</p>", RegexOptions.IgnoreCase);
                if (m.Success)
                {
                    string result = m.Result("$1").Replace("&mdash;", "—").Replace("&nbsp;", "");
                    if (result != "")
                    {
                        if (!result.Contains("<"))
                        {
                            list.Add(result);
                        }
                    }
                }
            }
            return list;
        }

        private class TestPipeline : IPipeline
        {
            public void Process(ResultItems resultItems, ISpider spider)
            {
                foreach (var entry in resultItems.Results)
                {
                    Console.WriteLine($"{entry.Key}:{entry.Value}");
                }
            }

            public void Dispose()
            {
            }
        }
    }
}
