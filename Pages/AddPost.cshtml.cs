using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using loggingnblog.Data;
using loggingnblogDataLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace loggingnblog
{
    public class AddPostModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public AddPostModel(ApplicationDbContext db)
        {
            _db = db;

        }

        [BindProperty]
        public Article Article { get; set; }

        //[TempData]
        //public string Message { get; set; }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            _db.Articles.Add(Article);
            await _db.SaveChangesAsync();
            //Message = Address.City + "Added";
            return RedirectToPage("/Index");
        }
    }
}