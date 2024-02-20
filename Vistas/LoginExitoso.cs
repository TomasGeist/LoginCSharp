using LinqToDB;
using Login.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Vistas
{
    public partial class LoginExitoso : Form
    {
        public LoginExitoso()
        {
            InitializeComponent();
            Conexion conexion = new Conexion();
            foreach (var item in conexion._Usuario)
            {
                int rowIndex = dgwUsers.Rows.Add();
                dgwUsers.Rows[rowIndex].Cells[0].Value = item.id;
                dgwUsers.Rows[rowIndex].Cells[1].Value = item.NOMBRE;
                dgwUsers.Rows[rowIndex].Cells[2].Value = item.PASS;
            }
        }

        private void btnEliminarNombre_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            conexion._Usuario.Where(p => p.NOMBRE == tbNombreAEliminar.Text).Delete();
            dgwUsers.Rows.Clear();
            foreach (var item in conexion._Usuario)
            {
                int rowIndex = dgwUsers.Rows.Add();
                dgwUsers.Rows[rowIndex].Cells[0].Value = item.id;
                dgwUsers.Rows[rowIndex].Cells[1].Value = item.NOMBRE;
                dgwUsers.Rows[rowIndex].Cells[2].Value = item.PASS;
            }
        }

        private void LoginExitoso_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
