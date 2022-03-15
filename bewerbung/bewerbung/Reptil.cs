using System;
using System.Collections.Generic;
using System.Text;

namespace bewerbung
{
    class Reptil : Tier
    {
        public string Reptilienart { get; set; }
        public Reptil(string tierart, string reptilienart, string name) : base(name, tierart)
        {
            Reptilienart = reptilienart;
        }
        public override string ToString()
        {
            return $"- {Tierart} - {Reptilienart} ({Name})";
        }
    }
}
