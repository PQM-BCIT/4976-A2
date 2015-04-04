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
    [Authorize(Roles = "Administrator")]
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {

            List<string> lUsers;
            List<string> uUsers;

            // Display locked users
            using (var context = new ApplicationDbContext())
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);

                lUsers = (from u in userManager.Users
                          where u.LockoutEndDateUtc > DateTime.Now
                          select u.UserName).ToList();
            }

            // Display unlocked users
            using (var context = new ApplicationDbContext())
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);

                uUsers = (from u in userManager.Users
                          where u.LockoutEndDateUtc < DateTime.Now || u.LockoutEndDateUtc == null
                          select u.UserName).ToList();
            }

            ViewBag.Locked = lUsers;
            ViewBag.Unlocked = uUsers;

            return View();
        }

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