using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppl1.Models;

namespace WebAppl1.Controllers
{
    public class InfoNumberController : ControllerBase
    {
        ApplicationContext db;
        public InfoNumberController(ApplicationContext context)
        {
            db = context;
        }

        //public async Task<IActionResult> Index()
        //{
        //    return View(await db.InfoNumber.ToListAsync());
        //}

       

        //[HttpPost]
        //public async Task<IActionResult> Create(User user)
        //{
        //    db.Users.Add(user);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}
    }
}