// See https://aka.ms/new-console-template for more information


/*
 this code is to collect user input
 */

string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;

Console.Write("Input your first name: ");
firstName = Console.ReadLine(); 

Console.Write("Input your last name: ");
lastName = Console.ReadLine();

Console.Write("What is your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int workingYearsRemaining = retirementAge - age;
Console.WriteLine($"Your name is {firstName} {lastName} and your Working year remaining is {workingYearsRemaining}");