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
    public partial class FrmCadDentista : Form
    {
        DentistaService Service = new DentistaService();
        public FrmCadDentista()
        {
            InitializeComponent();
            txtNome.Text = mskCelular.Text;
        }
        private string ValidarCad()
        {
            tsMsg.ForeColor = Color.Red;
            if(txtNome.Text == string.Empty)
            {
                return "Preencha o campo Nome!";
            }
            else if(mskTelefone.Text == string.Empty)
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
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";
            try
            {
                tsMsg.Text = ValidarCad();
                if(tsMsg.Text == "Sucesso!")
                {
                    Service.Cadastrar(objGerado());
                    MessageBox.Show("Cadastro efetuado com sucesso!");
                    this.Close(); //Após realizar o cadastro fechar o formulário
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar!" + ex.Message);
            }
        }
        public Dentista objGerado()
        {
            Dentista obj = new Dentista();
            obj.Nome = txtNome.Text;
            obj.Email = txtEmail.Text;
            obj.Telefone = mskTelefone.Text != "" ? Convert.ToInt64(mskTelefone.Text) : 0;//Realiza a conversão se for diferente de vazio
            obj.Celular = mskCelular.Text != "" ? Convert.ToInt64(mskCelular.Text) : 0;            
            obj.CRO = mskCRO.Text;

            return obj;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            FrmConDentista ConsultaDentista = new FrmConDentista();
            ConsultaDentista.ShowDialog();
        }

        public void Limpar()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            mskTelefone.Text = string.Empty;
            mskCelular.Text = string.Empty;
            mskCRO.Text = string.Empty;
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
