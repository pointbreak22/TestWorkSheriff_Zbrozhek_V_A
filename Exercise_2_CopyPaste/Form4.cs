using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2_CopyPaste
{
    public partial class Loading : Form
    {
        private List<Label> listkabel1 = new List<Label>();
        private List<Label> listkabel2 = new List<Label>();
        private List<ProgressBar> listprogress = new List<ProgressBar>();

        public Loading()
        {
            InitializeComponent();
            //   tableLayoutPanel1.SuspendLayout();
            //  tableLayoutPanel1.RowCount = 0;
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.AutoScroll = true;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.SuspendLayout();
            // tableLayoutPanel1.
            Label label = new Label();
            label.Text = "d:\\Dir1\\file1.avi->d:\\Dir2\\file1.avi";

            tableLayoutPanel1.Controls.Add(label);
            listkabel1.Add(label);
            ProgressBar progress = new ProgressBar();
            progress.Size = new Size(200, 15);
            tableLayoutPanel1.Controls.Add(progress);
            listprogress.Add(progress);
            Label label1 = new Label();
            label1.Text = "100%";
            tableLayoutPanel1.Controls.Add(label1);
            listkabel2.Add(label1);
            tableLayoutPanel1.ResumeLayout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.Controls.Remove(listkabel1[3]);
            listkabel1.RemoveAt(3);
            tableLayoutPanel1.Controls.Remove(listkabel2[3]);
            listkabel2.RemoveAt(3);
            tableLayoutPanel1.Controls.Remove(listprogress[3]);
            listprogress.RemoveAt(3);
            tableLayoutPanel1.ResumeLayout();
        }

        private Test test = new Test();

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Add(test.button);
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }
    }
}