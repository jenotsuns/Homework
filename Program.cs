
ConsoleKeyInfo status;

while (true)
{
    Console.WriteLine();
    Console.WriteLine("\n<><><><><><><  BASIC CALCULATOR  ><><><><><><>\n");
    Console.WriteLine($"Please enter 1st number:");
    double num1 = double.Parse(Console.ReadLine());
    Console.WriteLine($"\nPlease enter 2nd number:");
    double num2 = double.Parse(Console.ReadLine());
    Console.WriteLine("\nChoose an operation:\n");
    Console.WriteLine(" '+': addition; \n '-': subtraction;" +
        " \n '/': division; \n '*': multiplication;" +
        " \n '%': get remainder when the 1st number is divided by the 2nd number;" +
        " \n 'p': print out both numbers; \n ‘b’: print out biggest number;" +
        " \n 's': print out smallest number \n");
    char operation = char.Parse(Console.ReadLine());

    switch (operation)
    {
        case '+':
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            break;
        case '-':
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            break;
        case '/':
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            break;
        case '*':
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            break;
        case '%':
            Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
            break;
        case 'p':
            Console.WriteLine($"#1 = {num1} \n#2 = {num2}");
            break;
        case 'b':
            Console.WriteLine($"Biggest number = {Math.Max(num1, num2)}");
            break;
        case 's':
            Console.WriteLine($"Smallest number = {Math.Min(num1, num2)}");
            break;
        default:
            Console.WriteLine("Invalid, oops -( ° - ° )-");
            break;
    }


    Console.WriteLine("\n DO YOU WANT TO QUIT? (Y/y)");
    status = Console.ReadKey();
    if (status.Key == ConsoleKey.Y)
    {
        break;
    }

}
