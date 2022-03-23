using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaytonTemple.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LaytonTemple.Pages
{
    public class TimeCalendarModel : PageModel
    {
        private readonly ILogger<TimeCalendarModel> _logger;

        private DatetimeDBcontext blahContext { get; set; }

        public TimeCalendarModel(ILogger<TimeCalendarModel> logger, DatetimeDBcontext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";

        }

        public IActionResult OnPost(Times time)
        {
            blahContext.Add(time);
            blahContext.SaveChanges();
            return RedirectToPage("Form");
        }
    }
}
