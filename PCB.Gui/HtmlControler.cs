using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCB.Gui
{
    public class HtmlControler : System.Windows.Forms.WebBrowser
    {
        public string Text
        {
            set
            {

                this.Navigate("about:blank");
                if (this.Document != null)
                {
                    this.Document.Write(string.Empty);
                }

                string sablona = @"
<html>
    <body>
        {0}
    </body>
</html>
";



                this.DocumentText = string.Format(sablona, value);
            }

            get
            {
                return this.DocumentText;
            }


        }

    }
}
