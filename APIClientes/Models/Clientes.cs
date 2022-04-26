using System.ComponentModel.DataAnnotations;

namespace womanAPI.Models
{
    public class Clientes
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string email { get; set; }

        public int Limite { get; set; }
    }
}