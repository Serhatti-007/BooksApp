using Business.Abstracts;
using Business.Concrates;
using Microsoft.AspNetCore.Mvc;

namespace BooksApp.Controllers
{
    public class BookController : Controller
    {
        public IBookService BookService = new BookManager();



        public IActionResult Index()
        {



            return View();
        }

        public JsonResult GetAll()
        {
            return Json(BookService.GetList());
        }

    }
}
