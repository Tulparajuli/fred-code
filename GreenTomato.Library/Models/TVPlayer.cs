using GreenTomato.Library.Attributes;
using GreenTomato.Library.Interfaces;

namespace GreenTomato.Library.Models
{
  public class TVPlayer : APlayer
  {
    // public void Play()
    // {
    //   var rp = RadioPlayer.Create();
    // }

    public TVPlayer()
    {

    }
    private TVPlayer(string s, Power p, Button b)
    {
      Screen = s;
      Power = p;
      Button = b;
    }

    protected override APlayer Create()
    {
      return new TVPlayer("hello", new Power(), new Button());
    }
  }
}