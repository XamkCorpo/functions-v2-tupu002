namespace FunctionAssigmentV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Everything is intentionally inside Main before refactoring to functions
            //Your job is to refactor this code to use functions for better readability and reusability.
            //Check learn on how to do this
            string name = "";
            int age = 0;

            // Ask for name and ensure it is not empty
            while (true)
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                    break;
                else
                    Console.WriteLine("Name cannot be empty.");
            }

            // Ask for age and ensure it is a positive integer
            while (true)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out age) && age > 0)
                    break;
                else
                    Console.WriteLine("Please enter a positive integer.");
            }

            // Print name and age
            Console.WriteLine($"Your name is {name} and your age is {age}.");

            // Check if the user is an adult
            if (age >= 18)
                Console.WriteLine("You are an adult.");
            else
                Console.WriteLine("You are not an adult.");

            // Compare the name to another string (e.g., "Matti")
            string compareName = "Matti";

            // Comparison ignoring case
            if (name.Equals(compareName, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Your name matches 'Matti' (case-insensitive).");

            // Exact match comparison (case-sensitive)
            if (name.Equals(compareName))
                Console.WriteLine("Your name is exactly 'Matti' (case-sensitive).");
        }
    }
}