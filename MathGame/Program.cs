
//Start Applicationn 

using System.Runtime.CompilerServices;
using System.Security;

while (true)
{
    string answer = Calculation.GetAnswer();
    Console.WriteLine($"Selected Option: {answer}");
    Calculation.ProcessAnswer(answer);
    Console.WriteLine("If you want to continue please click any character");
    string exitKey = Console.ReadLine();

    if (exitKey == "exit")    
        break;
    
}

class Calculation
{
    public static Dictionary<string, string> PreviousGames = new Dictionary<string, string>();
    public static string GetAnswer()
    {

        Console.WriteLine("What would you like to play today?. Choose from the options below:");
        Console.WriteLine(" ----------------------------------- ");
        Console.WriteLine("| A - View Previous Games           |");
        Console.WriteLine("| B - Addition                      |");
        Console.WriteLine("| C - Subtraction                   |");
        Console.WriteLine("| D - Multiplaction                 |");
        Console.WriteLine("| E - Division                      |");
        Console.WriteLine("| F - Quit the program              |");
        Console.WriteLine(" ----------------------------------- ");

        return Console.ReadLine() ?? "";
    }

    public  static string ProcessAnswer(string answer)
    {
        //Process answer 
        switch (answer.ToUpper())
        {
            case "A":
                Console.WriteLine("Previous Games: ");
                Console.WriteLine(ViewPreviousGames());
                break;
            case "B":             
                Console.WriteLine(Addition(GetAdditionNumbers()));
                break;
            case "C":
                Console.WriteLine(Subtraction(GetSubtractionNumbers()));
                break;
            case "D":
                Console.WriteLine(Multiplication(GetMultiplicationNumbers()));
                break;
            case "E":
                Console.WriteLine(Division(GetDivisionNumbers()));
                break;
            case "F":
                Environment.Exit(0) ;
                break;
            default:
                Console.WriteLine("Please Select a valid game!!");
                break;
        }

        return "";
    }

    public static string ViewPreviousGames()
    {
        string result = "";
        if (PreviousGames.Count == 0)        
            result = "There is no any game to show!";
        
        foreach (var item in PreviousGames)        
            result += $"Game: {item.Key} - Result: {item.Value}  \n "; 
        
        return result;
    }
    #region Addition
    public static List<int> GetAdditionNumbers()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("== Welcome to Addition Math Game ==");
        Console.WriteLine("Enter the numbers you want to add. Press 'n' and Enter to finish.");
        string output = "Entered Numbers: ";
        while (true)
        {
            string inputValue = Console.ReadLine() ?? "";

            if (inputValue.ToLower() == "n")
                break;

            if (int.TryParse(inputValue, out int number))
            {
                numbers.Add(number);
                output += numbers.Count > 1 ? $"+ {number} " : $" {number} ";
                Console.WriteLine(output);
            }
            else
                Console.WriteLine("Invalid input. Please enter a valid number or 'n' to finish.");
        }

        return numbers;
    }
    public static string Addition(List<int> inputNumbers)
    {
        int result = 0;
        foreach (var item in inputNumbers)
            result += item;

        PreviousGames.Add("B", $"The result is: {result.ToString()}");
        return $"The result is: {result.ToString()}";
    }
    #endregion
    #region Subtraction

    public static List<int> GetSubtractionNumbers()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("== Welcome to Subtraction Math Game ==");
        Console.WriteLine("Enter the numbers you want to Subtract. Press 'n' and Enter to finish.");
        string output = "Entered Numbers: ";
        while (true)
        {
            string inputValue = Console.ReadLine() ?? "";

            if (inputValue.ToLower() == "n")
                break;

            if (int.TryParse(inputValue, out int number))
            {
                numbers.Add(number);
                output += numbers.Count > 1 ? $"- {number} " : $" {number} ";
                Console.WriteLine(output);
            }
            else
                Console.WriteLine("Invalid input. Please enter a valid number or 'n' to finish.");
        }

        return numbers;
    }
    public static string Subtraction(List<int> inputNumbers)
    {
        int result = inputNumbers[0];
        for (int i = 1; i < inputNumbers.Count; i++)        
            result -= inputNumbers[i];

        PreviousGames.Add("C", $"The result is: {result.ToString()}");
        return $"The result is: {result.ToString()}";
    }
    #endregion

    #region Multiplication
    public static List<int> GetMultiplicationNumbers()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("== Welcome to Multiplication Math Game ==");
        Console.WriteLine("Enter the numbers you want to add. Press 'n' and Enter to finish.");
        string output = "Entered Numbers: ";
        while (true)
        {
            string inputValue = Console.ReadLine() ?? "";

            if (inputValue.ToLower() == "n")
                break;

            if (int.TryParse(inputValue, out int number))
            {
                numbers.Add(number);
                output += numbers.Count > 1 ? $"* {number} " : $" {number} ";
                Console.WriteLine(output);
            }
            else
                Console.WriteLine("Invalid input. Please enter a valid number or 'n' to finish.");
        }

        return numbers;
    }
    public static string Multiplication(List<int> inputNumbers)
    {
        int result = 1;
        foreach (var item in inputNumbers)
            result *= item;

        PreviousGames.Add("D", $"The result is: {result.ToString()}");
        return $"The result is: {result.ToString()}";
    }

    #endregion

    #region Division
    public static List<int> GetDivisionNumbers()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("== Welcome to Division Math Game ==");
        Console.WriteLine("Enter the numbers you want to add. Press 'n' and Enter to finish.");
        string output = "Entered Numbers: ";
        while (true)
        {
            string inputValue = Console.ReadLine() ?? "";

            if (inputValue.ToLower() == "n")
                break;

            if (int.TryParse(inputValue, out int number))
            {
                numbers.Add(number);
                output += numbers.Count > 1 ? $"/ {number} " : $" {number} ";
                Console.WriteLine(output);
            }
            else
                Console.WriteLine("Invalid input. Please enter a valid number or 'n' to finish.");
        }

        return numbers;
    }
    public static string Division(List<int> inputNumbers)
    {
        int result = inputNumbers[0];
        for (int i = 1; i < inputNumbers.Count; i++)
            result /= inputNumbers[i];

        PreviousGames.Add("E", $"The result is: {result.ToString()}");
        return $"The result is: {result.ToString()}";
    }

    #endregion
}




