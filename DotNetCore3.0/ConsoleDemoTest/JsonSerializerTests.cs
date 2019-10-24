using DemoContext;
using NUnit.Framework;
using System;
using System.Text.Json;

namespace ConsoleDemoTest
{
    public class JsonSerializerTests
    {
        [Test]
        public void JsonSerializerRoundTripTest()
        {
            var super = new SuperHero(1, "Diana Prince", "Wonder Woman");
            super.AddEnemy("Cheetah");
            super.AddEnemy("Silver Swan");

            var superJson = System.Text.Json.JsonSerializer.Serialize(super);

            var copySuper = JsonSerializer.Deserialize<SuperHero>(superJson);

            Assert.AreEqual(super.Name, copySuper.Name);
            Assert.AreEqual(super.Enemies.Count, copySuper.Enemies.Count);
        }
    }
}