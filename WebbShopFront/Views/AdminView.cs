using System;
using System.Collections.Generic;
using System.Text;
using WebbShopInlamningsUppgift.Models;

namespace WebbShopFrontInlamning.Views
{
    class AdminView
    {
        public static void StartPage()
        {
            Console.WriteLine("You have to be logged in to proceed.");
        }

        public static void AdminPage()
        {
            Console.WriteLine("Admin page");
            Console.WriteLine();
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Set Amount");
            Console.WriteLine("3. View all users");
            Console.WriteLine("4. Find user");
            Console.WriteLine("5. Update book");
            Console.WriteLine("6. Delete book");
            Console.WriteLine("7. Add category");
            Console.WriteLine("8. Add a book to category");
            Console.WriteLine("9. Update category");
            Console.WriteLine("10. Delete category");
            Console.WriteLine("11. Add a new user");
            Console.WriteLine("12. View all sold items");
            Console.WriteLine("13. View total income");
            Console.WriteLine("14. View best customer");
            Console.WriteLine("15. Promote user");
            Console.WriteLine("16. Demote user");
            Console.WriteLine("17. Activate user");
            Console.WriteLine("18. Inactivate user");
            Console.WriteLine("19. Return to main meny");

        }

        public static void VerifyAdminFailed()
        {
            Console.WriteLine("You're not authorized.");
        }

        public static void AddBookPage()
        {
            Console.WriteLine();
            Console.WriteLine("Add book");
            Console.WriteLine();
            Console.WriteLine("Please fill in the following");
            Console.WriteLine("1. Title");
            Console.WriteLine("2. Author");
            Console.WriteLine("3. Price");
            Console.WriteLine("4. Amount");
        }

        public static void AddCategoryPage()
        {
            Console.WriteLine();
            Console.WriteLine("Add category");
            Console.WriteLine();
            Console.WriteLine("Please fill in the following");
            Console.WriteLine("1. Genere");
        }

        public static void UpdateBookPage()
        {
            Console.WriteLine();
            Console.WriteLine("Update book");
            Console.WriteLine();
            Console.WriteLine("Please fill in the following");
            Console.WriteLine("1. Title");
            Console.WriteLine("2. Author");
            Console.WriteLine("3. Price");
        }

        public static void UpdateCategoryPage()
        {
            Console.WriteLine();
            Console.WriteLine("Please fill in the following");
            Console.WriteLine("1. genere");
        }
        

        public static void SetAmountPage()
        {
            Console.WriteLine();
            Console.WriteLine("Set amount");
            Console.WriteLine();
            Console.WriteLine("Please fill in the following ");
            Console.WriteLine("1. Book number: ");
            Console.WriteLine("2. New amount: ");
        }

        public static void SearchPage()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter search word: ");
        }

        public static void DisplayBestCustomer(int customerId)
        {
            Console.WriteLine();
            Console.WriteLine($"Best customer with the most bought books, has ID: {customerId}");
        }

        public static void DisplayMoneyEarned(int totalIncome)
        {
            Console.WriteLine();
            Console.WriteLine($"Total income: {totalIncome}");
        }

        public static void DisplayUsers(List<Users> listOfUsers)
        {
            Console.WriteLine();
            Console.WriteLine("Result for users: ");
            foreach(var user in listOfUsers)
            {
                Console.WriteLine($"{user.ID}.{user.Name}");
            }
        }

        public static void DisplaySoldItems(List<SoldBooks> listOfSoldItems)
        {
            Console.WriteLine("Search result for books: ");
            foreach (var book in listOfSoldItems)
            {
                Console.WriteLine($"{book.ID}.{book.Title} - By: {book.Author}\nAmount: {book.Amount} Purchase date: {book.PurchaseDate}");
            }
        }

    }
}
