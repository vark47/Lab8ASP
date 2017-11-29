using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesSong.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace RazorPagesSong.Pages.Songs
{
    public class CreateModel : PageModel
    {
        public string lastSong = "";
        public string LAST_SONG = "";
        public string lastSongDisplay = "";

        private readonly RazorPagesSong.Models.SongContext _context;

        public CreateModel(RazorPagesSong.Models.SongContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            lastSongDisplay = HttpContext.Session.GetString(LAST_SONG);
            return Page();
        }

        
        [BindProperty]
        public Song Song { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Song.Add(Song);
            await _context.SaveChangesAsync();
            HttpContext.Session.SetString(LAST_SONG, lastSong);
            return RedirectToPage("./Index");
        }
    }
}