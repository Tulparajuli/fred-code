using System.Collections.Generic;
using GreenTomato.Library.Interfaces;

namespace GreenTomato.Library.Models
{
  public class MovieMX : IMovie
  {
    public string Title { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public Genre Genre { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public List<Actor> Actors { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
  }
}