namespace MethodsExercise
{
    internal class Program
    {
        public static void Main (string[] args)
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


            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add with the first number");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2, 4, 5, 6);
            Console.WriteLine($"The sum is {sum}");

            Console.WriteLine("Give me a number to multiply");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply with the first number");
            int y = int.Parse(Console.ReadLine());

            int product = Multiply(x, y);
            Console.WriteLine($"The sum is {product}");

        }
        public static int Sum( params int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }

    }
}
