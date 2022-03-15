using System;
using System.Collections.Generic;
using System.Text;

namespace bewerbung
{
    class Tier
    {
        public string Name { get; set; }
        public string Tierart { get; set; }
        public Tier(string name, string tierart)
        {
            Name = name;
            Tierart = tierart;
        }

    }
}
