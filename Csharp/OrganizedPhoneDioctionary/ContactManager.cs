using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace OrganizedPhoneDioctionary
{
    public class ContactManager:IContactManager
    {
        private readonly Dictionary<decimal, string> _contacts = new Dictionary<decimal, string>();


        public void PrintMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Print All Contacts");
                Console.WriteLine("3. Modify Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Search Contact");
                Console.WriteLine("6. Exit\n");
                
                
                int option = Convert.ToInt32(Console.ReadLine());
                callProperFunctionality(option);
            }
        }

        public void callProperFunctionality(int option)
        {
            switch (option)
            {
                case 1:
                    AddContact();
                    break;
                case 2:
                    PrintAllContacts();
                    break;
                case 3:
                    ModifyContact();
                    break;
                case 4:
                    DeleteContact();
                    break;
                case 5:
                    SearchContact();
                    break;
                case 6:
                    Exit();
                    break;
                default:
                    Console.WriteLine("Please Choose Between 1-5");
                    break;
            }
        }

        public void AddContact()
        {
            Console.WriteLine("Enter Contact Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Contact Phone:");

            //check length of number
            decimal phone = Convert.ToDecimal(Console.ReadLine());
            string tempPhone = phone.ToString();

            while (tempPhone.Length != 10)
            {
                Console.WriteLine("Phone not valid: Enter a 10-digit phone");
                phone = Convert.ToDecimal(Console.ReadLine());
                tempPhone = phone.ToString();
            }
            _contacts.Add(phone, name);
            Console.WriteLine("Contact Added Successfully\n");
        }

        public void PrintAllContacts()
        {
            if (_contacts.Count == 0)
                Console.WriteLine("Contacts List is Empty");
            else
            {
                Console.WriteLine("Phone\tName\t");
                foreach (KeyValuePair<decimal, string> contact in _contacts)
                {
                    Console.WriteLine($"{contact.Value}\t{contact.Key}");
                }
            }
        }

        public void ModifyContact()
        {
            Console.WriteLine("Enter Contact Phone to Modify");
            decimal phoneToModify = Convert.ToDecimal(Console.ReadLine());
            if (_contacts.ContainsKey(phoneToModify))
            {
                Console.WriteLine("Enter New Name");
                string newName = Console.ReadLine();
                _contacts[phoneToModify] = newName;
            }
            else
            {
                Console.WriteLine("Contact not exists");
            }
        }

        public void DeleteContact()
        {
            Console.WriteLine("Enter Contact Phone to Delete");
            decimal phoneToDelete = Convert.ToDecimal(Console.ReadLine());
            if (_contacts.ContainsKey(phoneToDelete))
            {
                _contacts.Remove(phoneToDelete);
                Console.WriteLine("Contact Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Contact not exists");
            }
        }

        public void SearchContact()
        {
            Console.WriteLine("Enter Contact Phone to Search");
            decimal phoneToSearch = Convert.ToDecimal(Console.ReadLine());
            if (_contacts.ContainsKey(phoneToSearch))
            {
                Console.WriteLine($"Contact Found: Name: {_contacts[phoneToSearch]}");
            }
            else
            {
                Console.WriteLine("Contact not exists");
            }

        }

        public void Exit()
        {
            Console.WriteLine("Exiting the program...");
            Environment.Exit(0);
        }

    }
    }
