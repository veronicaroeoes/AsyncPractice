using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Diagnostics;


namespace Asynk
{
    public partial class Form1 : Form
    {
        const string url = "http://www.aftonbladet.se/";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOnePage_Click(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                await DownloadOneWebsite();
            });
        }

        private async Task DownloadOneWebsite()
        {
            var client = new HttpClient();
            var timer = new Stopwatch();
            timer.Start();
            string result = null;

            result = await client.GetStringAsync(url);

            timer.Stop();
            MessageBox.Show($"www.Aftonbladet.se är nedladdad på {timer.Elapsed.TotalSeconds.ToString()} sekunder");

        }

        private void btnManyPages_Click(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                await DownloadManyWebsites();
            });


        }

        private async Task DownloadManyWebsites()
        {
            var client = new HttpClient();
            var timer = new Stopwatch();
            timer.Start();

            var task1 = client.GetStringAsync(url);
            var task2 = client.GetStringAsync(url);
            var task3 = client.GetStringAsync(url);
            var task4 = client.GetStringAsync(url);

            string[] results = await Task.WhenAll(task1, task2, task3, task4);

            timer.Stop();
            MessageBox.Show($"www.Aftonbladet.se är nedladdat 4 gånger på {timer.Elapsed.TotalSeconds.ToString()} sekunder");

        }
    }
}
