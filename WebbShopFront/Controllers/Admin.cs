using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebbShopFrontInlamning.Helpers;
using WebbShopFrontInlamning.Views;
using WebbShopInlamningsUppgift;

namespace WebbShopFrontInlamning.Controllers
{
    class Admin
    {
        private int userId;
        
        public int Run()
        {
            AdminView.StartPage();
            userId = new Login().Run();
            if(userId == 0)
            {
                return 0;
            }

            var result = CheckAdmin(userId);
            if (!result)
            {
                AdminView.VerifyAdminFailed();
                return 0;
            }

            bool keepGoing = true;
            while (keepGoing)
            {
                AdminView.AdminPage();
                var input = InputHelper.ParseInput();

                switch (input)
                {
                    case 1:
                        AddBook(userId);
                        break;
                    case 2:
                        SetAmount(userId);
                        break;
                    case 3:
                        ViewAllUsers(userId);
                        break;
                    case 4:
                        FindUser(userId);
                        break;
                    case 5:;
                        UpdateBook(userId);
                        break;
                    case 6:
                        DeleteBook(userId);
                        break;
                    case 7:
                        AddCategory(userId);
                        break;
                    case 8:
                        AddBookToCategory(userId);
                        break;
                    case 9:
                        UpdateCategory(userId);
                        break;
                    case 10:
                        DeleteCategory(userId);
                        break;
                    case 11:
                        AddUser(userId);
                        break;
                    case 12:
                        ViewAllSoldItems(userId);
                        break;
                    case 13:
                        ViewTotalIncome(userId);
                        break;
                    case 14:
                        ViewBestCustomer(userId);
                        break;
                    case 15:
                        PromoteUser(userId);
                        break;
                    case 16:
                        DemoteUser(userId);
                        break;
                    case 17:
                        ActivateUser(userId);
                        break;
                    case 18:
                        InactivateUser(userId);
                        break;
                    case 19:
                        keepGoing = false;
                        break;
                    default:
                        MessageViews.DisplayNonAvailableMessage();
                        break;
                }
            }
            return userId;
        }

        public bool CheckAdmin(int userId)
        {
            WebbShopAPI api = new WebbShopAPI();
            //Checking random adminfunctionality, if the return value is larger than 0 the userId is valid.
            var list = api.ListUsers(userId);
            if(list.Count > 0)
            {
                return true;
            }
            return false; 
        }

        public void AddBook(int adminId)
        {
            AdminView.AddBookPage();
            string title = Console.ReadLine();
            string author = Console.ReadLine();
            int price = InputHelper.ParseInput();
            int amount = InputHelper.ParseInput();

            if(title != "" && author != "" && price != 0 && amount != 0)
            {
                WebbShopAPI api = new WebbShopAPI();
                bool result = api.AddBook(adminId, title, author, price, amount);
                if (result)
                {
                    MessageViews.DisplaySuccessMessage();
                    return;
                }
            }
            MessageViews.DisplayErrorMessage();
        }

        public void AddBookToCategory(int adminId)
        {
            new Book().FindAllAvailableBooks();
            MessageViews.DisplaySelectMessage();
            MessageViews.DisplayReturnMessage();

            var bookId = InputHelper.ParseInput();
            if(bookId == 0)
            {
                return;
            }

            new Book().ViewAllCategories();
            MessageViews.DisplaySelectMessage();
            MessageViews.DisplayReturnMessage();

            var categoryId = InputHelper.ParseInput();
            if(categoryId == 0)
            {
                return;
            }

            WebbShopAPI api = new WebbShopAPI();
            var result = api.AddBookToCategory(adminId, bookId, categoryId);
            if (result)
            {
                MessageViews.DisplaySuccessMessage();
                return;
            }
            MessageViews.DisplayErrorMessage();
        }

        public void AddCategory(int adminId)
        {
            AdminView.AddCategoryPage();
            var genere = Console.ReadLine();
            if(genere != "")
            {
                WebbShopAPI api = new WebbShopAPI();
                var result = api.AddCategory(adminId, genere);
                if (result)
                {
                    MessageViews.DisplaySuccessMessage();
                    return;
                }
            }
            MessageViews.DisplayErrorMessage();
        }

        public void AddUser(int adminId)
        {
           ManageAccountViews.AddAccount();
            var userName = Console.ReadLine();
            var password = Console.ReadLine();
            if(userName != "")
            {
                WebbShopAPI api = new WebbShopAPI();
                var result = api.AddUser(adminId, userName, password);
                if (result)
                {
                    MessageViews.DisplaySuccessMessage();
                    return;
                }
            }
            MessageViews.DisplayErrorMessage();
        }

        public void ActivateUser(int adminId)
        {
            WebbShopAPI api = new WebbShopAPI();
            var listOfUsers = api.ListUsers(adminId);
            if (listOfUsers != null)
            {
                listOfUsers.OrderBy(u => u.ID);
                AdminView.DisplayUsers(listOfUsers);
            }
            MessageViews.DisplaySelectMessage();
            MessageViews.DisplayReturnMessage();
            var userId = InputHelper.ParseInput();
            if (userId == 0)
            {
                return;
            }

            bool result = api.ActivateUser(adminId, userId);
            if (result)
            {
                MessageViews.DisplaySuccessMessage();
                return;
            }
            MessageViews.DisplayErrorMessage();
        }

        public void DemoteUser(int adminId)
        {
            WebbShopAPI api = new WebbShopAPI();
            var listOfUsers = api.ListUsers(adminId);
            if (listOfUsers != null)
            {
                listOfUsers.OrderBy(u => u.ID);
                AdminView.DisplayUsers(listOfUsers);
            }
            MessageViews.DisplaySelectMessage();
            MessageViews.DisplayReturnMessage();
            var userId = InputHelper.ParseInput();
            if (userId == 0)
            {
                return;
            }

            bool result = api.Demote(adminId, userId);
            if (result)
            {
                MessageViews.DisplaySuccessMessage();
                return;
            }
            MessageViews.DisplayErrorMessage();
        }

        public void InactivateUser(int adminId)
        {
            WebbShopAPI api = new WebbShopAPI();
            var listOfUsers = api.ListUsers(adminId);
            if (listOfUsers != null)
            {
                listOfUsers.OrderBy(u => u.ID);
                AdminView.DisplayUsers(listOfUsers);
            }
            MessageViews.DisplaySelectMessage();
            MessageViews.DisplayReturnMessage();
            var userId = InputHelper.ParseInput();
            if (userId == 0)
            {
                return;
            }

            bool result = api.InactivateUser(adminId, userId);
            if (result)
            {
                MessageViews.DisplaySuccessMessage();
                return;
            }
            MessageViews.DisplayErrorMessage();
        }

        public void PromoteUser(int adminId)
        {
            WebbShopAPI api = new WebbShopAPI();
            var listOfUsers = api.ListUsers(adminId);
            if(listOfUsers != null)
            {
                listOfUsers.OrderBy(u => u.ID);
                AdminView.DisplayUsers(listOfUsers);
            }
            MessageViews.DisplaySelectMessage();
            MessageViews.DisplayReturnMessage();
            var userId = InputHelper.ParseInput();
            if(userId == 0)
            {
                return;
            }

            bool result = api.Promote(adminId, userId);
            if (result)
            {
                MessageViews.DisplaySuccessMessage();
                return;
            }
            MessageViews.DisplayErrorMessage();
        }

        public void SetAmount(int adminId)
        {
            new Book().FindAllAvailableBooks();
            AdminView.SetAmountPage();
            MessageViews.DisplayReturnMessage();

            int bookId = InputHelper.ParseInput();
            int newAmount = InputHelper.ParseInput();
            if(bookId == 0)
            {
                return;
            }

            WebbShopAPI api = new WebbShopAPI();
            bool result = api.SetAmount(adminId, bookId, newAmount);
            if (result)
            {
                MessageViews.DisplaySuccessMessage();
                return;
            }

            MessageViews.DisplayErrorMessage();
        }

        public void ViewAllUsers(int adminId)
        {
            WebbShopAPI api = new WebbShopAPI();
            var listOfUsers = api.ListUsers(adminId);
            if(listOfUsers != null)
            {
                listOfUsers.OrderBy(u => u.ID);
                AdminView.DisplayUsers(listOfUsers);
                return;
            }
            MessageViews.DisplayErrorMessage();
        }

        public void ViewAllSoldItems(int adminId)
        {
            WebbShopAPI api = new WebbShopAPI();
            var listOfSoldItems = api.SoldItems(adminId);
            if(listOfSoldItems != null)
            {
                AdminView.DisplaySoldItems(listOfSoldItems);
                return;
            }
            MessageViews.DisplayErrorMessage();
        }

        public void ViewBestCustomer(int adminId)
        {
            WebbShopAPI api = new WebbShopAPI();
            var customerId = api.BestCustomer(adminId);
            if(customerId != 0)
            {
                AdminView.DisplayBestCustomer(customerId);
                return;
            }
            MessageViews.DisplayErrorMessage();
        }

        public void ViewTotalIncome(int adminId)
        {
            WebbShopAPI api = new WebbShopAPI();
            var totalIncome = api.MoneyEarned(adminId);
            if(totalIncome != 0)
            {
                AdminView.DisplayMoneyEarned(totalIncome);
                return;
            }
            MessageViews.DisplayErrorMessage();
        }

        public void FindUser(int adminId)
        {
            AdminView.SearchPage();
            var keyword = Console.ReadLine();
            if(keyword != "")
            {
                WebbShopAPI api = new WebbShopAPI();
                var listOfUsers = api.FindUser(adminId, keyword);
                if(listOfUsers != null)
                {
                    listOfUsers.OrderBy(u => u.ID);
                    AdminView.DisplayUsers(listOfUsers);
                    return;
                }
            }
            MessageViews.DisplayErrorMessage();
        }

        public void UpdateBook(int adminId)
        {
            new Book().FindAllAvailableBooks();
            MessageViews.DisplaySelectMessage();
            MessageViews.DisplayReturnMessage();
            var bookId = InputHelper.ParseInput();
            if(bookId == 0)
            {
                return;
            }

            AdminView.UpdateBookPage();
            string title = Console.ReadLine();
            string author = Console.ReadLine();
            int price = InputHelper.ParseInput();
            if(title != "" && author != "" && price != 0)
            {
                WebbShopAPI api = new WebbShopAPI();
                bool result = api.UpdateBook(adminId, bookId, title, author, price);
                if (result)
                {
                    MessageViews.DisplaySuccessMessage();
                    return;
                }
            }
            MessageViews.DisplayErrorMessage();
        }

        public void UpdateCategory(int adminId)
        {
            new Book().ViewAllCategories();
            MessageViews.DisplaySelectMessage();
            MessageViews.DisplayReturnMessage();
            var categoryId = InputHelper.ParseInput();
            if(categoryId == 0)
            {
                return;
            }

            AdminView.UpdateCategoryPage();
            var genere = Console.ReadLine();
            if(genere != "")
            {
                WebbShopAPI api = new WebbShopAPI();
                var result = api.UpdateCategory(adminId, categoryId, genere);
                if (result)
                {
                    MessageViews.DisplaySuccessMessage();
                    return;
                }
            }
            MessageViews.DisplayErrorMessage();
        }

        public void DeleteBook(int adminId)
        {
            new Book().FindAllAvailableBooks();
            MessageViews.DisplaySelectMessage();
            MessageViews.DisplayReturnMessage();

            var bookId = InputHelper.ParseInput();
            if(bookId == 0)
            {
                return;
            }

            WebbShopAPI api = new WebbShopAPI();
            bool result = api.DeleteBook(adminId, bookId);
            if (result)
            {
                MessageViews.DisplaySuccessMessage();
                return;
            }
            MessageViews.DisplayErrorMessage();
        }

        public void DeleteCategory(int adminId)
        {
            new Book().ViewAllCategories();
            MessageViews.DisplaySelectMessage();
            MessageViews.DisplayReturnMessage();
            var categoryId = InputHelper.ParseInput();
            if (categoryId == 0)
            {
                return;
            }

            WebbShopAPI api = new WebbShopAPI();
            var result = api.DeleteCategory(adminId, categoryId);
            if (result)
            {
                MessageViews.DisplaySuccessMessage();
                return;
            }
            MessageViews.DisplayErrorMessage();
        }
    }
}
