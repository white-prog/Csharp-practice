// See https://aka.ms/new-console-template for more information

void SumOfdigits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum += value % 10;
        value /= 10;

    }
    Console.WriteLine(sum);


}





while (true)
{
    Console.Write("X to Exit : ");
    string? exitPoint = Console.ReadLine();
    if (exitPoint.Equals("X"))
    {
        Console.WriteLine("Thank you");
        break;
    }
    Console.Write("Enter digits");
    int number = Convert.ToInt32(Console.ReadLine());

    Console.Write("Sum of digits: ");
    SumOfdigits(number);

}

