namespace GreenTomato.Library.Models
{
  public class RadioPlayer // singleton
  {
    private static RadioPlayer rp = new RadioPlayer();

    private RadioPlayer()
    {

    }

    public static RadioPlayer Create()
    {
      // if (rp == null)
      // {
      //   lock (rp)
      //   {
      //     rp = new RadioPlayer();
      //   }
      // }

      return rp;
    }
  }
}