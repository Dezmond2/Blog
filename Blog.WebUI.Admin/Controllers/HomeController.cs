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
        // GET: Home
        public ActionResult Index()
        {
            return Redirect("Users/Index");
        }
    }
}