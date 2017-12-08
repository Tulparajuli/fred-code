using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using GreenTomato.Library.Interfaces;

namespace GreenTomato.Library.Models
{
  public class MovieUS : IMovie, IDisposable
  {
    [XmlIgnore]
    public string Title { get; set; }

    [XmlElement("Category")]
    public Genre Genre { get; set; }
    public List<Actor> Actors { get; set; }

    public MovieUS()
    {
      Title = "Get Out";
      Genre = new Genre();
      Actors = new List<Actor>()
      {
        new Actor()
      };
    }

    public override string ToString()
    {
      //return string.Format("{0} {1} {2}", Title, Genre, Actors[0]);
      return $"{Title} {Genre} {Actors[0]}";
    }

    public void Dispose()
    {
      GC.Collect();
    }

    ~MovieUS()
    {
      GC.Collect();
    }
  }
}