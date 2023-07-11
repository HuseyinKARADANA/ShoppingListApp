using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingListApp.Models;
using ShoppingListApp.ViewModels;
using System.Data.SqlClient;
namespace ShoppingListApp.Mapping
{
    public class SessionController : Controller
    {
        private readonly  IMapper _mapper;
        AppDbContext _context;

        public SessionController(AppDbContext context,IMapper mapper)
        {
            _context= context;
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
            
            _context.Users.Add(_mapper.Map<User>(user));
            _context.SaveChanges();
            return View();
        }


    }
}