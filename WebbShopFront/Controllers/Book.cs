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

            var listOfCategories = api.GetCategories().ToList();
            if(listOfCategories != null)
            {
                foreach (var category in listOfCategories)
                {
                    listOfBooks.AddRange(api.GetAvailableBooks(category.ID).ToList());
                }
                return listOfBooks;
            }

            return new List<Books>();
        }

        public void ViewAllCategories()
        {
            var listOfCategories = api.GetCategories().ToList();
            if(listOfCategories != null)
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
                var listOfCategories = api.GetCategories(keyword).ToList();
                if (listOfCategories != null)
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
                var listOfBooks = api.GetAuthor(keyword).ToList();
                if (listOfBooks != null)
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
                var listOfBooks = api.GetBooks(keyword).ToList();
                if (listOfBooks != null)
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
                listOfBooks.OrderBy(b => b.ID);
                BookViews.DisplayAvailableBooks(listOfBooks);
                return;
            }

            MessageViews.DisplayErrorMessage();
            return;
        }

        
    }
}
