using System;
using System.Collections.Generic;
using System.Text;

namespace bewerbung
{
    class Nagetier : Säugetier
    {
        public string Nagerart { get; set; }
        public Nagetier(string tierart, string säugerart, string nagerart, string name) : base(tierart, säugerart, name)
        {
            Nagerart = nagerart;
        }
        public override string ToString()
        {
            return $"- {Tierart} - {Säugerart} - {Nagerart} ({Name})";
        }
    }
}
