using DemoContext;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Linq;
using System.Text.Json;

namespace ConsoleDemoTest
{
    public class SuperDbContextTests
    { 
        [Test]
        public void MethodTest()
        {
            var options = new DbContextOptionsBuilder<SuperDbContext>()
                .UseInMemoryDatabase(databaseName: "SuperTester")
                .Options;
            using var db = new SuperDbContext(options);
            db.SuperHeroes.Add(new SuperHero(1, "Dianna Prince", "Wonder Woman"));
            db.SuperHeroes.Add(new SuperHero(2, "Bruce Banner", "The Hulk"));
            db.SaveChanges();

            Assert.AreEqual(2, db.SuperHeroes.Count());

            var wonders = db.SuperHeroes.Where(f => f.StartsWith("Wonder"));
            Assert.Catch<InvalidOperationException>(() => { wonders.Count(); });

            var moreWonders = db.SuperHeroes.ToList().Where(f => f.StartsWith("Wonder"));
            Assert.AreEqual(1, moreWonders.Count());

            var newWonders = db.SuperHeroes.Where(f => f.SuperName.StartsWith("Wonder"));
            Assert.AreEqual(1, newWonders.Count());
        }
    }
}