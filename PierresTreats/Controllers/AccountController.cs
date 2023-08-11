using Microsoft.AspNetCore.Identity;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using PierresTreats.Models;
using PierresTreats.ViewModels;

namespace PierresTreats.Controllers
{
    public class AccountController : Controller
    {
        private readonly PierresTreatsContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, PierresTreatsContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}