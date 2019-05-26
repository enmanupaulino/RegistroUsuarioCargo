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
    public partial class ConUsuario : Form
    {
        public ConUsuario()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Usuarios>();
            if (CriteriosTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:// Todo
                        listado = RegistroBLL.GetList(p => true);
                        break;

                    case 1: //ID
                        int Id = Convert.ToInt32(CriteriosTextBox.Text);
                        listado = RegistroBLL.GetList(p => p.UsuarioId == Id);
                        break;

                    case 2://Nombres
                        listado = RegistroBLL.GetList(p => p.Nombres.Contains(CriteriosTextBox.Text));
                        break;

                    case 3://Email
                        listado = RegistroBLL.GetList(p => p.Email.Contains(CriteriosTextBox.Text));
                        break;


                    case 4: //Nivel Usuario
                        listado = RegistroBLL.GetList(p => p.NivelUsuario.Contains(CriteriosTextBox.Text));
                        break;

                    case 5://Usuario
                        listado = RegistroBLL.GetList(p => p.Usuario.Contains(CriteriosTextBox.Text));
                        break;

                    

                }
               listado = listado.Where(c => c.FechaIngreso.Date >= DesdeDateTimePicker.Value.Date && c.FechaIngreso.Date <= HastaDateTimePicker.Value.Date).ToList();

            }
            else
            {
                listado = RegistroBLL.GetList(p => true);
            }
            Datagriedview.DataSource = null;
            Datagriedview.DataSource = listado;

        }

       
    }
}
