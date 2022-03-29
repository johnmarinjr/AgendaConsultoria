using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgendaConsultoria.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "{0} obrigatório")]
        [StringLength(maximumLength: 60, MinimumLength = 3, ErrorMessage = "{0} tamanho precisa ser entre {2} e {1}")]
        public string Nome { get; set; }
        
        public ICollection<Contato> Contatos { get; set; } = new List<Contato>();

        public Cliente()
        {
        }

        public Cliente(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
