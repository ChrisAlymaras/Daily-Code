namespace OrganizedPhoneDioctionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IContactManager contactManager= new ContactManager();
            contactManager.PrintMenu();
        }
    }
}
