using LinqToDB;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Models
{
    public class Conexion : DataConnection
    {
        public Conexion() : base("DBlogin") { }

        public ITable<Usuario> _Usuario => this.GetTable<Usuario>();
        
    }
}
