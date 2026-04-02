namespace Dictionary;

internal class Programm
{
    static void Main(string[] args)
    {
        Dictionary<string,string> contacts = new Dictionary<string,string>();


        bool exit = false;
        while (!exit)
        {
            //print menu
            Console.WriteLine("Phone Menu");
            Console.WriteLine("1. Add New Contact");
            Console.WriteLine("2. Print All Contacts");
            Console.WriteLine("3. Modify Existing Contact");
            Console.WriteLine("4. Delete Contact");
            Console.WriteLine("5. Search Contact");
            Console.WriteLine("6. Exit\n\n");

            //user option
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1: // add contact
                    Console.WriteLine("Enter Contact Number:");
                    string phone = Console.ReadLine();
                    Console.WriteLine("Enter Contact Name:");
                    string name = Console.ReadLine();
                    contacts.Add(name,phone);
                    Console.WriteLine("Contact Added Successfully\n");
                    break;

                case 2: //show all contacts
                    if (contacts.Count==0)
                        Console.WriteLine("Contacts List is Empty");
                    else
                    {
                        Console.WriteLine("Name\tPhone\t");
                        foreach (KeyValuePair<string,string> contact in contacts)
                        {
                            Console.WriteLine($"{contact.Key}\t{contact.Value}");
                        }
                    }
                    break;

                case 3: //modify contact
                    Console.WriteLine("Enter Contact Name to Modify");
                    string nameToModify = Console.ReadLine();

                    if (contacts.ContainsKey(nameToModify))
                    {
                        Console.WriteLine("Enter New Phone");
                        string newPhone = Console.ReadLine();
                        contacts[nameToModify] = newPhone;
                    }
                    else
                    {
                        Console.WriteLine("Contact not exists");
                    }
                    
                    break;

                case 4: //delete contact
                    Console.WriteLine("Enter Contact Name to Delete");
                    string nameToDelete = Console.ReadLine();
                    
                    if (contacts.ContainsKey(nameToDelete))
                    {
                        contacts.Remove(nameToDelete);
                        Console.WriteLine("Contact Deleted");
                    }
                    else
                    {
                        Console.WriteLine("Contact not exists");
                    }
                    break;

                case 5: //search contact
                    Console.WriteLine("Enter Contact to Search");
                    string contactToSearch = Console.ReadLine();

                    if (contacts.ContainsKey(contactToSearch))
                    {
                        Console.WriteLine($"Name: {contactToSearch} - Phone: {contacts[contactToSearch]}");
                    }
                    else
                    {
                        Console.WriteLine("Contact not Found");
                    }
                    break;
                
                case 6:
                    exit=true;
                    Console.WriteLine("Terminating Programm");
                    break;

                default:
                    Console.WriteLine("Enter a number from 1 to 5");
                    break;

            }
        }
    }
}
