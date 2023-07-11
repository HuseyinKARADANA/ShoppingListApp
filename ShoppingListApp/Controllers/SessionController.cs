using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingListApp.ViewModels;
using System.Data.SqlClient;
namespace ShoppingListApp.Mapping
{
    public class SessionController : Controller
    {
        ViewModelMapping _mapper;
    
      
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserViewModel user)
        {
           //   UserViewModel users=_mapper.Map<UserViewModel>(user); 
            return View();
        }

        
    }
}
