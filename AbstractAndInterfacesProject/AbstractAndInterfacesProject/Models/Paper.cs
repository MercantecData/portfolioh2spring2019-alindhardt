using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfacesProject.Models
{
    public class Paper : ICopyAndPastetable
    {
        public string Text { get; set; }

        public void Copy()
        {
            System.Windows.Forms.Clipboard.SetText(Text);
        }

        public void Cut()
        {
            System.Windows.Forms.Clipboard.SetText(Text);
            Text = string.Empty;
        }

        public void Paste()
        {
            Text = System.Windows.Forms.Clipboard.GetText();
        }
    }
}
