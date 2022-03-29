using AgendaConsultoria.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace AgendaConsultoria.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Enums.TipoContato TipoContato { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [StringLength(maximumLength: 60, MinimumLength = 3, ErrorMessage = "{0} tamanho precisa ser entre {2} e {1}")]
        public string Nome { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Celular { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public Contato()
        {
        }

        public Contato(Cliente cliente, int id, TipoContato tipoContato, string nome, string telefone, string celular, string email)
        {
            Id = id;
            Cliente = cliente;
            TipoContato = tipoContato;
            Nome = nome;
            Telefone = telefone;
            Celular = celular;
            Email = email;
        }
    }
}
