using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CatalogOfFreeContent.Tests
{
    [TestClass]
    public class UnitTestICatalog
    {
        [TestMethod]
        public void TestMethodAddSingleItem()
        {
            Catalog catalog = new Catalog();
            Content item = new Content(ContentType.Book, 
                new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" }); 
            catalog.Add(item);
            Assert.AreEqual(1, catalog.Count);
        }

        [TestMethod]
        public void TestMethodAddDuplicatedItems()
        {
            Catalog catalog = new Catalog();
            Content firstItem = new Content(ContentType.Book,
                new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(firstItem);
            Content secondItem = new Content(ContentType.Book,
               new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(secondItem);
            Assert.AreEqual(2, catalog.Count);
        }

        [TestMethod]
        public void TestMethodAddMultipleItems()
        {
            Catalog catalog = new Catalog();
            Content firstItem = new Content(ContentType.Book,
                new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(firstItem);
            Content secondItem = new Content(ContentType.Movie,
               new string[] { "Intro C# Movie", "Kiril Petrov", "12231331", "http://www.introprogramming.info/movie" });
            catalog.Add(secondItem);
            Content thirdItem = new Content(ContentType.Song,
             new string[] { "Intro C# Song", "Petar Petrov", "12444455", "http://www.introprogramming.info/song" });
            catalog.Add(thirdItem);
            Assert.AreEqual(3, catalog.Count);
        }

        [TestMethod]
        public void TestMethodAdd500Items()
        {
            Catalog catalog = new Catalog();
            for (int i = 0; i < 500; i++)
            {
                Content item = new Content(ContentType.Book,
                    new string[] { "Intro C#" + (i % 5), "S.Nakov", "12763892",
                        "http://www.introprogramming.info" });
                catalog.Add(item);
            }
            Assert.AreEqual(500, catalog.Count);
        }

        [TestMethod]
        public void TestMethodGetListContentSingleItem()
        {
            Catalog catalog = new Catalog();
            Content item = new Content(ContentType.Book,
                new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(item);
            var result = catalog.GetListContent("Intro C#", 1);
            Assert.AreEqual(result.Count(), 1);
            Assert.AreSame(result.First(), item);
        }

        [TestMethod]
        public void TestMethodGetListContentDuplicatedItems()
        {
            Catalog catalog = new Catalog();
            Content firstItem = new Content(ContentType.Book,
                new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(firstItem);
            Content secondItem = new Content(ContentType.Book,
                new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(secondItem);
            var result = catalog.GetListContent("Intro C#", 2);
            Assert.AreEqual(result.Count(), 2);
            Assert.AreSame(result.First(), firstItem);
        }

        [TestMethod]
        public void TestMethodGetListContent500Items()
        {
            Catalog catalog = new Catalog();
            for (int i = 0; i < 500; i++)
            {
                Content item = new Content(ContentType.Book,
                    new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
                catalog.Add(item);
            }
            var result = catalog.GetListContent("Intro C#", 500);
            Assert.AreEqual(result.Count(), 500);
        }

        [TestMethod]
        public void TestMethodGetListContentNoMatchingItem()
        {
            Catalog catalog = new Catalog();
            Content item = new Content(ContentType.Book,
                new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(item);
            var result = catalog.GetListContent("No Match C#", 0);
            Assert.AreEqual(result.Count(), 0);
        }

        [TestMethod]
        public void TestMethodGetListContentOneMatchingItem()
        {
            Catalog catalog = new Catalog();
            Content firstItem = new Content(ContentType.Book,
                new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(firstItem);
            Content secondItem = new Content(ContentType.Book,
               new string[] { "Intro C##", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(secondItem);
            var result = catalog.GetListContent("Intro C#", 1);
            Assert.AreEqual(result.Count(), 1);
        }

        [TestMethod]
        public void TestMethodUpdateOneItem()
        {
            Catalog catalog = new Catalog();
            Content item = new Content(ContentType.Book,
                new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(item);
            var result = catalog.UpdateContent("http://www.introprogramming.info", "http://introprograming.info/en/");
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void TestMethodUpdateNoMatchingItem()
        {
            Catalog catalog = new Catalog();
            Content item = new Content(ContentType.Book,
                new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(item);
            var result = catalog.UpdateContent("", "http://introprograming.info/en/");
            Assert.AreEqual(result, 0);
        }
    }
}
