// See https://aka.ms/new-console-template for more information


/*
 this code is to collect user input
 */

string name = string.Empty;
int age = 0;
int retirementAge = 65;

Console.WriteLine("Input your name ");
name = Console.ReadLine();

Console.WriteLine("What is your age: ");
age = Convert.ToInt32(Console.ReadLine());

int workingYearsRemaining = retirementAge - age;
Console.WriteLine($"Your name is {name} and your Working year remainingi is {workingYearsRemaining}");