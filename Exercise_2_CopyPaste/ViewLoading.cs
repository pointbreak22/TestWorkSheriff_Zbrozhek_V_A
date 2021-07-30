using Exercise_2_CopyPaste.Elements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2_CopyPaste
{
    internal class ViewLoading
    {
        private int n = 0;
        public Loading loading;
        private List<ClassLabel> labelsCopy;
        private List<ClassProgressBar> progressBars;
        private List<ClassLabel> labelsPercent;
        private List<BackgroundWorker> backgroundWorkers;
        private List<string> listSourse;
        private List<string> listTarget;

        public ViewLoading()
        {
            n = 0;
            count = 0;
            loading = new Loading();
            labelsCopy = new List<ClassLabel>();
            progressBars = new List<ClassProgressBar>();
            labelsPercent = new List<ClassLabel>();
            backgroundWorkers = new List<BackgroundWorker>();
            listSourse = new List<string>();
            listTarget = new List<string>();

            loading.AutoScroll = true;
            loading.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        //public void Open()
        //{
        //    loading.Show();
        //}

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = backgroundWorkers.IndexOf(sender as BackgroundWorker);

            CopyFile(listSourse[i], listTarget[i], i);
        }

        private int count = 0;

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int i = backgroundWorkers.IndexOf(sender as BackgroundWorker);

            progressBars[i].progress.Value = e.ProgressPercentage;
            labelsPercent[i].label.Text = progressBars[i].progress.Value.ToString() + "%";
            if (progressBars[i].progress.Value == 100)
            {
                labelsCopy[i].label.Visible = false;
                progressBars[i].progress.Visible = false;
                labelsPercent[i].label.Visible = false;

                count++;
            }
            if (count == n)
            {
                loading.tableLayoutPanel1.Controls.Clear();
                labelsCopy.Clear();
                labelsPercent.Clear();
                progressBars.Clear();
                backgroundWorkers.Clear();
                loading.Close();
                listSourse.Clear();
                listTarget.Clear();
                //loading.Dispose();
                count = 0;
                n = 0;
            }
        }

        private void CopyFile(string source, string des, int i)
        {
            FileStream fsOut = new FileStream(des, FileMode.Create);
            FileStream fsIn = new FileStream(source, FileMode.Open);
            byte[] bt = new byte[1048576];     // 1048576  //1024
            int readByte;

            while ((readByte = fsIn.Read(bt, 0, bt.Length)) > 0)
            {
                fsOut.Write(bt, 0, readByte);
                backgroundWorkers[i].ReportProgress((int)(fsIn.Position * 100 / fsIn.Length));
            }

            fsIn.Close();
            fsOut.Close();
        }

        public void AddWoker(string sourse, string target)
        {
            loading.tableLayoutPanel1.SuspendLayout();

            //пути
            labelsCopy.Add(new ClassLabel());
            loading.tableLayoutPanel1.Controls.Add(labelsCopy[n].label);

            //прогресс
            progressBars.Add(new ClassProgressBar());
            loading.tableLayoutPanel1.Controls.Add(progressBars[n].progress);

            //процент
            labelsPercent.Add(new ClassLabel());
            loading.tableLayoutPanel1.Controls.Add(labelsPercent[n].label);

            backgroundWorkers.Add(new BackgroundWorker());
            backgroundWorkers[n].WorkerReportsProgress = true;
            backgroundWorkers[n].WorkerSupportsCancellation = true;
            backgroundWorkers[n].ProgressChanged += Worker_ProgressChanged;
            backgroundWorkers[n].DoWork += Worker_DoWork;

            listSourse.Add(sourse);
            listTarget.Add(target);
            labelsCopy[n].LabelTexst = "Копирование: " + listSourse[n] + " => " + listTarget[n];

            backgroundWorkers[n].RunWorkerAsync();
            n++;
            loading.tableLayoutPanel1.ResumeLayout();
        }
    }
}