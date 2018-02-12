using System;
using System.Collections.Generic;
using vid.Models;

namespace vid.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Movie> Movies { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
