using System;


namespace LibraryManagement
{
    public enum BookStatus
    {
        Available, CheckedOut, Lost
    }
    public  class Book : DisplayBook, CheckingBooks
    {
        public string title { get; set; }
        public string author { get; set; }   
        public string isbn { get; set; }
        public BookStatus Status { get; set; }


        public Book(string title, string author, string isbn, BookStatus Status)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.Status = Status;
        }

        public void CheckOut()
        {
            try
            {
                if (Status == BookStatus.Available)
                {
                    Status = BookStatus.CheckedOut;
                    Console.WriteLine($"{title} has been checked out.");
                }
                else
                {
                    throw new BookNotAvailableException($"{title} is not available for checkout.");
                }
            }
            catch (BookNotAvailableException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }


        public void Return()
        {
            if (Status == BookStatus.CheckedOut)
            {
                Status = BookStatus.Available;
                Console.WriteLine($"{title} has been returned.");
            }
            else if (Status == BookStatus.Lost)
            {
                Console.WriteLine($"{title} is marked as lost and cannot be returned.");
            }
            else
            {
                Console.WriteLine($"{title} is already available in the library.");
            }
        }


        public  void DisplayBook()
        {
            Console.WriteLine("About the Book \n" +
                $"The book title: {title} \n" +
                $"ISBN: {isbn} \n" + 
                $"The author: {author} \n" +
                $"The status: {Status} \n");
             
        }
    }

}

