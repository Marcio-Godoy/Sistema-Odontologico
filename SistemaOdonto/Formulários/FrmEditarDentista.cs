using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tables;
using WcfService;

namespace SistemaOdonto
{
    public partial class FrmEditarDentista : Form
    {
        public string status;
        Dentista obj = new Dentista();
        DentistaService Service = new DentistaService();

        public FrmEditarDentista()
        {
        }
        public FrmEditarDentista(Dentista obj)
        {
            InitializeComponent();
            IniciarForm(obj);
        }
        private void IniciarForm(Dentista objP) //Recuperando dados para o formulário
        {
            this.obj = objP;
            lblCodigo.Text = this.obj.Id.ToString();
            txtNome.Text = this.obj.Nome;
            txtEmail.Text = this.obj.Email;
            mskTelefone.Text = this.obj.Telefone.ToString();
            mskCelular.Text = this.obj.Celular.ToString();
            mskCRO.Text = this.obj.CRO;
        }
        private string ValidarEdit()
        {
            tsMsg.ForeColor = Color.Red;
            if (txtNome.Text == string.Empty)
            {
                return "Preencha o campo Nome!";
            }
            else if (mskTelefone.Text == string.Empty)
            {
                return "Preencha o campo Telefone!";
            }
            else if (mskCelular.Text == string.Empty)
            {
                return "Preencha o campo Celular!";
            }
            else if (mskCRO.Text == string.Empty)
            {
                return "Preencha o campo CRO!";
            }
            else
            {
                tsMsg.ForeColor = Color.Black;
                return "Sucesso!";
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";
            tsMsg.Text = ValidarEdit();
            if(tsMsg.Text == "Sucesso!")
            {
                if (lblCodigo.Text != this.obj.Id.ToString())
                {
                    status = "Apagado!";
                    MessageBox.Show("Este registro acabou de ser excluído!", "Atenção!");
                }
                else
                {
                    status = "Editado!";
                    this.obj.Nome = txtNome.Text;
                    this.obj.Email = txtEmail.Text;
                    this.obj.Telefone = mskTelefone.Text != "" ? Convert.ToInt64(mskTelefone.Text) : 0;
                    this.obj.Celular = mskCelular.Text != "" ? Convert.ToInt64(mskCelular.Text) : 0;
                    this.obj.CRO = mskCRO.Text;
                    Service.Editar(this.obj);
                    this.Close();
                }
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";
            if (ValidarExclusao())
            {
                Service.Deletar(this.obj.Id);
                MessageBox.Show("Registro excluído com sucesso!");
                status = "Apagado!";
                this.Close();
            }
        }
        public bool ValidarExclusao()
        {
            DialogResult confirmacao = MessageBox.Show("Deseja excluir este registro?", "Excluir", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirmacao.ToString().ToUpper() == "YES")
                return true;
            else
                return false;
        }
    }
}
