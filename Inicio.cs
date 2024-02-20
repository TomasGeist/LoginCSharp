using LinqToDB;
using Login.Models;
using Login.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Inicio : Form


    {
        public string quitarEspaciosNombre;
        public string quitarEspaciosPassword;
        public Inicio()
        {
            InitializeComponent();
            lbUsuarioError.Visible = false;
        }

        private void btnLogRegister_Click(object sender, EventArgs e)
        {

            quitarEspaciosNombre = tbUsuarioLog.Text.Replace(" ","");
            quitarEspaciosPassword = tbPassLog.Text.Replace(" ", "");
            tbUsuarioLog.Text = quitarEspaciosNombre;
            tbPassLog.Text = quitarEspaciosPassword;



            Conexion conexion = new Conexion();
            var user = conexion._Usuario.Where(u => u.NOMBRE.Equals(tbUsuarioLog.Text)).ToList();
            


            if (user.Count.Equals(0))
            
            {
                if (string.IsNullOrEmpty(quitarEspaciosNombre))
                {
                    lbUsuarioError.Text = "El nombre no puede estar vacio";
                    lbUsuarioError.Visible = true;
                    lbUsuarioError.ForeColor = Color.Red;
                    tbUsuarioLog.Focus();

                }
                else if (string.IsNullOrEmpty(quitarEspaciosPassword))
                {
                    labPassError.Text = "La password no puede estar vacia";
                    labPassError.Visible = true;
                    labPassError.ForeColor = Color.Red;
                    labPassError.Focus();
                    return;
                }
                else if (quitarEspaciosPassword.Length < 6)
                {
                    labPassError.Text = "La password debe tener más de 6 caracteres";
                    labPassError.Visible = true;
                    labPassError.ForeColor = Color.Red;
                    labPassError.Focus();
                    return;
                }
                else
                {
                    conexion._Usuario
                     .Value(a => a.NOMBRE, quitarEspaciosNombre)
                     .Value(a => a.PASS, quitarEspaciosPassword)
                     .Insert();
                    lbUsuarioError.Visible = false;
                }

            }
            else
            {
                lbUsuarioError.Text = "Este nombre ya esta en uso";
                lbUsuarioError.Visible = true;
                lbUsuarioError.ForeColor = Color.Red;
                tbUsuarioLog.Focus();
                return;
            } 
        }

        private void tbUsuarioLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
                lbUsuarioError.Text = "El nombre no puede contener espacios en blanco";
                     lbUsuarioError.Visible = true;
                     lbUsuarioError.ForeColor = Color.Red;
                       tbUsuarioLog.Focus();
                      return;
            }
            else
            {
                     lbUsuarioError.Visible = false;
                     return;
            }
        }

        private void tbPassLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
                labPassError.Text = "La contraseña no puede contener espacios en blanco";
                labPassError.Visible = true;
                labPassError.ForeColor = Color.Red;
                tbPassLog.Focus();
                return;
            }
            else
            {
                labPassError.Visible = false;
                return;
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            var user = conexion._Usuario.Where(u => u.NOMBRE.Equals(tbUsuarioLog.Text)).ToList();
            var userPass = conexion._Usuario.Where(u => u.PASS.Equals(tbPassLog.Text)).ToList();

            if (!user.Count.Equals(0) && !userPass.Count.Equals(0))
            {
                LoginExitoso exitoso = new LoginExitoso();
                ValidadoConExito cartelValidado = new ValidadoConExito();
                cartelValidado.ShowDialog();
                exitoso.Show();
                this.Hide() ; 
            }
        }
    } 
}
