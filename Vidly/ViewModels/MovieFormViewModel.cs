using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public MovieFormViewModel(Movie movie = null)
        {
            if (movie != null)
            {
                ID = movie.ID;
                Name = movie.Name;
                GenreId = movie.GenreId;
                ReleaseDate = movie.ReleaseDate;
                NumberInStock = movie.NumberInStock;
            }
        }

        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Range(1, 50)]
        [Display(Name = "Number in Stock")]
        public int? NumberInStock { get; set; }

        public IEnumerable<Genre> Genres { get; set; }
    }
}