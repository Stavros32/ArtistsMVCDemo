using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArtistsMVCDemo.Models
{
    public class Song
    {
        public int ID { get; set; }

        [Required(ErrorMessage="Title is required")]
        public string Title { get; set; }

        public string Youtube { get; set; }

        [Display(Name ="Album")]
        public int AlbumId { get; set; }
        public Album Album { get; set; }
    }
}