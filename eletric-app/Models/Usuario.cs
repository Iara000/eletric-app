﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eletric_app.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public string Email { get; set; }

        [Required (ErrorMessage ="Obrigatório informar o nome!")]
        public string Nome { get; set; }

        public string Sobrenome { get; set; }


        [Required(ErrorMessage = "Obrigatório informar a senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o perfil!")]
        public Perfil Perfil { get; set; }
    }
    public enum Perfil
    {
        Admin,
        User
    }
}
