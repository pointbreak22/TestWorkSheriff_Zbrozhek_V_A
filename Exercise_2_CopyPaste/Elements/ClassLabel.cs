using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2_CopyPaste.Elements
{
    public class ClassLabel
    {
        public Label label;
        public string LabelTexst { set { label.Text = value; } }

        public ClassLabel()
        {
            label = new Label();
            label.AutoSize = true;
        }
    }
}