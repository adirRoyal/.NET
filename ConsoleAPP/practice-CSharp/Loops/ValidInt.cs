using System;
//write code that validates integer input
Console.WriteLine("Enter an integer value between 5 and 10.");
do
{ 
    int inputNum;
    bool inputUser = int.TryParse(Console.ReadLine(),out inputNum);
    
    if(inputUser == false)
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    if (inputUser == true)
    {
        if (inputNum < 5 || inputNum > 10)
            Console.WriteLine($"You entered {inputNum}. Please enter a number between 5 and 10.");
        else
            Console.WriteLine($"Your input value {inputNum} has been accepted.");
    }
}
while (true);

