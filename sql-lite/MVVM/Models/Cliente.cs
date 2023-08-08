using sql_lite.Repository;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql_lite.MVVM.Models
{
    [Table("Customers")]
    public class Cliente:TableData
    {
        [Column("name")]
        [MaxLength(200)]
        public string Nome { get; set; }

        [Column("cpf")]
        [Unique]
        [MaxLength(11)]
        public string CPF { get; set; }

        [Column("endereco")]
        [MaxLength(200)]
        public string Endereco { get; set; }

    }
}
