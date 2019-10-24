using DemoContext;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Linq;
using System.Text.Json;

namespace ConsoleDemoTest
{
    public class InterfaceTests
    { 
        [Test]
        public void MethodTest()
        {
            IAlterEgo super = new SuperHero(1, "Dianna Prince", "Wonder Woman");

            Assert.AreEqual("Dianna Prince", super.Name);

            super.Anonymize();
            Assert.AreEqual("Sir Dianna Prince", super.Name);

            var super2 = (ISuperHero)super;
            super2.Superify();
            Assert.AreEqual("Wonder Wonder Woman", super2.SuperName);

        }
    }
}