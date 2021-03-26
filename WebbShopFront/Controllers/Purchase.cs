using System;
using System.Collections.Generic;
using System.Text;
using WebbShopFrontInlamning.Helpers;
using WebbShopFrontInlamning.Views;
using WebbShopInlamningsUppgift;

namespace WebbShopFrontInlamning.Controllers
{
    class Purchase
    {
        private int id;

        public void Run(int userId)
        {
            id = userId;

            PurchaseViews.StartPage();
            new Book().FindAllAvailableBooks();
            PurchaseViews.SelectItem();

            var input = InputHelper.ParseInput();
            if(input == 0)
            {
                return;
            }

            switch (input)
            {
                case 1:
                    ViewDetails(input);
                    break;
                case 2:
                    PurchaseBook(id, input);
                    break;
            }
        }

        public void ViewDetails(int bookId)
        {
            var bookDetails = new Book().GetBook(bookId);
            if(bookDetails != string.Empty)
            {
                BookViews.DisplayDetails(bookDetails);
                return;
            }
            MessageViews.DisplayErrorMessage();
        }
        public void PurchaseBook(int userId, int bookId)
        {
            WebbShopAPI api = new WebbShopAPI();
            if(userId != 0 && bookId != 0)
            {
                var result = api.BuyBook(userId, bookId);
                if (result)
                {
                    MessageViews.DisplaySuccessMessage();
                    return;
                }
                MessageViews.DisplayErrorMessage();
            }
        }
    }
}
