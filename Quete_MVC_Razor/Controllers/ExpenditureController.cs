using Microsoft.AspNetCore.Mvc;
using Quete_MVC_Razor.Models;

namespace Quete_MVC_Razor.Controllers
{
    public class ExpenditureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            List<Expenditure> expenditureList = new List<Expenditure>()
            {
                new Expenditure()
                {
                    Id = 1,
                    Name = "Article 1",
                    Date = DateTime.Now,
                    Price = 1
                },
                   new Expenditure()
                {
                    Id = 2,
                    Name = "Article 2",
                    Date = DateTime.Now,
                    Price = 2
                },
                      new Expenditure()
                {
                    Id = 3,
                    Name = "Article 3",
                    Date = DateTime.Now,
                    Price = 3
                }
            };

            return View(expenditureList);
        }
    }
}
