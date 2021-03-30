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
        public void Run(int userId)
        {
            PurchaseViews.StartPage();
            new Book().FindAllAvailableBooks();
            MessageViews.DisplaySelectMessage();
            MessageViews.DisplayReturnMessage();

            var bookId = InputHelper.ParseInput();
            if(bookId == 0)
            {
                return;
            }

            PurchaseViews.DisplayPurchaseMeny();
            var input = InputHelper.ParseInput();
            switch (input)
            {
                case 1:
                    ViewDetails(input);
                    break;
                case 2:
                    PurchaseBook(userId, input);
                    break;
                default:
                    MessageViews.DisplayNonAvailableMessage();
                    break;
            }
        }

        public void ViewDetails(int bookId)
        {
            WebbShopAPI api = new WebbShopAPI();
            var bookDetails = api.GetBook(bookId);
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
