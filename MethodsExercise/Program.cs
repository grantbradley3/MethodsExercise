namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Where do you want to travel to?");
            string place = Console.ReadLine();
            Console.WriteLine("Who do you want to bring with you?");
            string friend = Console.ReadLine();
            Console.WriteLine("What activities do you want to do while you are there?");
            string activities = Console.ReadLine();
            Console.WriteLine("How many days would you like to spend there?");
            var days = Console.ReadLine();
            Console.WriteLine($"Hello {name} we are flying you to {place} so that you can enjoy {activities} with your friend {friend} for {days} days ");
        }
    }
}
