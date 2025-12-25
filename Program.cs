// See https://aka.ms/new-console-template for more information

//initialized variables used in this project

//user supplied variables
using System.IO.Pipelines;

string userInput = "";
decimal num1 = 0;
decimal num2 = 0;
decimal numOutput;

int spaces = 0;
List<string> operators = new List<string>() { "-", "+", "/", "*" };

//add space for top line
System.Console.WriteLine();
Console.WriteLine($"Hello User {Environment.UserName} to the C# Console Calculator App");

Thread.Sleep(3000);

System.Console.WriteLine();
System.Console.WriteLine("Mathematical operators loading in:");
System.Console.WriteLine();

int n = 4;
for (int j = 0; j < 3; j++)
{
    n--;
    System.Console.WriteLine($"{n}");
    Thread.Sleep(1000);
}

//code to simulate data "loading"
for (int k = 0; k < 2; k++)
{
    for (int i = 0; i < 25; i++)
    {
        spaces++;
        System.Console.WriteLine("Loading " + new string('-', spaces) + ">");
        Thread.Sleep(25);
    }

    for (int i = 0; i < 25; i++)
    {
        spaces--;
        System.Console.WriteLine("Loading " + new string('-', spaces) + ">");
        Thread.Sleep(25);
    }
}

spaces = 100;

System.Console.WriteLine(new string('-', spaces));
Thread.Sleep(100);


//explanation of what operators the program accepts
foreach (string item in operators)
{
    if (item is "-")
        System.Console.WriteLine($"'{item}' is the substraction operator. It will substract the 2nd number from the first number.");
    Thread.Sleep(100);


    if (item is "+")
        System.Console.WriteLine($"'{item}' is the addition operator. It will add two numbers together.");
    Thread.Sleep(100);


    if (item is "/")
        System.Console.WriteLine($"'{item}' is the division operator. It will divide the second number into the first number.");
    Thread.Sleep(100);


    if (item is "*")
        System.Console.WriteLine($"'{item}' is the multiplication operator. It will multiply two numbers together.");
    Thread.Sleep(100);


}

System.Console.WriteLine(new string('-', spaces));
Thread.Sleep(100);

//below code to read input from user

System.Console.WriteLine();

while (!operators.Contains(userInput))
{
    System.Console.WriteLine("Which operation would you like to perform? (type one)");

    userInput = Console.ReadLine()!;

    if (!operators.Contains(userInput))
        System.Console.WriteLine($"Value '{userInput}' is not a valid operation. Please select a valid operation.");

    System.Console.WriteLine();
}

System.Console.WriteLine("Loading");

System.Console.WriteLine();

Thread.Sleep(2000);
System.Console.WriteLine("Type a Number for the first value");

//logic to only allow numbers
while (!decimal.TryParse(Console.ReadLine(), out num1))
{
    Console.WriteLine("Invalid input for 'num1'. Please type a number:");
}

System.Console.WriteLine("Loading");
System.Console.WriteLine();

Thread.Sleep(2000);

System.Console.WriteLine("Type a Number for the second value");

//logic to only allow numbers and non zero if operation is division
while (!decimal.TryParse(Console.ReadLine(), out num2) || userInput is "/" && num2 == 0)
{
    Console.WriteLine("Invalid input for 'num2'. Please type a number:");
}

System.Console.WriteLine("Loading");
System.Console.WriteLine();
Thread.Sleep(2000);

switch (userInput)

{
    //subtraction logic
    case "-":
        numOutput = num1 - num2;
        System.Console.WriteLine($"{num1}-{num2} results in {numOutput}");
        System.Console.WriteLine();
        System.Console.WriteLine("Program complete. run again to perform a different calculation.");
        break;

    //addition logic
    case "+":
        numOutput = num1 + num2;
        System.Console.WriteLine($"{num1}+{num2} results in {numOutput}");
        System.Console.WriteLine();
        System.Console.WriteLine("Program complete. run again to perform a different calculation.");
        break;

    //Division logic
    case "/":
        numOutput = num1 / num2;
        System.Console.WriteLine($"{num1}/{num2} results in {numOutput}");
        System.Console.WriteLine();
        System.Console.WriteLine("Program complete. run again to perform a different calculation.");
        break;

    //Multiplication logic
    case "*":
        numOutput = num1 * num2;
        System.Console.WriteLine($"{num1}*{num2} results in {numOutput}");
        System.Console.WriteLine();
        System.Console.WriteLine("Program complete. run again to perform a different calculation.");
        break;
}