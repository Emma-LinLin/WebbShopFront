using System;
using System.Collections.Generic;
using System.Text;
using WebbShopInlamningsUppgift.Models;

namespace WebbShopFrontInlamning.Views
{
    class BookViews
    {
        public static void BookMeny()
        {
            Console.WriteLine("Browse books");
            Console.WriteLine();
            Console.WriteLine("1. View all categories");
            Console.WriteLine("2. Search category");
            Console.WriteLine("3. Search book by Author");
            Console.WriteLine("4. Search book by Title");
            Console.WriteLine("5. View all available books");
            Console.WriteLine("6. Return to main meny");
        }

        public static void DisplayBookList(List<Books> listOfBooks)
        {
            Console.WriteLine("Search result for books: ");
            foreach (var book in listOfBooks)
            {
                Console.WriteLine($"{book.ID}.{book.Title} - By: {book.Author}");
            }
        }

        public static void DisplayAvailableBooks(List<Books> listOfBooks)
        {
            Console.WriteLine("Result for available books: ");
            foreach (var book in listOfBooks)
            {
                Console.WriteLine($"{book.ID}.{book.Title} - By: {book.Author}\n Amount: {book.Amount}");
            }
        }

        public static void DisplayCategoryList(List<BookCategory> listOfCategories)
        {
            Console.WriteLine("Result for categories: ");
            foreach (var category in listOfCategories)
            {
                Console.WriteLine($"{category.ID}.{category.Genere}");
            }
        }

        public static void DisplayDetails(string details)
        {
            Console.WriteLine(details);
        }

        public static void SearchPage()
        {
            Console.WriteLine();
            Console.WriteLine("Enter search word here: ");
        }
    }
}
