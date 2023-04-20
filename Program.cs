using System.ComponentModel.Design;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILibrary library = new Book();
            Book.books = new LinkedList<Book>();
            Book[] book =
            {
                new Book("Programming", "John Doe", "Computer scinse", 2020),
                new Book("Programming", "John Doe", "Computer scinse", 2020),
                new Book("Programming", "John Doe", "Computer scinse", 2020),
                new Book("Programming", "John Doe", "Computer scinse", 2020),
                new Book("Programming", "John Doe", "Computer scinse", 2020),
                new Book("Programming", "John Doe", "Computer scinse", 2020),
                new Book("Programming", "John Doe", "Computer scinse", 2020)
            };
            List<Book> books = new List<Book>
            {
                new Book("Programming", "John Doe", "Computer scinse", 2020),
                new Book("Programming", "John Doe", "Computer scinse", 2020),
                new Book("Programming", "John Doe", "Computer scinse", 2020),
                new Book("Programming", "John Doe", "Computer scinse", 2020),
                new Book("Programming", "John Doe", "Computer scinse", 2020),
                new Book("Programming", "John Doe", "Computer scinse", 2020),
                new Book("Programming", "John Doe", "Computer scinse", 2020)
            };
            int choser = 0;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.  Add one book\n" +
                                  "2.  Add array of books\n" +
                                  "3.  Add list of books\n" +
                                  "4.  Show all books\n" +
                                  "5.  Show book by number\n" +
                                  "6.  Delete book from begin\n" +
                                  "7.  Delete book from end\n" +
                                  "8.  Delete book by number\n" +
                                  "9.  Insert book in begin" +
                                  "10. Insert book in end" +
                                  "11. Insert book by index" +
                                  "12. Change book\n" +
                                  "0.  Exit");
                Console.Write("Choose variant: ");
                choser = Convert.ToInt32(Console.ReadLine());
                switch (choser)
                {
                    case 0:
                        return;
                    case 1:
                        library.AddBook(new Book("Programming", "John Doe", "Computer scinse", 2020));
                        break;
                    case 2:
                        library.AddBook(book);
                        break;
                    case 3:
                        library.AddBook(books);
                        break;
                    case 4:
                        library.ShowAll();
                        break;
                    case 5:
                        library.ShowByNumber();
                        break;
                    case 6:
                        library.RemoveInBegin();
                        break;
                    case 7:
                        library.RemoveInEnd();
                        break;
                    case 8:
                        library.RemoveByPosition();
                        break;
                    case 9:
                        library.InsrertInBegin();
                        break;
                    case 10:
                        library.InsrertInEnd();
                        break;
                    case 11:
                        library.InsertByPosition();
                        break;
                    case 12:
                        library.ChangeInfo();
                        break;
                    default:
                        Console.WriteLine("Wrong input!!!");
                        break;
                }
            } while (choser > 0);
            

        }
    }
}