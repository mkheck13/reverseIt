// Reverse It

using System.ComponentModel.DataAnnotations;

bool playAgain = true;
string breakLine = "----------------------------------------------------------------";

Console.Clear();


while (playAgain)
{
    Console.WriteLine("Today we are going to do some reversing.");
    Console.WriteLine("I'm going to need you to choose either 'string' or 'int'");

    bool intString = true;
    string userWord;
    string revWord = "";
    int userNum;
    int result = 0;

    while (intString == true)
    {
        string? stringIntCheck = Console.ReadLine();
        if (stringIntCheck?.ToLower() == "string")
        {
            // string reverse
            Console.Clear();
            Console.WriteLine("Please enter a string for me to reverse");
            userWord = Console.ReadLine();
            for (int i = userWord.Length - 1; i >= 0; i--)
            {
                revWord += userWord[i];
            }
            Console.WriteLine($"Original: {userWord} Reversed: {revWord}");
            break;
        }
        else if (stringIntCheck?.ToLower() == "int")
        {
            bool isNum = Int32.TryParse(Console.ReadLine(), out userNum);

            while (true)
            {
                if (!isNum)
                {
                    Console.WriteLine("That doesn't seem to be a number.");
                    isNum = Int32.TryParse(Console.ReadLine(), out userNum);
                }
                else
                {
                    while (userNum > 0)
                    {
                        result = (result * 10) + (userNum % 10);
                        userNum = userNum / 10;
                    }
                    Console.WriteLine(userNum + result);
                    break;

                }
            }

        }
    }







    bool yesNo = true;

    while (yesNo == true)
    {
        string? userInput = Console.ReadLine();
        if (userInput?.ToLower() == "yes")
        {
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine("Looks like we are going again!");
            yesNo = false;
        }
        else if (userInput?.ToLower() == "no")
        {
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine("Til next time.");
            Console.WriteLine(breakLine);
            yesNo = false;
            playAgain = false;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine("That doesn't seem to be a yes or a no. How about you try that again.");
            Console.WriteLine(breakLine);
        }
    }

















}










// number/int reverse







