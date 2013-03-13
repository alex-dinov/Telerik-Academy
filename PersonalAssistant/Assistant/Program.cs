using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistant
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalAssistant assistant = new PersonalAssistant();
            assistant.AddContact(new Contact(new Person("Gosho")));
            assistant.AddContact(new Contact(new Person("Pencho",new Firm("Telerik"))));

            foreach (var contact in assistant.Contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
