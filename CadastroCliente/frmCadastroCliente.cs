using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Presenter;

namespace CadastroCliente
{
    public partial class frmCadastroCliente : MetroFramework.Forms.MetroForm
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private static Guid idCliente;
        DadosClientePresenter dadosPresenter = new DadosClientePresenter();

        private void btnBuscar_Click(object sender, EventArgs e)
        {       
            DadosClientePresenter dados = new DadosClientePresenter();

            List<ClienteDTO> lDados = dados.ListarClientes(txtNomeBusca.Text);

            if (lDados.Count > 0)
            {
                grdCliente.AutoGenerateColumns = false;
                grdCliente.DataSource = lDados;
            }
            else
                MessageBox.Show("Não foram encontrado registros!!", "Atenção!");
        }

        private void grdCliente_Click(object sender, EventArgs e)
        {
            if (grdCliente.RowCount > 0)
            {
                txtID.Text = grdCliente.SelectedRows[0].Cells["ID"].Value.ToString();

                Guid id = new Guid();

                if (Guid.TryParse(txtID.Text, out id))
                {
                    ClienteDTO cliente = dadosPresenter.RetornaClienteDTO(id);

                    txtCelular.Text = cliente.Celular;
                    txtCEP.Text = cliente.CEP;
                    txtEmail.Text = cliente.Email;
                    txtEndereco.Text = cliente.Endereco;
                    txtNome.Text = cliente.Nome;
                    txtTelefone.Text = cliente.Telefone;

                    btnExcluir.Visible = true;
                    btnGravar.Text = "Atualizar";
                    grdCliente.DataSource = null;
                    txtNomeBusca.Text = string.Empty;
                }
                else
                    txtID.Text = string.Empty;
            }
        }

        private void LimparDados()
        {
            txtCelular.Text = "";
            txtCEP.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
            idCliente = Guid.NewGuid();
            btnGravar.Text = "Gravar";
            btnExcluir.Visible = false;
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            ClienteDTO dados = new ClienteDTO();
            Guid id;

            if (!Guid.TryParse(txtID.Text, out id))
            {
                id = Guid.NewGuid();
            }

            dados.Celular = txtCelular.Text;
            dados.CEP = txtCEP.Text;
            dados.Email = txtEmail.Text;
            dados.Endereco = txtEndereco.Text;
            dados.Id = id;
            dados.Nome = txtNome.Text;
            dados.Telefone = txtTelefone.Text;

            MessageBoxIcon iconMsg = new MessageBoxIcon();
            string titulo = string.Empty;

            if (dadosPresenter.PersistirCliente(dados))
            {
                iconMsg = MessageBoxIcon.Information;
                titulo = "Atenção";
            }
            else
            {
                iconMsg = MessageBoxIcon.Warning;
                titulo = "Erro!";
            }

            MessageBox.Show(dadosPresenter.msg, titulo, MessageBoxButtons.OK, iconMsg);

            LimparDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Guid id;
            if (Guid.TryParse(txtID.Text, out id))
            {
                MessageBoxIcon iconMsg = new MessageBoxIcon();
                string titulo = string.Empty;

                if (dadosPresenter.ExcluirCliente(id))
                {
                    iconMsg = MessageBoxIcon.Information;
                    titulo = "Atenção";
                }
                else
                {
                    iconMsg = MessageBoxIcon.Warning;
                    titulo = "Erro!";
                }

                MessageBox.Show(dadosPresenter.msg, titulo, MessageBoxButtons.OK, iconMsg);

                LimparDados();
            }
            else
            {
                MessageBox.Show("Não foi possível Excluir o registro do cliente!!!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimparDados();
            }
        }
    }
}
