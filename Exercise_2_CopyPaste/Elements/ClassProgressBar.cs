using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2_CopyPaste.Elements
{
    internal class ClassProgressBar
    {
        public ProgressBar progress;
        public int ProgressBarValue { set { progress.Value = value; } }

        public ClassProgressBar()
        {
            progress = new ProgressBar();
            progress.Size = new System.Drawing.Size(300, 20);
            progress.Maximum = 100;
            progress.Minimum = 0;
            progress.Value = 0;
        }
    }
}