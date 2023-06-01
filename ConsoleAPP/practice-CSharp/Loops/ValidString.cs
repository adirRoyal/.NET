using System;
using System.Linq;
//write code that validates string input
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
do
{
    string inputUser = Console.ReadLine();
    inputUser.Trim().ToLower();

    if (inputUser.Contains("administrator") ||
        inputUser.Contains("manager") ||
        inputUser.Contains("user"))
        Console.WriteLine($"Your input value {inputUser} has been accepted.");
    else
        Console.WriteLine($"The role name that you entered, {inputUser} is not valid. Enter your role name (Administrator, Manager, or User)");
}
while (true);
