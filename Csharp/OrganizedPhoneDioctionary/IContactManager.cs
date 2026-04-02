using System;
using System.Collections.Generic;
using System.Text;

namespace OrganizedPhoneDioctionary
{
    public interface IContactManager
    {
        public void PrintMenu();
        public void AddContact();
        public void PrintAllContacts();
        public void ModifyContact();
        public void DeleteContact();
        public void SearchContact();
        public void Exit();
    }
}
