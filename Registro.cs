using Registro.BLL;
using Registro.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void Limpiar()
        {
            IdNumeric.Value = 0;
            NombreTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            NivelUsuarioComboBox.SelectedIndex = 0;
            UsuarioTextBox.Text = string.Empty;
            ClaveTextBox.Text = string.Empty;
            FechaIngresoDatePicker.Value = DateTime.Now;
            ErrorProvider.Clear();
        }
        public void LlenarComboBox()
        {
           
            NivelUsuarioComboBox.DataSource = null;
            NivelUsuarioComboBox.DataSource = CargosBLL.GetList(x => true);
            NivelUsuarioComboBox.ValueMember = "CargoId";
            NivelUsuarioComboBox.DisplayMember = "Descripcion";
        }
        private void EditarButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuario = new Usuarios();
            usuario.UsuarioId = Convert.ToInt32(IdNumeric.Value);
            usuario.Nombres = NombreTextBox.Text;
            usuario.NivelUsuario = NivelUsuarioComboBox.Text;
            usuario.Email = EmailTextBox.Text;
            usuario.Usuario = UsuarioTextBox.Text;
            usuario.Clave = ClaveTextBox.Text;
            usuario.FechaIngreso = FechaIngresoDatePicker.Value;
            return usuario;

        }
        public void LlenaCampo(Usuarios usuario)
        {
            IdNumeric.Value = usuario.UsuarioId;
            NombreTextBox.Text = usuario.Nombres;
            EmailTextBox.Text = usuario.Email;
            NivelUsuarioComboBox.Text = usuario.NivelUsuario;
            UsuarioTextBox.Text = usuario.Usuario;
            ClaveTextBox.Text = usuario.Clave;
            FechaIngresoDatePicker.Value = usuario.FechaIngreso;
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario;
            bool paso = false;
            if(!Validar())
                return;
            usuario = LlenaClase();
  
            if (IdNumeric.Value == 0)
                paso = RegistroBLL.Guardar(usuario);
            else
            {
                if
                    (!ExiteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar uan persona que no exixte ", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                paso = RegistroBLL.Modificar(usuario);
                
            }
            if (paso)
            {
                MessageBox.Show("Guardado!!", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
               
            else
                MessageBox.Show("No se puede guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);




        }
        private bool ExiteEnLaBaseDeDatos()
        {
            Usuarios usuarios = RegistroBLL.Buscar((int)IdNumeric.Value);
            return (usuarios != null);
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int Id;
            Usuarios usuario = new Usuarios();
            int.TryParse(IdNumeric.Text, out Id);
            usuario = RegistroBLL.Buscar(Id);
            if (usuario != null)
            {
                MessageBox.Show("Persona Encontrada");
                LlenaCampo(usuario);
            }
            else
            {
                MessageBox.Show("Persona no encontrada");
            }


        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            int id;
            int.TryParse(IdNumeric.Text, out id);
            Limpiar();
            if (RegistroBLL.Eliminar(id))
                MessageBox.Show("eliminado", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                ErrorProvider.SetError(IdNumeric, "nose puede eliminar esta peesonas");

        }
        private bool Validar()
        {
            bool paso = true;
            ErrorProvider.Clear();
            if (NombreTextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(NombreTextBox, "El Campo nombre no puede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                ErrorProvider.SetError(EmailTextBox, "el campo email no puede esar vacio");
                EmailTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(UsuarioTextBox.Text))
            {
                ErrorProvider.SetError(UsuarioTextBox, "El campo usuario no puede estar vacia");
                UsuarioTextBox.Focus();
                paso = false;

            }
            if (string.IsNullOrWhiteSpace(ClaveTextBox.Text))
            {
                ErrorProvider.SetError(ClaveTextBox, "Este campo o puede estar vacio");
                ClaveTextBox.Focus();
                paso = false;
            }
            return paso;
          
        }

    
    }
}
