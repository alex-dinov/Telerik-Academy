using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistant
{
    class PersonalAssistant
    {
        public List<Contact> Contacts { get; set; }
        public List<Appoinment> Appoinments { get; set; }

        public PersonalAssistant()
        {
            this.Contacts = new List<Contact>();
            this.Appoinments = new List<Appoinment>();
        }

        public void AddContact(Contact contact)
        {
            this.Contacts.Add(contact);
        }
    }
}
