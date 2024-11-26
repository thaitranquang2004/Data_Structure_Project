using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Project.Models
{
    internal class Mobiles
    {
        string m_phones;
        public string Phones { get { return m_phones; } set { m_phones = value; } }

        public override string ToString()
        {
            return Phones.ToString();
        }
    }
}
