using NUnit.Framework;
using System;
using System.Text.Json;

namespace ConsoleDemoTest
{
    public class JsonDocumentTests
    {
        [Test]
        public void JsonDocumentTest()
        {
            var jsonString = @"
{
    ""name"":""Peter Parker"",
    ""superName"": ""Spider Man"",
    ""enemies"": [
        ""Doctor Octopus"",
        ""Sandman""
    ]
}";

            using var document = JsonDocument.Parse(jsonString);

            var root = document.RootElement;
            var name = root.GetProperty("name").GetString();

            Assert.AreEqual("Peter Parker", name);

            Assert.AreEqual(2, root.GetProperty("enemies").GetArrayLength());
        }
    }
}