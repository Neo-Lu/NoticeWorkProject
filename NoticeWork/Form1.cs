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
    public partial class Form1 : Form
    {
        [DllImport("user32 ")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32 ")]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles the Click event of the btnStart control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            int minute = int.Parse(txtNoticeTime.Text.Trim());
            timer1.Interval = minute * 60*1000;
            timer1.Start();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        /// <summary>
        /// Handles the Tick event of the timer1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            int minute = int.Parse(txtNoticeTime.Text.Trim());
            Notice tag = new Notice(DateTime.Now.AddMinutes(-minute), DateTime.Now);
            tag.Show();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = Application.StartupPath + "//sound.wav";
            player.Load();
            player.PlayLooping();
        }
        
    }
}
