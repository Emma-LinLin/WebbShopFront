using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebbShopFrontInlamning.Helpers;
using WebbShopFrontInlamning.Views;
using WebbShopInlamningsUppgift;
using WebbShopInlamningsUppgift.Models;

namespace WebbShopFrontInlamning.Controllers
{
    class Book
    {
        private WebbShopAPI api = new WebbShopAPI();

        public void Run()
        {
            bool keepGoing = true;
            while(keepGoing)
            {
                BookViews.BookMeny();
                var input = InputHelper.ParseInput();

                switch(input)
                {
                    case 1:
                        ViewAllCategories();
                        break;
                    case 2:
                        SearchFunctionCategories();
                        break;
                    case 3:
                        SearchBooksByAuthor();
                        break;
                    case 4:
                        SearchBooksByTitle();
                        break;
                    case 5:
                        FindAllAvailableBooks();
                        break;
                    case 6:
                        keepGoing = false;
                        break;
                    default:
                        MessageViews.DisplayNonAvailableMessage();
                        break;
                }
            }
        }

        public List<Books> GetAllBooks()
        {
            List<Books> listOfBooks = new List<Books>();

            var listOfCategories = GetCategories();
            foreach(var category in listOfCategories)
            {
                listOfBooks.AddRange(GetAvailableBooks(category.ID));
            }

            return listOfBooks;
        }

        public List<BookCategory> GetCategories()
        {
            var listOfCategories = api.GetCategories().OrderBy(c => c.ID).ToList();
            if (listOfCategories != null)
            {
                return listOfCategories;
            }
            return new List<BookCategory>();
        }

        public List<BookCategory> GetCategories(string keyword)
        {
            var listOfCategories = api.GetCategories(keyword).OrderBy(c => c.ID).ToList();
            if (listOfCategories != null)
            {
                return listOfCategories;
            }
            return new List<BookCategory>();
        }

        public List<Books> GetBooksByCategory(int categoryId)
        {
            var listOfBooks = api.GetCategories(categoryId).OrderBy(b => b.ID).ToList();
            if (listOfBooks != null)
            {
                return listOfBooks;
            }
            return new List<Books>();
        }

        public List<Books> GetAvailableBooks(int categoryId)
        {
            var listOfBooks = api.GetAvailableBooks(categoryId).OrderBy(b => b.ID).ToList();
            if (listOfBooks != null)
            {
                return listOfBooks;
            }
            return new List<Books>();
        }

        public string GetBook(int bookId)
        {
            var details = api.GetBook(bookId);
            if(details != null)
            {
                return details;
            }
            return "";
        }

        public List<Books> GetBooks(string keyword)
        {
            var listOfBooks = api.GetBooks(keyword).OrderBy(b => b.ID).ToList();
            if (listOfBooks != null)
            {
                return listOfBooks;
            }
            return new List<Books>();
        }

        public List<Books> GetBooksByAuthor(string keyword)
        {
            var listOfBooks = api.GetAuthor(keyword).OrderBy(b => b.ID).ToList();
            if(listOfBooks != null)
            {
                return listOfBooks;
            }
            return new List<Books>();
        }

        public void ViewAllCategories()
        {
            var listOfCategories = GetCategories();
            if(listOfCategories.Count != 0)
            {
                BookViews.DisplayCategoryList(listOfCategories);
                return;
            }
            MessageViews.DisplayErrorMessage();
            return;
        }

        public void SearchFunctionCategories()
        {
            BookViews.SearchPage();
            var keyword = Console.ReadLine();
            if (keyword != "")
            {
                var listOfCategories = GetCategories(keyword);
                if (listOfCategories.Count != 0)
                {
                    BookViews.DisplayCategoryList(listOfCategories);
                    return;
                }
            }

            MessageViews.DisplayErrorMessage();
            return;
        }

        public void SearchBooksByAuthor()
        {
            BookViews.SearchPage();
            var keyword = Console.ReadLine();
            if (keyword != "")
            {
                var listOfBooks = GetBooksByAuthor(keyword);
                if (listOfBooks.Count != 0)
                {
                    BookViews.DisplayBookList(listOfBooks);
                    return;
                }
            }

            MessageViews.DisplayErrorMessage();
            return;
        }

        public void SearchBooksByTitle()
        {
            BookViews.SearchPage();
            var keyword = Console.ReadLine();
            if (keyword != "")
            {
                var listOfBooks = GetBooks(keyword);
                if (listOfBooks.Count != 0)
                {
                    BookViews.DisplayBookList(listOfBooks);
                    return;
                }
            }

            MessageViews.DisplayErrorMessage();
            return;
        }

        public void FindAllAvailableBooks()
        {
            var listOfBooks = GetAllBooks();
            if(listOfBooks.Count != 0)
            {
                BookViews.DisplayAvailableBooks(listOfBooks);
                return;
            }

            MessageViews.DisplayErrorMessage();
            return;
        }
    }
}
