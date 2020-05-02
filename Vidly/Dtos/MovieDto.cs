using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public int GenreId { get; set; }
        public GenreDto Genre { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Range(1, 50)]
        public int NumberInStock { get; set; }
    }
}