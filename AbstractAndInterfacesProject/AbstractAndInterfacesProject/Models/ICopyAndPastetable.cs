using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfacesProject.Models
{
    public interface ICopyAndPastetable
    {
        void Copy();
        void Paste();
        void Cut();
    }
}
