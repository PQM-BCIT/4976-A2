using GoodSamaritan.Models;
using GoodSamaritan.Models.ClientEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Controllers
{
    //[Authorize(Roles="Administrator, Worker, Reporter")]
    public class ReportController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();
        private List<string> months = new List<string>() { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };


        // GET: Report
        public ActionResult Index()
        {
            ViewBag.MonthId = new SelectList(months);
            ViewBag.FiscalYearId = new SelectList(db.FiscalYearModel, "FiscalYearId", "FiscalYear");
            return View();
        }

        [HttpPost]
        public ActionResult ViewStats(FormCollection collection)
        {
            var month = MonthHelper(collection[0]);
            var year = Convert.ToInt32(collection[1]);
            var reports = (from q in db.ClientModel
                           where q.Month == month
                           && q.FiscalYearId == year
                           select q);

            ViewBag.StatusOpen = (from q in db.ClientModel
                                  where q.Month == month
                                  && q.FiscalYearId == year
                                  && q.StatusOfFile.StatusOfFile == "Open"
                                  select q).Count();
            ViewBag.StatusClosed = (from q in db.ClientModel
                                    where q.Month == month
                                    && q.FiscalYearId == year
                                    && q.StatusOfFile.StatusOfFile == "Closed"
                                    select q).Count();
            ViewBag.StatusReopened = (from q in db.ClientModel
                                      where q.Month == month
                                      && q.FiscalYearId == year
                                      && q.StatusOfFile.StatusOfFile == "Reopened"
                                      select q).Count();
            ViewBag.ProgramCrisis = (from q in db.ClientModel
                                     where q.Month == month
                                     && q.FiscalYearId == year
                                     && q.Program.Program == "Crisis"
                                     select q).Count();
            ViewBag.ProgramCourt = (from q in db.ClientModel
                                    where q.Month == month
                                    && q.FiscalYearId == year
                                    && q.Program.Program == "Court"
                                    select q).Count();
            ViewBag.ProgramSmart = (from q in db.ClientModel
                                    where q.Month == month
                                    && q.FiscalYearId == year
                                    && q.Program.Program == "SMART"
                                    select q).Count();
            ViewBag.ProgramDvu = (from q in db.ClientModel
                                  where q.Month == month
                                  && q.FiscalYearId == year
                                  && q.Program.Program == "DVU"
                                  select q).Count();
            ViewBag.ProgramMcfd = (from q in db.ClientModel
                                   where q.Month == month
                                   && q.FiscalYearId == year
                                   && q.Program.Program == "MCFD"
                                   select q).Count();
            ViewBag.GenderMale = (from q in db.ClientModel
                                  where q.Month == month
                                  && q.FiscalYearId == year
                                  && q.Gender == "M"
                                  select q).Count(); ;
            ViewBag.GenderFemale = (from q in db.ClientModel
                                    where q.Month == month
                                    && q.FiscalYearId == year
                                    && q.Gender == "F"
                                    select q).Count();
            ViewBag.GenderTrans = (from q in db.ClientModel
                                   where q.Month == month
                                   && q.FiscalYearId == year
                                   && q.Gender == "Trans"
                                   select q).Count();
            ViewBag.Age24To65 = (from q in db.ClientModel
                                 where q.Month == month
                                 && q.FiscalYearId == year
                                 && q.Age.Age == "Adult >24 <65"
                                 select q).Count();
            ViewBag.Age18To25 = (from q in db.ClientModel
                                 where q.Month == month
                                 && q.FiscalYearId == year
                                 && q.Age.Age == "Youth >12 <19"
                                 select q).Count();
            ViewBag.Age12To19 = (from q in db.ClientModel
                                 where q.Month == month
                                 && q.FiscalYearId == year
                                 && q.Age.Age == "Youth >18 <25"
                                 select q).Count();
            ViewBag.AgeChild = (from q in db.ClientModel
                                where q.Month == month
                                && q.FiscalYearId == year
                                && q.Age.Age == "Child <13"
                                select q).Count();
            ViewBag.AgeSenior = (from q in db.ClientModel
                                 where q.Month == month
                                 && q.FiscalYearId == year
                                 && q.Age.Age == "Senior >64"
                                 select q).Count();
            return View();
        }

        private int MonthHelper(string month)
        {
            var idx = months.IndexOf(month);
            return idx + 1;
        }

    }
}
