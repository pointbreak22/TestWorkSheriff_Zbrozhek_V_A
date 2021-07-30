using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2_CopyPaste
{
    public class Test
    {
        //   private Loading Loading = new Loading();
        public Button button = new Button();

        public Test()
        {
            button.Size = new System.Drawing.Size(100, 20);
            button.Location = new System.Drawing.Point(10, 10);
            button.Text = "kill me";
            //   Loading.Controls.Add(button);
        }
    }
}