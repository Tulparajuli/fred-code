using System.Collections.Generic;
using GreenTomato.Library.Models;

namespace GreenTomato.Library.Interfaces
{
  public interface IMovie
  {
    string Title { get; set; }
    Genre Genre { get; set; }
    List<Actor> Actors { get; set; }
  }
}