using Week3_Library;

class Program
{
    static void Main(string[] args)
    {
        // Create new lists taht will be used to store books and members
        List<Book> books = new List<Book>();
        List<Member> members = new List<Member>();

        // Create a new instance (object) of the Book class
        // Note how the object name differs from the class name
        books.Add(new Book("C# for beginners", "Bill Gates", "1234"));
        books.Add(new Book("Ultimate C#", "Microsoft", "2233445"));
        

        // Create new instances of the Member class
        // These new members are created using the
        // Member constructor in the Members class
        members.Add(new Member(1, "John Smith", "1 High Street", 0790090090));
        members.Add(new Member(2, "Mary Jones", "102 Garden Road", 0790345666));

        // Display all items within the Book list
        foreach (Book book in books)
        {
            book.DisplayInfo();
        }

        foreach (Member member in members)
        {
            member.DisplayInfo();
        }
    }
}
