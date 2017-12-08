using GreenTomato.Library.Interfaces;

namespace GreenTomato.Library.Models
{
  public class PlayerMaker
  {
    public static IPlayer Create(PlayerSelector ps)
    {
      switch (ps)
      {
        case PlayerSelector.Movie:
          return new MoviePlayer(new MovieCA());
        case PlayerSelector.Radio:
          //return new RadioPlayer();
        case PlayerSelector.TV:
          return new TVPlayer();
        default:
          return null;
      }
    }
  }
}