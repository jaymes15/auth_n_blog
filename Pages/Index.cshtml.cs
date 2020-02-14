using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using loggingnblog.Data;
using loggingnblogDataLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace loggingnblog.Pages
{
    public class IndexModel : PageModel
    {
        /*private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }*/
        private readonly ApplicationDbContext _db;

        //[TempData]
        //public string Message { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;

        }
        public IList<Article> Articles { get; private set; }



        public async Task OnGetAsync()
        {
           Articles = await _db.Articles.AsNoTracking().ToListAsync();
        }
    }
}
