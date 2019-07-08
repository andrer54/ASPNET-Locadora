using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Locadora.Models
{
    public class Usuario
    {
        [Required]
        public string Nome { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Data Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required]
        public string Senha { get; set; }

        [Display(Name = "Repita a Senha")]
        [Required]
        public string RepitaSenha { get; set; }
    }
}