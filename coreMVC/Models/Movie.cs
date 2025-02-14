﻿using System.ComponentModel.DataAnnotations;

namespace coreMVC.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required,MaxLength(250)]
        public string Title { get; set; }
        public int Year { get; set; }
        public double Rate { get; set; }
        [Required,MaxLength(2500)]
        public string Storyline { get; set; }
        [Required]
        public byte[] Poster { get; set; }

        public byte GenreID { get; set; }
        public Genre Genre { get; set; }
    }
}
