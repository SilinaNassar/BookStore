using BookStore.Models;
using BookStore.Models.DataLayer.Repositories;
using BookStore.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Diagnostics;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private Repository<Book> data { get; set; }


        public HomeController(BookStoreContext cxt)=>data=new Repository<Book>(cxt);
       
        
        public ViewResult Index()
        {
            //get one book at random
            var random = data.Get(new QueryOptions<Book>
            {

            });
            return View();
        }

       
    }
}