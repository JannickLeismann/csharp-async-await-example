using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwaitExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            textBoxContent.Clear();

            Stopwatch watch = new Stopwatch();
            watch.Start();

            int repeat = int.Parse(textBoxRepeat.Text);
            for (int i = 0; i < repeat; i++)
            {
                Download();
            }

            watch.Stop();

            Done(watch.ElapsedMilliseconds);
        }

        private async void btnAsync_Click(object sender, EventArgs e)
        {
            textBoxContent.Clear();

            Stopwatch watch = new Stopwatch();
            watch.Start();

            await StartDownloadAsync();

            watch.Stop();

            Done(watch.ElapsedMilliseconds);
        }

        private async Task StartDownloadAsync()
        {
            // Add some async stuff here :-)
            int repeat = int.Parse(textBoxRepeat.Text);

            List<Task> allTasks = new List<Task>();

            for (int i = 0; i < repeat; i++)
            {
                allTasks.Add(Task.Run(() => Download()));
            }

            await Task.WhenAll(allTasks);
        }

        private void Done(long time)
        {
            textBoxContent.Text += "Download abgeschlossen. Gesamte Dauer: " + time + "ms";
        }

        private void Download()
        {
            string img = "https://cdn.pixabay.com/photo/2021/04/23/19/57/yorkshire-terrier-6202621_960_720.jpg";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(img);
            HttpWebResponse response = ((HttpWebResponse)request.GetResponse());
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

            response.Close();
            readStream.Close();
        }

    }
}
