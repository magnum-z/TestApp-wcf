using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp_wcf_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseDirectory_Click(object sender, EventArgs e)
        {
            string initialFolder = tbDirectoryDownload.Text;

            if (!Directory.Exists(initialFolder))
            {
                initialFolder = Application.StartupPath;
            }

            folderBrowserDialog1.ShowNewFolderButton = true;
            folderBrowserDialog1.SelectedPath = initialFolder;
            folderBrowserDialog1.Description = "Select directory for download files";
            DialogResult dlgResult = folderBrowserDialog1.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                tbDirectoryDownload.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;

            pbDownloadFile.Value = int.Parse(Math.Truncate(percentage).ToString());
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            toolStripStatusLabel1.Text = "Download comleted";
            btnDownloadFile.Enabled = true;
        }

        private void btnDownloadFile_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbDirectoryDownload.Text))
            {
                //try
                {
                    toolStripStatusLabel1.Text = "Downloading ...";
                    pbDownloadFile.Value = 0;
                    string filename;

                    WebClient client = new WebClient();
                    client.Credentials = null;
                    Uri uri = new Uri(tbDownloadFile.Text);                                        
                    filename = Path.GetFileName(uri.LocalPath);

                    if(filename.Length == 0)
                    {
                        filename = "FileName.test";
                    }

                    if(cbAuth.Checked)
                    {
                        client.Credentials = new NetworkCredential(tbUser.Text, tbPassword.Text);
                    }                    

                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                    client.DownloadFileAsync(uri, tbDirectoryDownload.Text + filename);
                    btnDownloadFile.Enabled = false;
                }
                //catch
                {
                  //  toolStripStatusLabel1.Text = "Error downloading file";
                }                
            }
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
    }
}
