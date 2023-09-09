using System;


namespace LibraryManagement
{
    class BookNotAvailableException : Exception
    {
        public BookNotAvailableException(string message) : base(message)
        {
            Console.WriteLine("The book does not exist");
        }
    }
}
