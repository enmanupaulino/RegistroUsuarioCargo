using Registro.UI.Consulta;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

       

       

        private void CargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConUsuario f = new ConUsuario();
            f.Show();
        }

        private void CargosUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargosUS f = new CargosUS();
            f.Show();
        }

        private void RegistroUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.MdiParent = this;
            registro.Show();
        }

        private void ConsultaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConCargod f = new ConCargod();
            f.Show();
        }
    }
}
