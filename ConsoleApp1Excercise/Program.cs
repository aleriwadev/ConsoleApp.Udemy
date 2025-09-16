using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        // TODO 1:
        // Create and return an integer variable named 'age' initialized to 18.
        // Return that value.
        public static int InitAge()
        {
            int age = 18;
            return age;
            //Console.WriteLine(age);
            // TODO
            throw new NotImplementedException();
        }

        // TODO 2:
        // Use string interpolation to return "Hello, {firstName}!"
        // Examples: "Hello, Trevoir!"  "Hello, Ada!"
        public static string FormatGreeting(string firstName)
        {
            //firstName = "Daniel";
            return ($"Hello {firstName}");
            // TODO
            throw new NotImplementedException();
        }

        // TODO 3:
        // Return the sum of a and b.
        // This tests basic arithmetic and variable use.
        public static int AddTwoNumbers(int a, int b)
        {
            // a = 23;
            // b = 32;
            int sum = a + b;
            return sum;
            // Console.WriteLine(sum);
            // TODO
            //throw new NotImplementedException();
        }

        // TODO 4:
        // Try to parse the input string as an int.
        // If input is null, empty, whitespace, or not a valid number, return 0.
        public static int ParseIntOrZero(string? input)
        {

            // TODO
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            return int.TryParse(input, out var value) ? value : 0;
            //throw new NotImplementedException();
        }

        // TODO 5:
        // Return a short summary line using string interpolation:
        // "Name: {name}, Age: {age}"
        // Example: MakeSummary("Sam", 21) -> "Name: Sam, Age: 21"
        public static string MakeSummary(string name, int age)
        {
            // name = "Daniel";
            // age = 23
            return ($"Name: {name}, Age: {age}");
            // TODO
            //throw new NotImplementedException();
        }
    }
}
