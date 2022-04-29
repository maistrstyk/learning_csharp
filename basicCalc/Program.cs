// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello in my basic calculator!");
string number;
float firstNumber = 0;
float secondNumber = 0;
double result = 0.0;
bool repeet = true;

do
{
    bool wrongSign = true;
    bool answer = true;

    Console.WriteLine("\nWrite first number.");
    firstNumber = IsNumber();
    
    Console.WriteLine("Choose action:\n" +
        "+ >> suma\n" +
        "- >> minus\n" +
        "* >> times\n" +
        "/ >> divide\n" +
        "% >> residue after divide\n" +
        "^ >> power by 2\n");

    while (wrongSign) { 
        switch (Console.ReadKey().KeyChar.ToString().ToLower())
        {
            case "+":
                Console.WriteLine("\nWrite second number.");
                secondNumber = IsNumber();
                result = firstNumber + secondNumber;
                wrongSign = false;
                break;
            case "-":
                Console.WriteLine("\nWrite second number.");
                secondNumber = IsNumber();
                result = firstNumber - secondNumber;
                wrongSign = false;
                break;
            case "*":
                Console.WriteLine("\nWrite second number.");
                secondNumber = IsNumber();
                result = firstNumber * secondNumber;
                wrongSign = false;
                break;
            case "/":
                Console.WriteLine("\nWrite second number.");
                secondNumber = IsNumber();
                result = firstNumber / secondNumber;
                wrongSign = false;
            break;
            case "%":
                Console.WriteLine("\nWrite second number.");
                secondNumber = IsNumber();
                result = firstNumber % secondNumber;
                wrongSign = false;
                break;
            case "^":
                result = Math.Pow(firstNumber, 2);
                wrongSign = false;
                break;
            default:
                Console.WriteLine("\nYou write wrong character. Try again.\n");
                wrongSign = true;
                break;
        }
    }

    Console.WriteLine("Result: " + result);



    while (answer)
    {
        Console.WriteLine("Do you want calculate again? Write y/n:\n");
        switch (Console.ReadKey().KeyChar.ToString().ToLower())
        {
            case "y":
                repeet = true;
                answer = false;
                break;
            case "n":
                repeet = false;
                answer = false;
                break;
            default:
                Console.WriteLine("\nWrong answer. Write only y/n\n");
                answer = true;
                break;
        }


    } ;

} while (repeet);


static float IsNumber()
{
    float number = 0;
    while (!float.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("\nIts not a number. Try again.\n");
    }
    return number;
}


