using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DemoContext
{
    public class SuperHero: ISuperHero, IAlterEgo
    {
        public SuperHero() {
            Name = "";
            SuperName = "";
        }

        public SuperHero(int superHeroId, string name, string superName)
        {
            SuperHeroId = superHeroId;
            Name = name;
            SuperName = superName;
        }

        public int SuperHeroId { get; set; }

        public string Name { get; set; }
        public string SuperName { get; set; }
        [NotMapped]
        public List<string> Enemies { get; set; } = new List<string>();

        public bool StartsWith(string letters)
        {
            return SuperName.StartsWith(letters);
        }

        public void AddEnemy(string name)
        {
            Enemies.Add(name);
        }

        public void Anonymize(string start)
        {
            Name = $"{start} {Name}";
        }
    }
}
