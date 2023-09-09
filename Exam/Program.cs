using System;

namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Library library = new Library();
            Book book1 = new Book("1984", "George Orwell", "1234567899876", BookStatus.Available);
            Book book2 = new Book("The Outsider", "Robert Hunt", "1234567899875", BookStatus.CheckedOut);
   

            library.AddBook(new Book("A Tale of Two Cities", "Charles Dickens", "1234567899873", BookStatus.Lost));
            library.AddBook(new Book("The Picture of Dorian Gray", "Oscar Wilde", "1234567899874", BookStatus.Available));
            library.AddBook( new Book("To Kill a Mockingbird", "Harper Lee", "1234567899872", BookStatus.CheckedOut));
            library.DisplayBooks();

            book1.CheckOut();
            book1.Return();

            Console.WriteLine("--------------------------------");

            book1.DisplayBook();

            Console.WriteLine("--------------------------------");

            Patron patron = new Patron();


        }
    }
}