using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOdonto
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void CadConsultas_Click(object sender, EventArgs e)
        {
            FrmEditarDentista EditDentista = new FrmEditarDentista();
            EditDentista.ShowDialog();
        }

        private void CadDentistas_Click(object sender, EventArgs e)
        {
            FrmCadDentista FrmDentistas = new FrmCadDentista();
            FrmDentistas.ShowDialog();
        }

        private void CadPacientes_Click(object sender, EventArgs e)
        {
            FrmCadDentista FrmDentistas = new FrmCadDentista();
            FrmDentistas.ShowDialog();
        }

        private void AgDentistas_Click(object sender, EventArgs e)
        {
            FrmConDentista FrmConsultaD = new FrmConDentista();
            FrmConsultaD.ShowDialog();
        }
    }
}
