﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CinemoApi.Models
{
    public class SliderMovie
    {
        [Key]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(100, ErrorMessage = "The field {0} can contain maximum {1} characters length")]
        [Display(Name = "Movie Name")]
        public string MovieName { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PlayingDate { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(100, ErrorMessage = "The field {0} can contain maximum {1} characters length")]
        [Display(Name = "Genre")]

        public string Genre { get; set; }

        [Display(Name = "Rating")]
        public double Rating { get; set; }

        [Display(Name = "Trailor URL")]
        public string TrailorLink { get; set; }


        [Display(Name = "Image")]
        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }

        [NotMapped]
        public HttpPostedFileBase LogoFile { get; set; }


    }
}