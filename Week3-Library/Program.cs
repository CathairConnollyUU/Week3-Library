using Week3_Library;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance (object) of the Book class
        // Note how the object name differs from the class name
        Book myBook1 = new Book("C# for beginners", "Bill Gates", "1234");

        // Output book information to the console
        myBook1.DisplayInfo();
    }
}
