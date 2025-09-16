// See https://aka.ms/new-console-template for more information


/*
 this code is to collect user input
 */

string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;
decimal salary;
char gender = char.MinValue;
bool working = true;

Console.Write("Input your first name: ");
firstName = Console.ReadLine(); 

Console.Write("Input your last name: ");
lastName = Console.ReadLine();

Console.Write("What is your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("What is your salary: ");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("What is your gender: ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine();
int workingYearsRemaining = retirementAge - age;
Console.WriteLine($"Your name is {firstName} {lastName} " +
    $"and your Working year remaining is {workingYearsRemaining}," +
    $"your salary is ${salary}. " +
    $"You are a {gender} and {working}");