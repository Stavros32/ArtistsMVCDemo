using ArtistsMVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArtistsMVCDemo.ViewModels
{
    public class SongFormViewModel
    {
        public List<Album> Albums { get; set; }
        public Song Song { get; set; }
    }
}