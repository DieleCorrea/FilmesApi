﻿using System.ComponentModel.DataAnnotations;

namespace ApiFilme.Data.Dtos
{
    public class ReadServicoDto
    {
        public int ServicoId { get; set; }
        public string Nome { get; set; }
        public TimeOnly TempoDeExecucao { get; set; }
        public decimal Valor { get; set; }
    }
}
