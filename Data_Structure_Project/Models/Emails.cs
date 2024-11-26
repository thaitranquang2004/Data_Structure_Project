using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Project.Models
{
    internal class Emails
    {
        string m_emails;
        public string Email { get { return m_emails; } set { m_emails = value; } }

        public override string ToString()
        {
            return Email.ToString();
        }
    }
}
