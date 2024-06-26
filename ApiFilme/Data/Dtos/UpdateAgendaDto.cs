﻿using System.ComponentModel.DataAnnotations;

namespace ApiFilme.Data.Dtos
{
    public class UpdateAgendaDto
    {
        [Required]
        public int ClienteId { get; set; }
        [Required]
        public int ServicoId { get; set; }
        [Required]
        public DateTime Data { get; set; }

        [Required]
        public TimeOnly HoraInicio { get; set; }

        [Required]
        public TimeOnly HoraConclusao { get; set; }

        public string? Anotacoes { get; set; }
    }
}
