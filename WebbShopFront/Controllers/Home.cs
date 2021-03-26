using System;
using System.Collections.Generic;
using System.Text;
using WebbShopFrontInlamning.Helpers;
using WebbShopFrontInlamning.Views;
using WebbShopInlamningsUppgift.Database;

namespace WebbShopFrontInlamning.Controllers
{
    class Home
    {
        private int userId;

        public void Run()
        {
            Seeder.Seed();
            bool keepGoing = true;

            while (keepGoing)
            {
                HomeView.MainMeny();
                var input = InputHelper.ParseInput();

                switch (input)
                {
                    case 1:
                        userId = new Login().Run();
                        break;
                    case 2:
                        new User().RegisterAccount();
                        break;
                    case 3:
                        new Book().Run();
                        break;
                    case 4:
                        break;
                    case 5:
                        userId = new Admin().Run();
                        break;
                    case 6:
                        new Logout().Run(userId);
                        keepGoing = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
