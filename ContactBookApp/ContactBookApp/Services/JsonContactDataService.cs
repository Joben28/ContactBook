using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactBookApp.Model;

namespace ContactBookApp.Services
{
    public class JsonContactDataService : IContactDataService
    {
        public IEnumerable<Contact> GetContacts()
        {
            throw new NotImplementedException();
        }

        public void Save(IEnumerable<Contact> contacts)
        {
            throw new NotImplementedException();
        }
    }
}
