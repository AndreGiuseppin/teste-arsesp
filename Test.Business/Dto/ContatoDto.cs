using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test.Business.Dto
{
    public class ContatoDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage="O nome do usuário é obrigatório")]
        [StringLength(255)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Telefone Residencial do usuário é obrigatório")]
        [StringLength(50)]
        [Display(Name = "Telefone Residencial")]
        public string TelefoneResidencial { get; set; }

        [Required(ErrorMessage = "O Telefone Comercial do usuário é obrigatório")]
        [StringLength(50)]
        [Display(Name = "Telefone Comercial")]
        public string TelefoneCelular { get; set; }
    }
}