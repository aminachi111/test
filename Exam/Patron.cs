
using System;

using System.Text.RegularExpressions;


namespace LibraryManagement
{
    public class Patron : Book
    {
        public string name { get; set; }
        public string surname { get; set;}

        public Patron(string title, string author, string isbn, BookStatus Status,string name, string surname, string email, string phoneNumber) : base(title, author, isbn, Status)
        {

            this.name = name;
            this.surname = surname;

        }



        private const string email = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        private const string phonenumber = @"^\d{10}$";

        public static bool ValidateEmail(string email)
        {
            return !string.IsNullOrWhiteSpace(email) && Regex.IsMatch(email, email);
        }

        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            return !string.IsNullOrWhiteSpace(phoneNumber) && Regex.IsMatch(phoneNumber, phonenumber);
        }

        public void DisplayPatron()
        {
            Console.WriteLine("About the patron:,\n" + 
                $"Name: {name},\n" + 
                $"Surname: {surname},\n" + 
                $"Email: {email},\n" + 
                $"Phone number: {phonenumber},\n" + 
                $"{DisplayBook}");
        }
    }

   
}
