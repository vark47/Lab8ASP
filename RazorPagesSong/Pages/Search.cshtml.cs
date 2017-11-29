using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesSong.Models;

namespace RazorPagesSong.Pages
{
    public class SearchModel : PageModel
    {
        private readonly SongContext _context;

        public SearchModel(SongContext context)
        {
            _context = context;
        }

        public SelectList Albums;
        public SelectList Rating;
        public SelectList Year;
        public string SongAlbum { get; set; }
        public string SongRating { get; set; }
        public string SongYear { get; set; }
        public IList<Song> Song { get; set; }

        public async Task OnGetAsync(string songAlbum, string searchString, int songRating, string songYear)
        {
            IQueryable<string> albumQuery = from m in _context.Song
                                            orderby m.Album
                                            select m.Album;

            IQueryable<int> ratingQuery = from m in _context.Song
                                          orderby m.Rating
                                          select m.Rating;

            IQueryable<DateTime> yearQuery = from m in _context.Song
                                             orderby m.ReleaseDate
                                             select m.ReleaseDate;


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

            if (songRating >= 1)
            {
                songs = songs.Where(x => x.Rating == songRating);
            }

            
            
          
            
            Albums = new SelectList(await albumQuery.Distinct().ToListAsync());
            Rating = new SelectList(await ratingQuery.Distinct().ToListAsync());
            Year = new SelectList(await yearQuery.Distinct().ToListAsync());
            Song = await songs.ToListAsync();
        }
    }
}
