using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using WebAppCliente.ServiceReferenceCliente;

namespace WebAppCliente
{
    public partial class Cliente : System.Web.UI.Page
    {
        // Chamada do Webservice.
        ServiceReferenceCliente.ServiceClienteClient service = new ServiceReferenceCliente.ServiceClienteClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Verifica se está chamando pela primeira.
            if (!IsPostBack) { }
                BindRegistrosGrid();
        }

        // Faz a ligação dos dados com a Grid.
        private void BindRegistrosGrid()
        {
            DataSet ds = new DataSet();
            ds = service.SelectClientDetails();
            grdCliente.DataSource = ds;
            grdCliente.DataBind();
        }

        // Botão de enviar dados.
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Altera ou grava novos dados.
            if (btnSubmit.Text == "Alterar")
                UpdateClienteDetails();
            else
                GravarDetails();
        }
        
        private void UpdateClienteDetails()
        {
            ClientDetails cliente = new ClientDetails() { 
                Id = Convert.ToInt32(ViewState["Id"].ToString()),
                Nome = txtNome.Text.Trim(),
                CpfCnpj = txtCpfCnpj.Text.Trim(),
                Telefone = txtTelefone.Text.Trim(),
                Logradouro = txtLogradouro.Text.Trim(),
                Numero = txtNumero.Text.Trim(),
                Cep = txtCep.Text.Trim(),
                Bairro = txtBairro.Text.Trim(),
                Cidade = txtCidade.Text.Trim(),
                Uf = Convert.ToChar(txtUf),
                Pais = txtPais.Text.Trim()
            };

            service.UpdateClientDetails(cliente);
            lblMensagem.Text = "Registro Alterado com Sucesso.";
            LimparDetails();
            BindRegistrosGrid();
        }

        // Limpar os campos da tela
        private void LimparDetails()
        {
            txtNome.Text = string.Empty;
            txtCpfCnpj.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtCep.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtUf.Text = string.Empty;
            txtPais.Text = string.Empty;
            
            btnSubmit.Text = "Enviar";
            txtNome.Focus();
        }

        private void GravarDetails()
        {
            ClientDetails cliente = new ClientDetails() {
                Nome = txtNome.Text.Trim(),
                CpfCnpj = txtCpfCnpj.Text.Trim(),
                Telefone = txtTelefone.Text.Trim(),
                Logradouro = txtLogradouro.Text.Trim(),
                Numero = txtNumero.Text.Trim(),
                Cep = txtCep.Text.Trim(),
                Bairro = txtBairro.Text.Trim(),
                Cidade = txtCidade.Text.Trim(),
                Uf = Convert.ToChar(txtUf),
                Pais = txtPais.Text.Trim()
            };
            
            lblMensagem.Text = service.InsertClientDetails(cliente);
            LimparDetails();
            BindRegistrosGrid();
        }

        // Edição dos registros da Grid.
        protected void imgEdit_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {
            ClientDetails cliente = new ClientDetails();
            cliente.Id = int.Parse(e.CommandArgument.ToString());
            ViewState["Id"] = cliente.Id;
            DataSet ds = new DataSet();
            ds = service.SelectClientDetails();

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtNome.Text = ds.Tables[0].Rows[0]["Nome"].ToString();
                txtCpfCnpj.Text = ds.Tables[0].Rows[0]["CpfCnpj"].ToString();
                txtTelefone.Text = ds.Tables[0].Rows[0]["Telefone"].ToString();
                txtLogradouro.Text = ds.Tables[0].Rows[0]["Logradouro"].ToString();
                txtNumero.Text = ds.Tables[0].Rows[0]["Numero"].ToString();
                txtCep.Text = ds.Tables[0].Rows[0]["Cep"].ToString();
                txtBairro.Text = ds.Tables[0].Rows[0]["Bairro"].ToString();
                txtCidade.Text = ds.Tables[0].Rows[0]["Cidade"].ToString();
                txtUf.Text = ds.Tables[0].Rows[0]["Uf"].ToString();
                txtPais.Text = ds.Tables[0].Rows[0]["Pais"].ToString();
                
                btnSubmit.Text = "Alterar";
            }
        }

        // Botão para excluir o registro.
        protected void imgDel_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {
            ClientDetails cliente = new ClientDetails();
            cliente.Id = int.Parse(e.CommandArgument.ToString());
            if (service.DeleteClientDetails(cliente) == true)
                lblMensagem.Text = "Registro Excluído com Sucesso.";
            else
                lblMensagem.Text = "Registro não pode ser excluído.";
            
            BindRegistrosGrid();
        }

        // Limpa o formulário.
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            LimparDetails();
            lblMensagem.Text = string.Empty;
        }
    }
}

