using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LaytonTemple.Models;

//This controller handles getting information for certain pages depending on TimeIds and GroupIds. You can also edit and delete. That information is based on key criteria 


namespace LaytonTemple.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private DatetimeDBcontext blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, DatetimeDBcontext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        [HttpGet]

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(Times time)
        {
            blahContext.Add(time);
            blahContext.SaveChanges();
            return View("Index", time);
        }

        [HttpGet]

        public IActionResult TimeList ()
        {
            var timeslotss = blahContext.timeslots
                .Where(x => x.Available == true) //only show apointments that are available
                .ToList();

            return View(timeslotss);
        }

        public IActionResult Reservations()
        {
            var resList = blahContext.TourGroup.ToList();
            return View(resList);
        }

        [HttpGet]
        public IActionResult MakeReservation(string timeslot)
        {
            return View("MakeReservation", timeslot);
        }

        [HttpPost]
        public IActionResult MakeReservation(TourGroup group)
        {
            if (ModelState.IsValid)
            {
                var time = blahContext.timeslots.Single(x => x.Timeslot == group.Timeslot);
                time.Available = false;
                blahContext.timeslots.Update(time);
                blahContext.Add(group);
                blahContext.SaveChanges();
                return RedirectToAction("Reservations");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Edit(int groupID)
        {
            var group = blahContext.TourGroup.Single(x => x.GroupId == groupID);

            return View("MakeReservation", group);
        }

        [HttpPost]
        public IActionResult Edit(TourGroup group)
        {
            blahContext.TourGroup.Update(group);
            blahContext.SaveChanges();

            return RedirectToAction("Reservations");
        }

        [HttpGet]
        public IActionResult Delete(int groupid)
        {
            var group = blahContext.TourGroup.Single(x => x.GroupId == groupid);

            return View(group);
        }

        [HttpPost]
        public IActionResult Delete(TourGroup group)
        {
            var groupFull = blahContext.TourGroup.Single(x => x.GroupId == group.GroupId);
            var time = blahContext.timeslots.Single(x => x.Timeslot == groupFull.Timeslot);
            blahContext.TourGroup.Remove(groupFull);
            time.Available = true;
            blahContext.timeslots.Update(time);
            blahContext.SaveChanges();

            return RedirectToAction("Reservations");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
