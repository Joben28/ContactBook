using ContactBookApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookApp.Services
{
    public interface IContactDataService
    {
        IEnumerable<Contact> GetContacts();
        void Save(IEnumerable<Contact> contacts);
    }
}
