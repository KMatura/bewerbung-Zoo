using System;
using System.Collections.Generic;
using System.Text;

namespace bewerbung
{
    class Säugetier : Tier
    {
        public string Säugerart { get; set; }

        public Säugetier(string tierart, string säugerart, string name) : base(name, tierart)
        {
            Säugerart = säugerart;
        }
    }
}
