using GreenTomato.Library.Interfaces;

namespace GreenTomato.Library.Models
{
  public class MoviePlayer : IPlayer
  {
    private IMovie m;
    public string S;

    public MoviePlayer(IMovie movie)
    {
      m = movie;
      S = new TVPlayer().Screen;
    }

    public string Forward()
    {
      return string.Format("{0} {1}", "forward", m.ToString());
    }

    public string Pause()
    {
      return string.Format("{0} {1}", "pause", m.ToString());
    }

    public string Play()
    {
      //TVPlayer.Play();
      return string.Format("{0} {1}", "play", m.ToString());
    }

    public string Rewind()
    {
      return string.Format("{0} {1}", "rewind", m.ToString());
    }

    public delegate string Playing();
    public event Playing Show;

    public void PlayMovie()
    {
      if (Show != null)
      {
        Show();
      }
      
    }
  }
}