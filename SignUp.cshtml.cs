using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstproject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace firstproject.Pages.Forms
{
    public class SignUpModel : PageModel
    {
        [BindProperty]
        public PersonModel Person { get; set; }
        public void OnGet()
        {
        }
        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return Redirect("/Index");

        
        
            //string email = Request.Form["txtemail"];
            //string password = Request.Form["txtpassword"];
            //string firstname = Request.Form["txtfirstname"];
            //string lastname = Request.Form["txtlastname"];
            
        }
    }
}
