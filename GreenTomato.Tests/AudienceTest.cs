using System;
using GreenTomato.Library.FactoryPattern;
using GreenTomato.Library.Interfaces;
using GreenTomato.Library.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static GreenTomato.Library.Models.Audience;

namespace GreenTomato.Tests
{
  [TestClass]
  public class AudienceTest
  {
    public Audience Audience { get; set; }

    public AudienceTest()
    {
      Audience = new Audience(new MovieUS());
    }

    // [TestMethod]
    // public void AudienceShouldWatch()
    // {
    //   var expected = "play " + typeof(MovieUS).ToString();
    //   var actual = Audience.Watch();

    //   Assert.IsTrue(expected == actual);
    // }

    // [TestMethod]
    // public void AudienceShouldDo()
    // {
    //   var m = new MovieUS();
    //   var mp = new MoviePlayer(m);
    //   AudienceStuff play = () => { return new MoviePlayer(new MovieCA()).Play(); };
    //   Action<int> compute = (i) => { System.Console.WriteLine(i); };
    //   var expected = "play " + typeof(MovieCA).ToString();
    //   var actual = Audience.DoAction(play);
    //   Audience.Pause1 x = (i, b) => { return string.Empty; }; 

    //   Assert.IsTrue(expected == actual);
    // }

    // [TestMethod]
    // public void AudienceWatching()
    // {
    //   var expected = "we are watching";
    //   var mp = new MoviePlayer(new MovieMX());
    //   var au = new Audience(new MovieMX());

    //   au.GoPlaying(mp);
    //   au.Saving(mp);
    //   mp.PlayMovie();

    //   Assert.AreEqual(expected, au.response);
    // }

    [TestMethod]
    public void FactoryPatternTV()
    {
      var tvFactory = new TVPlayer2();
      var tvParts = tvFactory.Create();

      Assert.AreEqual(4, tvParts.Count);
    }

    [TestMethod]
    public void FactoryPatternRadio()
    {
      var radioFactory = new RadioPlayer2();
      var radioParts = radioFactory.Create();

      Assert.AreEqual(7, radioParts.Count);
    }
  }
}