using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesSong.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorPagesSong.Pages.Songs
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesSong.Models.SongContext _context;

        public IndexModel(RazorPagesSong.Models.SongContext context)
        {
            _context = context;
        }

        public IList<Song> Song { get; set; }
        public SelectList Albums;
        public string SongAlbum { get; set; }

        /*
        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
        */

        // Search for a movie by title
        public async Task OnGetAsync(string songAlbum, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Song
                                            orderby m.Album
                                            select m.Album;

            var songs = from m in _context.Song
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                songs = songs.Where(s => s.Title.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(songAlbum))
            {
                songs = songs.Where(x => x.Album == songAlbum);
            }
            Albums = new SelectList(await genreQuery.Distinct().ToListAsync());

            // Return the movie with the specified title, or 
            // all movies in the database if no title was specified
            Song = await songs.ToListAsync();
        }


    }
}
