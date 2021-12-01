using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace OnlyTwo
{
    class ZipOperation
    {
        public Bunifu.Framework.UI.BunifuProgressBar progressBar;

        public void ZipFileOperation(object sender, EventArgs e, string FilePath)
        {
            if (string.IsNullOrEmpty(FilePath))
                MessageBox.Show("Please select your filename.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (FileSizeControl(FilePath) == false)
                MessageBox.Show("File Size Bigger Than 20MB");
            else
            {
                string fileName = FilePath;
                Thread thread = new Thread(t =>
                {
                    using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                    {
                        FileInfo fi = new FileInfo(fileName);
                        zip.AddFile(fileName);
                        System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(fileName);
                        zip.SaveProgress += Zip_SaveFileProgress;
                        zip.Save(string.Format("{0}/{1}.zip", di.Parent.FullName, fi.Name));
                        //MessageBox.Show("Zip Operation Done");
                    }
                })
                { IsBackground = true };
                thread.Start();
            }
        }
        //Zip File Save Progress And Progress Bar Counter
        private void Zip_SaveFileProgress(object sender, Ionic.Zip.SaveProgressEventArgs e)
        {
            if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_EntryBytesRead)
            {
            progressBar.Invoke(new MethodInvoker(delegate
                {
                    progressBar.MaximumValue = 100;
                    progressBar.Value = (int)((e.BytesTransferred * 100) / e.TotalBytesToTransfer);
                    progressBar.Update();
                    if (progressBar.Value == 100)
                        MessageBox.Show("Zip Progress Done!");
                }));
            }
        }
        //File Size Control (20MB)
        private Boolean FileSizeControl(string FilePath)
        {
            FileInfo info = new FileInfo(FilePath);
            long FileSize = info.Length;
            if (FileSize > 20971520)
                return false;
            return true;
        }
    }
}
