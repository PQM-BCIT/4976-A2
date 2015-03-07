using GoodSamaritan.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            
            List<string> users;
            using (var context = new ApplicationDbContext())
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);

                users = (from u in userManager.Users select u.UserName).ToList();
            }

            return View(users);
        }


        [Authorize(Roles = "Administrator")]
        public ActionResult UserLock(string userName)
        {
            using (var context = new ApplicationDbContext())
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var user = userManager.FindByName(userName);

                user.LockoutEnabled = true;

                DateTime dt = new DateTime(5000, 01, 01);
                DateTimeOffset dto = new DateTimeOffset(dt);
                userManager.SetLockoutEndDate(user.Id, dto);

                context.SaveChanges();
            }

            ViewBag.ResultMessage = "User locked succesfully !";

            return RedirectToAction("Index", "User");
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult UserUnlock(string userName)
        {
            using (var context = new ApplicationDbContext())
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var user = userManager.FindByName(userName);

                user.LockoutEnabled = true;

                DateTime dt = new DateTime(2000, 01, 01);
                DateTimeOffset dto = new DateTimeOffset(dt);
                userManager.SetLockoutEndDate(user.Id, dto);

                context.SaveChanges();
            }

            ViewBag.ResultMessage = "User unlocked succesfully !";

            return RedirectToAction("Index", "User");
        }
    }
}