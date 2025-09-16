// See https://aka.ms/new-console-template for more information

var grade = 0;
Console.Write("What is you grade: ");
grade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your {grade} passed!");

string studentGrade = grade < 50 ? "You Failed" : "You Passed";
Console.WriteLine($"Your student status is {studentGrade}");
//Console.WriteLine($"Thy student with {grade} passed"); Console.WriteLine($"Thy student with {grade} failed");

Console.WriteLine("Enter a number in the days of the week: ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());

switch (dayOfTheWeek)
{
    case 0:
        Console.WriteLine("Sunday");
        break;
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednessday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    default:
        Console.WriteLine("Invalid day number");
        break;
}