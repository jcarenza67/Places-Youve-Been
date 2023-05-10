using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesYouveBeen.Models;
using System.Collections.Generic;
using System;

namespace ProjectName.Tests
{
  [TestClass]
    public class ClassNameTests
    {
      [TestMethod]
      public void PlaceConstructor_CreateInstancesOfPlace_Place ()
      {
        Place newPlace = new Place("test");
        Assert.AreEqual(typeof(Place), newPlace.GetType());
      }
    }
}