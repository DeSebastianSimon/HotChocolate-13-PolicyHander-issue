namespace HotChocolate_13_1_Authhandler.Types
{
    public class Book
    {
        public string Title { get; set; } = "Book Title";

        public Author Author { get; set; } = new Author() { Name = "Author Name" };

        public Publisher Publisher { get; set; } = new Publisher { Name = "Publisher Name" };
    }
}
