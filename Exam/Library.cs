using System;



namespace LibraryManagement
{
    public class Library 
    {
        private List<Book> bookList = new List<Book>();


        public void AddBook(Book book)
        {
            bookList.Add(book);
        }

        public void RemoveBook(Book book)
        {
            bookList.Remove(book);
        }

        public List<Book> GetBooks()
        {
            Console.WriteLine("Books in the library:");
            return bookList;
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Books in the library:");
            foreach (var book in bookList)
            {
                Console.WriteLine($"{book.title} by {book.author}: {book.Status}");
            }
        }

        
    }
}
