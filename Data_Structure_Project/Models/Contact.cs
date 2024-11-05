using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Project.Models
{
    internal class Contact
    {
        private int m_id;
        private string m_name;
        private string m_mobile;
        private string m_email;
        private int m_status;
        //private PhoneNode PhoneNode { get; set; };

        public int Id { get { return m_id; } set { m_id = value; } }
        public string Name { get { return m_name; } set { m_name = value; } }
        public string Mobile { get { return m_mobile; } set { m_mobile = value; } }
        public string Email { get { return m_email; } set { m_email = value; } }
        public int Status { get { return m_status; } set { m_status = value; } }

        public override string ToString()
        {
            return "id: " + Id + " name: " + Name + " mobile: " + Mobile + " email: " + Email + " status: " + Status;
        }
    }
}
