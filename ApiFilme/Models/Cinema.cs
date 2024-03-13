﻿using System.ComponentModel.DataAnnotations;

namespace ApiFilme.Models
{
    public class Cinema
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="O camppo nome é obrigatório")]
        public string Nome { get; set; }
        public int IdEndereco { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}
