using ConcertJam.Models;
using System.Collections.Generic;

namespace ConcertJam.ViewModels
{
    public class ShowFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}