using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactBookApp.Model;
using Newtonsoft.Json;

namespace ContactBookApp.Services
{
    public class JsonContactDataService : IContactDataService
    {
        public IEnumerable<Contact> GetContacts()
        {
            if (!File.Exists("Resources/contactdata.json"))
            {
                File.Create("Resources/contactdata.json").Close();
            }

            var serializedContacts = File.ReadAllText("Resources/contactdata.json");
            var contacts = JsonConvert.DeserializeObject<IEnumerable<Contact>>(serializedContacts);

            if (contacts == null)
                return new List<Contact>();

            return contacts;
        }

        public void Save(IEnumerable<Contact> contacts)
        {
            var serializedContacts = JsonConvert.SerializeObject(contacts);
            File.WriteAllText("Resources/contactdata.json", serializedContacts);
        }
    }
}
