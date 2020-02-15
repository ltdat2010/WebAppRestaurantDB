using AutoMapper;
using System.Web.Mvc;
using WebAppRestaurantDB.Models;
using WebAppRestaurantDB.Repositories;
using WebAppRestaurantDB.ViewModels;

namespace WebAppRestaurantDB.Controllers
{
    public class UserController : Controller
    {
        private UsersViewModel _userViewModel = new UsersViewModel();
        private UserRepository _userRepository = new UserRepository();

        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login(string userName)
        {
            return View("~/Home/Index");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UsersViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = new User();
                //Mapper
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<UsersViewModel, User>();
                });

                IMapper mapper = config.CreateMapper();
                //below line is mapping b/w DB and entity
                user = mapper.Map<UsersViewModel, User>(userViewModel);
                _userRepository.RegisterUser(user);
                RedirectToAction("Index");
            }
            return View();
        }
    }
}