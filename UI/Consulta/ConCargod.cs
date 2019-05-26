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

namespace Registro.UI.Consulta
{
    public partial class ConCargod : Form
    {
        public ConCargod()
        {
            InitializeComponent();
        }
        private void ConsultarDataGridView_Click(object sender, EventArgs e)
        {

            var listado = new List<Cargos>();
            if(CriteriosTextBox.Text.Trim().Length>0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                
                    listado = CargosBLL.GetList(p => true);
                    break;
                
                    case 1:
                        
                            int Id = Convert.ToInt32(CriteriosTextBox.Text);
                            listado = CargosBLL.GetList(p => p.CargoId == Id);
                            break;
                        
                    case 2:
                        
                            listado = CargosBLL.GetList(p => p.Descripcion.Contains(CriteriosTextBox.Text));
                            break;
                        
                }
                
            }
            else
            {
                listado = CargosBLL.GetList(p => true);

            }
            Datagriedview.DataSource = null;
            Datagriedview.DataSource = listado;
        }
        

        
    }
}
