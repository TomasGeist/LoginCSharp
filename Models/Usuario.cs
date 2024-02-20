using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Models
{
    public class Usuario
    {
        [PrimaryKey, Identity]
        public int id { get; set; }
        [Column("NOMBRE")]
        public string NOMBRE { get; set; }
        [Column("PASS")]
        public string PASS { get; set; }

        

        
        public Usuario() { }
    }
}
