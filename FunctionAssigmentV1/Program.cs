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
            name = AskName();

            // Ask for age and ensure it is a positive integer
            age = AskAge();

            // Print name and age
            PrintNameAndAge(name, age);

            // Check if the user is an adult
            CheckIfAdult(age);

            // Compare the name to another string (e.g., "Matti")
            string compareName = "Matti";

            CompareNames(name, compareName);
        }
        /// <summary>
        /// This function compares the user's name to a given name in both case-sensitive and case-insensitive ways.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="compareName"></param>
        private static void CompareNames(string name, string compareName)
        {
            // Comparison ignoring case
            if (name.Equals(compareName, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Your name matches 'Matti' (case-insensitive).");

            // Exact match comparison (case-sensitive)
            if (name.Equals(compareName))
                Console.WriteLine("Your name is exactly 'Matti' (case-sensitive).");
        }

        /// <summary>
        /// Thhis function asks for the user's age until a valid positive integer is provided.
        /// </summary>
        /// <returns></returns>
        private static int AskAge()
        {
            int age;
            while (true)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out age) && age > 0)
                    break;
                else
                    Console.WriteLine("Please enter a positive integer.");
            }

            return age;
        }

        /// <summary>
        /// This function checks if the user is an adult (18 or older) and prints a message accordingly.
        /// </summary>
        /// <param name="age"></param>
        private static void CheckIfAdult(int age)
        {
            if (age >= 18)
                Console.WriteLine("You are an adult.");
            else
                Console.WriteLine("You are not an adult.");
        }

        /// <summary>
        /// This function prints the user's inputs from name and age.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        private static void PrintNameAndAge(string name, int age)
        {
            Console.WriteLine($"Your name is {name} and your age is {age}.");
        }

        /// <summary>
        /// This function asks for the user's name until a valid name is provided.
        /// </summary>
        /// <returns></returns>
        private static string AskName()
        {
            string name;
            while (true)
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                    break;
                else
                    Console.WriteLine("Name cannot be empty.");
            }

            return name;
        }
    }
}