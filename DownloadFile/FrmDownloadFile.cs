using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace DownloadFile
{
    public partial class FrmDownloadFile : Form
    {
        public FrmDownloadFile()
        {
            InitializeComponent();
        }

        WebClient client = new WebClient();
        string dFile = "https://github.com/notepad-plus-plus/notepad-plus-plus/releases/download/v7.8.6/npp.7.8.6.Installer.x64.exe";
        string filePath = @"C:\Users\Enaldo\Desktop\FileDownload\notepad++.exe";

        private void FrmDownloadFile_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                Close(); // ESC - Close app...
            }
            else if(e.KeyCode == Keys.Tab) // TAB - Iniciar download...
            {
                try
                {
                    client.DownloadFile(dFile, filePath);
                    label1.Text = "Downloaded!";
                }
                catch(Exception)
                {
                    label1.Text = "Failed...";
                }
                client.Dispose();// Liberar Recursos...

                // Se quiser iniciar o arquivo

                //Process.Start(filePath);
                //Close();// Fechar app
            }
        }
    }
}
