namespace DataStractures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list= new int[5];
            int input;
            Console.WriteLine("Give 5 numbers");

            for (int i=0; i<5; i++)
            {
                Console.WriteLine($"Enter number {i+1}:");
                input = Convert.ToInt32(Console.ReadLine());
                list[i] = input;
            }
            Array.Reverse(list);
            Console.WriteLine(string.Join(",",list));
            
        }
    }
}

