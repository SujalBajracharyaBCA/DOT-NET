using System;

using System.Collections.Generic;
using System.Linq;

namespace Lab5
{
    using System;

    namespace BookLibrary
    {
        public class Book
        {
            // Properties
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string ISBN { get; set; }

            // Constructor
            public Book(string title, string author, string publisher, DateTime releaseDate, string isbn)
            {
                Title = title;
                Author = author;
                Publisher = publisher;
                ReleaseDate = releaseDate;
                ISBN = isbn;
            }

            // Method to display book information
            public void DisplayInfo()
            {
                Console.WriteLine("Book Information:");
                Console.WriteLine($"Title: {Title}");
                Console.WriteLine($"Author: {Author}");
                Console.WriteLine($"Publisher: {Publisher}");
                Console.WriteLine($"Release Date: {ReleaseDate.ToShortDateString()}");
                Console.WriteLine($"ISBN: {ISBN}");
                Console.WriteLine();
            }
        }
    }

    namespace BookLibrary
    {
        public class Library
        {
            // Properties
            public string Name { get; set; }
            public List<Book> Books { get; set; }

            // Constructor
            public Library(string name)
            {
                Name = name;
                Books = new List<Book>();
            }

            // Method to add a book to the library
            public void AddBook(Book book)
            {
                Books.Add(book);
                Console.WriteLine($"Book '{book.Title}' by {book.Author} added to the library.");
            }

            // Method to search for a book by author
            public List<Book> SearchByAuthor(string author)
            {
                return Books.Where(book => book.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            // Method to display information about a book by ISBN
            public void DisplayBookInfo(string isbn)
            {
                Book book = Books.FirstOrDefault(b => b.ISBN == isbn);
                if (book != null)
                {
                    book.DisplayInfo();
                }
                else
                {
                    Console.WriteLine($"Book with ISBN {isbn} not found.");
                }
            }

            // Method to delete a book from the library
            public void DeleteBook(string isbn)
            {
                Book bookToRemove = Books.FirstOrDefault(b => b.ISBN == isbn);
                if (bookToRemove != null)
                {
                    Books.Remove(bookToRemove);
                    Console.WriteLine($"Book '{bookToRemove.Title}' by {bookToRemove.Author} removed from the library.");
                }
                else
                {
                    Console.WriteLine($"Book with ISBN {isbn} not found.");
                }
            }
        }
    }


    namespace BookLibrary
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Create a library
                Library library = new Library("City Library");

                // Add books to the library
                library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "Scribner", new DateTime(1925, 4, 10), "9780743273565"));
                library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "J.B. Lippincott & Co.", new DateTime(1960, 7, 11), "9780061120084"));
                library.AddBook(new Book("1984", "George Orwell", "Secker & Warburg", new DateTime(1949, 6, 8), "9780451524935"));

                // Display information about a specific book
                Console.WriteLine("Displaying information about the book with ISBN 9780061120084:");
                library.DisplayBookInfo("9780061120084");

                // Search for books by author
                Console.WriteLine("Searching for books by George Orwell:");
                var booksByOrwell = library.SearchByAuthor("George Orwell");
                foreach (var book in booksByOrwell)
                {
                    book.DisplayInfo();
                }

                // Delete a book from the library
                Console.WriteLine("Deleting the book with ISBN 9780743273565:");
                library.DeleteBook("9780743273565");

                // Try to display the deleted book
                Console.WriteLine("Trying to display the deleted book with ISBN 9780743273565:");
                library.DisplayBookInfo("9780743273565");

                // Pause the console to view results
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }

}



