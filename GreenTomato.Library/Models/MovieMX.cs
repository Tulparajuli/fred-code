using System.Collections.Generic;
using GreenTomato.Library.Interfaces;

namespace GreenTomato.Library.Models
{
  public class MovieMX : IMovie
  {
    public string Title { get; set; }
    public Genre Genre { get; set; }
    public List<Actor> Actors { get; set; }
  }
}