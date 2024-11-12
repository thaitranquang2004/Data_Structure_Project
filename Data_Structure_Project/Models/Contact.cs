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
        private string m_mobile2;
        private string m_mobile3;
        private string m_email;
        private string m_email2;
        private string m_email3;
        private string m_address;
        private string m_relationship;
        private string m_gender;
        private int m_status;

        public int Id { get { return m_id; } set { m_id = value; } }
        public string Name { get { return m_name; } set { m_name = value; } }
        public string Mobile { get { return m_mobile; } set { m_mobile = value; } }
        public string Mobile2 { get { return m_mobile2; } set { m_mobile2 = value; } }
        public string Mobile3 { get { return m_mobile3; } set { m_mobile3 = value; } }

        public string Email { get { return m_email; } set { m_email = value; } }
        public string Email2 { get { return m_email2; } set { m_email2 = value; } }
        public string Email3 { get { return m_email3; } set { m_email3 = value; } }

        public string Address { get { return m_address; } set { m_address = value; } }
        public string Relationship { get { return m_relationship; } set { m_relationship = value; } }
        public string Gender { get { return m_gender; } set { m_gender = value; } }
        public int Status { get { return m_status; } set { m_status = value; } }


        public override string ToString()
        {
            return Name.ToUpper();
        }
    }
}
