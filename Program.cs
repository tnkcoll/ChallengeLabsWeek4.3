namespace ChallengeLabsWeek4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = GetUserInput();
            IsUserInputValid(s);
        }

        internal static string GetUserInput()
        {
            string? userInput;
            do
            {
                Console.WriteLine("Enter matching open and closed brackets.");
                userInput = Console.ReadLine();
                return userInput;
            } while (userInput == "");
        }

        internal static void IsUserInputValid(string input)
        {
            for (int i = 0; i < input.Length; i = i + 2)
            {
                if (input[i] != '{' && input[i] != '[' && input[i] != '(')
                {
                    StringValidity("Invalid");
                    return;
                }

                if (input[i] == '{' && input[i + 1] != '{')
                {
                    StringValidity("Invalid");
                    return;
                }

                if (input[i] == '[' && input[i + 1] != ']')
                {
                    StringValidity("Invalid");
                    return;
                }

                if (input[i] == '(' && input[i + 1] != ')')
                {
                    StringValidity("Invalid");
                    return;
                }
            }
            StringValidity("Valid");
        }

        internal static void StringValidity(string valid)
        {
            Console.WriteLine($"{valid} String");
        }
    }
}
