// Reverse It

using System.ComponentModel.DataAnnotations;

bool playAgain = true;
string breakLine = "----------------------------------------------------------------";




while (playAgain)
{
    Console.Clear();
    Console.WriteLine(breakLine);
    Console.WriteLine("Today we are going to do some reversing.");
    Console.WriteLine("I'm going to need you to choose either 'string' or 'int'");
    Console.WriteLine(breakLine);

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
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine($"Original: {userWord} Reversed: {revWord}");
            Console.WriteLine(breakLine);
            intString = false;
        }
        else if (stringIntCheck?.ToLower() == "int")
        {
            // number/int reverse
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine("Please enter a sequence of numbers that are above 0 to be reversed.");
            Console.WriteLine(breakLine);
            bool isNum = Int32.TryParse(Console.ReadLine(), out userNum);

            while (isNum == false)
            {
                Console.Clear();
                Console.WriteLine(breakLine);
                Console.WriteLine("That doesn't seem to be a number.");
                Console.WriteLine(breakLine);
                isNum = Int32.TryParse(Console.ReadLine(), out userNum);

            }
            int ogNum = userNum;
            while (userNum > 0)
            {
                result = (result * 10) + (userNum % 10);
                userNum = userNum / 10;
                
            }
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine($"Original: {ogNum} Reversed: {result}");
            Console.WriteLine(breakLine);
            intString = false;

        }
        else
        {
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine("That was not 'int' or 'string', try that again.");
            Console.WriteLine(breakLine);
        }
    }

    // plat again loop
    Console.WriteLine("Play again. 'yes' or 'no'.");
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


















