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
    public partial class FrmConDentista : Form
    {
        DentistaService Service = new DentistaService();
        public FrmConDentista()
        {
            InitializeComponent();
            IniciarForm();
        }
        public void IniciarForm()
        {
            var Lista = Service.Listar();
            if(Lista == null)
            {
                MessageBox.Show("Não existe nenhum dentista cadastrado!", "Atenção");
            }
            else
            {
                char letraAnterior = '#'; 
                int numTabela = -1;
                DataGridView data = new DataGridView();

                foreach(var dado in Lista)
                {
                    char primeiraLetra = dado.Nome.Trim()[0]; //Extraindo a primeira letra do campo
                    if (primeiraLetra.ToString().ToUpper() == letraAnterior.ToString().ToUpper()) //Se já existir letra na aba gera a linha
                    {
                        GerarLinha(data, dado);
                    }
                    else //Se não existir na aba gera uma Tabela
                    {
                        numTabela = numTabela + 1;
                        tc.TabPages.Add(primeiraLetra.ToString().ToUpper());
                        DataGridView dg = new DataGridView();
                        data = dg;
                        tc.TabPages[numTabela].Controls.Add(dg);
                        GerarTabela(dg);
                        GerarLinha(dg,dado);
                    }
                    
                   letraAnterior = primeiraLetra;
                }
            }
        }

        private void GerarTabela(DataGridView dg)
        {
            //Aparência do Grid
            dg.ReadOnly = true; //Somente leitura
            dg.AllowUserToAddRows = false;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Auto redimensionamento do grid
            dg.AllowUserToResizeColumns = false;
            dg.AllowUserToResizeRows = false;
            dg.Dock = DockStyle.Fill;
            dg.RowHeadersVisible = false;
            dg.BackgroundColor = Color.White;
            dg.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Seleciona a linha inteira
            dg.DefaultCellStyle.SelectionBackColor = Color.DarkCyan;
            dg.DefaultCellStyle.SelectionForeColor = Color.White;
            dg.CellBorderStyle = DataGridViewCellBorderStyle.None;

            //Colunas do Grid
            dg.Columns.Add("Codigo", "Código");
            dg.Columns[0].Visible = false; //Ocultando a coluna ID do Grid

            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.HeaderText = "Nome";
            link.Name = "Nome";
            dg.Columns.Add(link);
            dg.Columns.Add("Telefone", "Telefone");
            dg.Columns.Add("Celular", "Celular");
            dg.Columns.Add("CRO", "CRO");

            dg.CellContentClick += new DataGridViewCellEventHandler(this.tb_click);
        }
        private void tb_click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = sender as DataGridView;

            try
            {
                if(e.ColumnIndex == 1 && e.RowIndex != -1)
                {
                    var ID = dg.Rows[e.RowIndex].Cells[0].Value;
                    Dentista obj = Service.Buscar(Convert.ToInt32(ID));

                    var Form = new FrmEditarDentista(obj); //Passagem de parâmetros entre formulários
                    Form.ShowDialog();

                    //Verificando o status do formulário
                    if(Form.status == "Apagado!")
                    {
                        this.Close();
                        FrmConDentista ConsultaDentista = new FrmConDentista();
                        ConsultaDentista.ShowDialog();
                    } 
                    if(Form.status == "Editado!")
                    {
                        dg.Rows.RemoveAt(e.RowIndex); //Remove o registro do Data Grid
                        GerarLinha(dg,obj); //Mostra novamente o registro que foi editado
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar o dentista", "Atenção!" + ex.Message);
            }
        }
        private void GerarLinha(DataGridView data, Dentista dado)
        {
            int linhaAtual = data.Rows.Add();
            data.Rows[linhaAtual].Cells[0].Value = dado.Id;
            data.Rows[linhaAtual].Cells[1].Value = dado.Nome;
            data.Rows[linhaAtual].Cells[2].Value = dado.Telefone.ToString("(00) 0000-0000");
            data.Rows[linhaAtual].Cells[3].Value = dado.Celular.ToString("(00) 00000-0000");
            data.Rows[linhaAtual].Cells[4].Value = dado.CRO; 
        }
    }
}

