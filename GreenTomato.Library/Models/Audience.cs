using System;
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
  }
}