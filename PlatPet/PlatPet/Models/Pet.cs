using System;
using System.Collections.Generic;
using System.Text;

namespace PlatPet.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string NomePet { get; set; }
        public int Especie { get; set; }
        public int SubEspecie { get; set; }
        public string Rg { get; set; }
    }
}
