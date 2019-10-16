using System;
using System.Collections.Generic;
using System.Text;

namespace PlatPet.Models
{
    public class Pet
    {
        public int IdPet { get; set; }
        public int IdPessoa { get; set; }
        public string NomePet { get; set; }
       //Pet não possui especie? public int Especie { get; set; }
        public int IdSubespecie { get; set; }
        public string RGPet { get; set; }
        public string ObsPet { get; set; }
    }
}
