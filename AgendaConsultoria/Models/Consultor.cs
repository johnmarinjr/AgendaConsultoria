using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace AgendaConsultoria.Models

{
    public class Consultor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [StringLength(maximumLength: 60, MinimumLength = 3, ErrorMessage = "{0} tamanho precisa ser entre {2} e {1}")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Celular { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Data de Início")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataInicio { get; set; }

        [Display(Name = "Salário Base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double SalarioBase { get; set; }

        public Consultor()
        {
        }

        public Consultor(int id, string nome, string email, string celular, DateTime dataNascimento, DateTime dataInicio, double salarioBase)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Celular = celular;
            DataNascimento = dataNascimento;
            DataInicio = dataInicio;
            SalarioBase = salarioBase;
        }
    }
}
