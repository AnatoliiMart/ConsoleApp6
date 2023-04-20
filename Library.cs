using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
// Создайте приложение для учёта книг. Необходимо хранить следующую информацию:

// Название книги
// ФИО автора
// Жанр книги
// Год выпуска

//Для хранения книг используйте класс LinkedList<T>.

//Приложение должно предоставлять такую функциональность:

// Добавление книг (по одной, массивом, списком)
// Вывод всего списка книг
// Вывод книги по номеру в списке
// Удаление книг
// Изменение информации о книгах (через индекс)
// Поиск книг по параметрам
// Вставка книги в начало списка
// Вставка книги в конец списка
// Вставка книги в определенную позицию
// Удаление книги из начала списка
// Удаление книги из конца списка
// Удаление книги из определенной позиции




// Создать меню/подменю пользователя
namespace ConsoleApp6
{
    interface ILibrary
    {
        void AddBook(Book book);
        void AddBook(Book[] books);
        void AddBook(List<Book> books);
        void SearchBookByAuthor();
        void SearchBookByName();
        void SearchBookByCreationYear();
        void SearchBookByGenre();
        void InsrertInBegin();
        void InsrertInEnd();
        void InsertByPosition();
        void RemoveInBegin();
        void RemoveInEnd();
        void RemoveByPosition();
        void ChangeInfo();
        void ShowAll();
        void ShowByNumber();

    }

    public class Book : ILibrary
    {
        public string bookTitle { get; set; }

        public string authorName { get; set; }

        public string genre { get; set; }

        public int yearOfCreation { get; set; }

        static public LinkedList<Book> books;

        public Book() { }

        public Book(string BookName, string AuthorName, string Genre, int YearOfCreation)
        {
          
            bookTitle = BookName;
            authorName = AuthorName;
            genre = Genre;
            yearOfCreation = YearOfCreation;
        }
        void InputData()
        {
            Console.Write("Enter book name: ");
            bookTitle = Console.ReadLine();

            Console.Write("Enter author name: ");
            authorName = Console.ReadLine();

            Console.Write("Enter genre of book: ");
            genre = Console.ReadLine();

            Console.Write("Enter year of book creation: ");
            yearOfCreation = Convert.ToInt32(Console.ReadLine());

        }

        public void AddBook(Book book)
        {
            if (books.Count == 0)
                books.AddFirst(book);
            else
                books.AddLast(book);
        }

        public void AddBook(Book[] Books)
        {
            foreach (var item in Books)
                books.AddLast(item);
        }

        public void AddBook(List<Book> Books)
        {
            foreach (var item in Books)
                books.AddLast(item);
        }

        public void ChangeInfo()
        {
            Console.WriteLine("Enter index of book what you want to change");
            int index = Convert.ToInt32(Console.ReadLine());
        }

        public void InsertByPosition()
        {
            throw new NotImplementedException();
        }

        public void InsrertInBegin()
        {
           Book book = new Book();
            Console.WriteLine("Enter book for insertion: ");
            book.InputData();
            books.AddFirst(book);
        }

        public void InsrertInEnd()
        {
            Book book = new Book();
            Console.WriteLine("Enter book for insertion: ");
            book.InputData();
            books.AddLast(book);
        }

        public void RemoveByPosition()
        {
            throw new NotImplementedException();
        }

        public void RemoveInBegin()
        {
            if (books.Count <= 0)
                Console.WriteLine("Nothing to remove");
            else
                books.RemoveFirst();
           
        }

        public void RemoveInEnd()
        {
            if (books.Count <= 0)
            {
                Console.WriteLine("Nothing to remove");
            }
            else
            {
                books.RemoveLast();
            }
        }

        public void SearchBookByAuthor()
        {
            Console.WriteLine("Enter searching author name:");
            string? str = Console.ReadLine();
            var res = from book in books
                      where book.authorName == str
                      select book;
            if (res == null)
                Console.WriteLine("No results");
            else
                foreach (var item in res)
                    Console.WriteLine(item.ToString());
        }

        public void SearchBookByCreationYear()
        {
            Console.WriteLine("Enter searching book creation year:");
            int tmp = Convert.ToInt32(Console.ReadLine());
            var res = from book in books
                      where book.yearOfCreation == tmp
                      select book;
            if (res == null)
                Console.WriteLine("No results");
            else
                foreach (var item in res)
                    Console.WriteLine(item.ToString());
        }

        public void SearchBookByGenre()
        {
            Console.WriteLine("Enter searching book genre:");
            string? str = Console.ReadLine();
            var res = from book in books
                      where book.genre == str
                      select book;
            if (res == null)
                Console.WriteLine("No results");
            else
                foreach (var item in res)
                    Console.WriteLine(item.ToString());
        }

        public void SearchBookByName()
        {
            Console.WriteLine("Enter searching book name:");
            string? str = Console.ReadLine();
            var res = from book in books
                      where book.bookTitle == str
                      select book;
            if (res == null)
                Console.WriteLine("No results");
            else
                foreach (var item in res)
                    Console.WriteLine(item.ToString());
        }

        public void ShowAll()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }

        public void ShowByNumber()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Book number:\t{books.Count}\t|\tAuthor:\t{authorName}\t|" +
                   $"\tTitle:\t{bookTitle}\t|\tGenre:\t{genre}\t|\tYear:\t{yearOfCreation}\n";
        }

        
    }
}
