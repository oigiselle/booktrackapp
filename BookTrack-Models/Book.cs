﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace BookTrack_Models
{
    public class Book
    {
        [Key]
        public string ISBN { get; set; }

        [Required]
        public string Title { get; set; }
       

        [Required]
        public string Author { get; set; }

        public Category CategoryId { get; set; }

    }
}
