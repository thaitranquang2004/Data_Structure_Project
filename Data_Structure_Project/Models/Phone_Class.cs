using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Data_Structure_Project.Models
{
    internal class PhoneNode
    {
        private string m_sdt;
        public string SDT { get { return m_sdt; } set { m_sdt = value; } }

        public override string ToString()
        {
            return SDT;
        }
    }
}
