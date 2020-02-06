using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractAndInterfacesProject.Models
{
    public abstract class Shape : ICopyAndPastetable
    {
        public string Name { get; set; }
        public string Drawing { get; set; }

        public void Copy()
        {
            Clipboard.SetText(Drawing);
        }

        public void Cut()
        {
            Clipboard.SetText(Drawing);
            Drawing = string.Empty;
        }

        public abstract void Draw();

        public void Paste()
        {
            Drawing = Clipboard.GetText();
        }
    }
}
