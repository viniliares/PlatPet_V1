using System;
using System.Collections.Generic;
using System.Text;

namespace PlatPet.Models
{
    public class UsuarioPessoa
    {
        public int IdUsuario { get; set; }
        public string UserUsuario { get; set; }
        public string PassUsuario { get; set; }
        public string StatusUsuario { get; set; }
        public int TipoUsuario { get; set; }
        public int IdPessoa { get; set; }
        public string NomePessoa { get; set; }
        public string SobrenomePessoa { get; set; }
        public string CPFPessoa { get; set; }
        public string TelefonePessoa { get; set; }
        public string EmailPessoa { get; set; }
        public string EnderecoPessoa { get; set; }
    }
}
