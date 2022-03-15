using System;
using System.Collections.Generic;
using System.Text;

namespace bewerbung
{
    class Katze : Säugetier
    {
        public string Katzenart { get; set; }
        public Katze(string tierart, string säugerart, string katzenart, string name) : base(tierart, säugerart, name)
        {
            Katzenart = katzenart;
        }
        public override string ToString()
        {
            return $"- {Tierart} - {Säugerart} - {Katzenart} ({Name})";
        }
    }
}
