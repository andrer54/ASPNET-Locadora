using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Locadora.Models
{
    public class Login
    {
        [Display(Name = "E-mail")]
        [EmailAddress]
        [Required(ErrorMessage ="Informe o seu e-mail.")]
        public string Email { get; set; }


        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Informe o sua senha.")]
        public string Senha { get; set; }

    }
}