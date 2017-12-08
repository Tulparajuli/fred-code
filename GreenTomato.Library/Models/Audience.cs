using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using GreenTomato.Library.Interfaces;

namespace GreenTomato.Library.Models
{
  public class Audience
  {
    Func<IPlayer, string> Play = (mp) => { return mp.Play(); };
    Func<IPlayer, string> Pause = (mp) => { return mp.Pause(); };

    public delegate void Play1();
    public delegate string AudienceStuff();
    public delegate string Pause1(int i, bool b);

    public string response;

    private IPlayer mp;

    public Audience(IMovie movie)
    {
      mp = new MoviePlayer(movie);
    }

    public string Watch()
    {
      return mp.Play();
    }

    public void SnackBreak()
    {
      mp.Pause();
    }

    public void Talk()
    {
      mp.Forward();
    }

    public void Leave()
    {
      mp.Rewind();
    }

    public string DoAction(AudienceStuff action)
    {
      return action();
    }

    public void GoPlaying(MoviePlayer mo)
    {
      mo.Show += Watching;
    }

    public string Watching()
    {
      response = "we are watching";
      return response;
    }

    public void Saving(MoviePlayer mo)
    {
      mo.Show += SaveToFile;
      mo.Show += SaveToFileXML;
    }

    private string SaveToFile()
    {
      using(var f = File.AppendText("collection.txt"))
      {
        f.WriteLine(new MovieUS().ToString() + "\n");
        //GC.Collect();
      }

      using(var m = new MovieUS())
      {
        m.Title = "blah";
      }

      return string.Empty;
    }

    private string SaveToFileXML()
    {
      var s = new XmlSerializer(typeof(List<MovieUS>));
      var f = new StreamWriter("collection.xml");

      s.Serialize(f, new List<MovieUS>()
      {
        new MovieUS(),
        new MovieUS(),
        new MovieUS()
      });
      return string.Empty;
    }

    // public void ReadFromFile()
    // {
    //   var r = File.ReadAllLines("collection.txt");

    //   foreach (var line in r)
    //   {
    //     var a = line.Split();

    //     if (a.Length > 3) {
    //       if 
    //     }
    //     // do not do this... it is madness...
    //   }
    // }

    public void ReadFromFileXML()
    {
      var s = new XmlSerializer(typeof(List<MovieUS>));
      var r = new StreamReader("collection.xml");

      //var o = (MovieUS) s.Deserialize(r); // exception if not exists.
      var o2 = s.Deserialize(r) as List<MovieUS>; // null if not exists.
    }
  }
}