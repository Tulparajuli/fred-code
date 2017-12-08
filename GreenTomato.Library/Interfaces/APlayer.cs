using GreenTomato.Library.Attributes;

namespace GreenTomato.Library.Interfaces
{
  public abstract class APlayer : IPlayer
  {
    public string Screen { get; set; }
    public Power Power { get; set; }
    public Button Button { get; set; }

    public APlayer()
    {
      Create();
    }

    protected virtual APlayer Create()
    {
      return this;
    }

    public string Forward()
    {
      throw new System.NotImplementedException();
    }

    public string Pause()
    {
      throw new System.NotImplementedException();
    }

    public string Play()
    {
      throw new System.NotImplementedException();
    }

    public string Rewind()
    {
      throw new System.NotImplementedException();
    }
  }
}