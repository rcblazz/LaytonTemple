using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaytonTemple.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LaytonTemple.Pages
{

    public class FormModel : PageModel
    {
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public void Post(int timeId)
        {
        }
    }
}
