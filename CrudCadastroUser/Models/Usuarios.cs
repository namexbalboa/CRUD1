using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrudCadastroUser.Models
{
    public class Usuarios
    {
        [Key]
        public int UserID { get; set; }

        [RegularExpression(@"^.{5,}$", ErrorMessage = "Minimo de 5 caracteres")]
        [Required(ErrorMessage = "O preenchimento é obrigatório")]
        public string Nome { get; set; }

        [EmailAddress(ErrorMessage = "O formato do e-mail não é válido")]
        [Required(ErrorMessage = "O preenchimento é obrigatório")]
        public string Email { get; set; }

        [RegularExpression(@"^.{5,}$", ErrorMessage = "Minimo de 5 caracteres")]
        [Required(ErrorMessage = "O preenchimento é obrigatório")]
        public string Senha { get; set; }
    }
}