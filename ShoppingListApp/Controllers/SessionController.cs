using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingListApp.ViewModels;
using ShoppingListApp.Models; // Eklediğimiz User modeli için gerekli using ifadesi

namespace ShoppingListApp.Mapping
{
    public class SessionController : Controller
    {
        private readonly IMapper _mapper;
        private readonly DbContext _dbContext;

        public SessionController(DbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                var newUser = _mapper.Map<User>(user);

                
                _dbContext.Set<User>().Add(newUser);
                _dbContext.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View(user);
        }
    }
}
