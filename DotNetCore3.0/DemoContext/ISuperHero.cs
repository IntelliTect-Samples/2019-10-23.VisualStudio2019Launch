using System;
using System.Collections.Generic;
using System.Text;

namespace DemoContext
{
    public interface ISuperHero
    {
        string SuperName { get; set; }
        public void Superify()
        {
            Super("Wonder");
        }
        public void Super(string start)
        {
            SuperName = $"{start} {SuperName}";
        }
    }
}
