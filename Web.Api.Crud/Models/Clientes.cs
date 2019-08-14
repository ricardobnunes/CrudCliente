using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Api.Crud.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        [Required]
        [Column(TypeName = "varchar(40)")]
        public string NomeCompleto { get; set; }
        [Required]
        [Column(TypeName = "varchar(5)")]
        public string ClienteCod { get; set; }
        [Required]
        [Column(TypeName = "varchar(11)")]
        public string TelCliente { get; set; }
        [Required]
        [Column(TypeName = "varchar(11)")]
        public string ClienteCPF { get; set; }
        [Required]
        [Column(TypeName = "varchar(9)")]
        public string ClienteRG { get; set; }

    }
}
