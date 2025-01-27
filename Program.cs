// See https://aka.ms/new-console-template for more information
/*
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
*/

public static class Program
{
    public static void Main()
    {
        List<Book> books = new List<Book>();
        books.Add(new Book { Title = "The Great Gatsby",Pages = 180,Price = 11});
        books.Add(new Book { Title = "War and Peace", Pages = 1225, Price = 20 });
        books.Add(new Book { Title = "Mockingbird", Pages = 324, Price = 8});
        books.Add(new Book { Title = "1984", Pages =  428, Price = 13 });

        Console.Write("Enter pages: ");
        int pages = Convert.ToInt32(Console.ReadLine());
        var book_filter = books.Where(book => book.Pages >= pages).OrderBy(book  => book.Price);
        foreach (var item in book_filter)
        {
            Console.WriteLine($"{item.Title} : {item.Price}");
            
        }

    }
   
}
class Book
{
    public string Title {  get; set; }
    public int Pages { get; set; }
    public int Price { get; set; }

}