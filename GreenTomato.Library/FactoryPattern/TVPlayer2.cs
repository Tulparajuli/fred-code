using System.Collections.Generic;

namespace GreenTomato.Library.FactoryPattern
{
  public class TVPlayer2 : APlayer2
  {
    public override List<AComponent2> Create()
    {
      return new List<AComponent2>()
      {
        new Screen2() { PartNumber = 100 },
        new Button2(),
        new Button2(),
        new Power2()
      };
    }
  }
}
