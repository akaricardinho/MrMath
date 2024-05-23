using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrMath.Models
{
    public class Registro
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Data { get; set; }
        public string Senha { get; set; }

    }
}
