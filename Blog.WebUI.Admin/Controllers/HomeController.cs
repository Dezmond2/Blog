using Blog.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.WebUI.Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepository;
        public HomeController()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["BlogEntities"].ConnectionString;
            this._userRepository = new EFUserRepository(connectionString);
        }
        //
        // GET: Home
        public ActionResult Index()
        {
            var users = this._userRepository.GetUsers();
            ViewBag.Users = users;
            return View();
        }
        [HttpGet]
        public ActionResult UpdateUser(int Id, bool? IsEnable, bool? IsAdmin)
        {
            this._userRepository.UpdateUser(Id, IsEnable, IsAdmin);
            var users = this._userRepository.GetUsers();
            ViewBag.Users = users;
            return View("Index");
        }
    }
}