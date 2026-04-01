namespace StoreToList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare list 
            List<Person> people = new List<Person>(); 
            
            // loop to store 3 people
            for (int i=0; i<3; i++)
            {
                Console.WriteLine($"Enter info for person {i+1}");
                
                Console.WriteLine("Enter first name");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter last name");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter your age");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter afm");
                decimal afm = Convert.ToDecimal(Console.ReadLine());

                Person person = new Person(firstName,lastName,age,afm);
                people.Add(person);
                Console.WriteLine("Stored Successfully\n");
            }

            people.OrderBy(x=>x.LastName);

            //people.Sort((left, right) => string.Compare(left.LastName, right.LastName));
            Console.WriteLine("First Name\tLast Name\tAge\tAfm");
            //show all stored people filtered by lastName
            foreach (var item in people)
            {
                Console.WriteLine($"{item.FirstName}\t\t{item.LastName}\t{item.Age}\t{item.Afm}");
            }

        }
    }
}
