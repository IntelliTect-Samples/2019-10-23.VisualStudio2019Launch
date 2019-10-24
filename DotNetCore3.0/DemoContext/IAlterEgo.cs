using System;
using System.Collections.Generic;
using System.Text;

namespace DemoContext
{
    public interface IAlterEgo
    {
        public string Name { get; set; } 
        public void Anonymize() => Anonymize("Sir");
        void Anonymize(string start);
    }
}
