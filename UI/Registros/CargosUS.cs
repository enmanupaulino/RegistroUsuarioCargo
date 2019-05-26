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
    public partial class CargosUS : Form
    {
        public CargosUS()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdNumeric.Value = 0;
            DescripcionTextBox.Text = string.Empty;

        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private Cargos LlenaClase()
        {
            Cargos cargo = new Cargos();
            cargo.CargoId = Convert.ToInt32(IdNumeric.Value);
            cargo.Descripcion = DescripcionTextBox.Text;

            return cargo;

        }
        public void LlenaCampo(Cargos cargo)
        {
            IdNumeric.Value = cargo.CargoId;
           DescripcionTextBox.Text = cargo.Descripcion;

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Cargos cargos;
            bool paso = false;
            if (!Validar())
                return;
            cargos = LlenaClase();

            if (IdNumeric.Value == 0)
                paso = CargosBLL.Guardar(cargos);
            else
            {
                if
                    (!ExiteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar uan persona que no exixte ", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                paso = CargosBLL.Modificar(cargos);

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
            Cargos cargos = CargosBLL.Buscar((int)IdNumeric.Value);
            return (cargos != null);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int Id;
            Cargos cargos = new Cargos();
            int.TryParse(IdNumeric.Text, out Id);
            cargos = CargosBLL.Buscar(Id);
            if (cargos != null)
            {
                MessageBox.Show("Persona Encontrada");
                LlenaCampo(cargos);
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
            if (CargosBLL.Eliminar(id))
                MessageBox.Show("eliminado", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                ErrorProvider.SetError(IdNumeric, "nose puede eliminar esta peesonas");
        }
        private bool Validar()
        {
            bool paso = true;
            ErrorProvider.Clear();


            if
                (DescripcionTextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(DescripcionTextBox, "El Campo nombre no puede estar vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }
                return paso;

        }
        
    }
}
