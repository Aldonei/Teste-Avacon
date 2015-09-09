using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceCliente.Utils;

namespace WcfServiceCliente
{
    // NOTA: 
    // 1. Clique com o botão direito do mouse sobre o arquivo ServiceCliente.svc
    // 2. Escolha a opção View in Browser. Assim pode-se verificar o arquivo XML gerado.
    public class ServiceCliente : IServiceCliente
    {
        #region Select
        public DataSet SelectClientDetails()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=registration;User ID=sa;Password=123456");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from RegistrationTable", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            // Executa a Transact-SQL statement contra a conexão a retorna o número de linhas afetadas.
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }
        #endregion

        #region Delete
        public bool DeleteClientDetails(ClientDetails clientInfo)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=registration;User ID=sa;Password=123456");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from RegistrationTable where Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", clientInfo.Id);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        #endregion

        #region Update
        public DataSet UpdateClientDetails(ClientDetails clientInfo)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=registration;User ID=sa;Password=123456");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from RegistrationTable where Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", clientInfo.Id);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }
                
        public void UpdateRegistrationTable(ClientDetails clientInfo)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=registration;User ID=sa;Password=123456");
            con.Open();
            SqlCommand cmd = new SqlCommand("update RegistrationTable set Nome=@Nome, CpfCnpj=@CpfCnpj, Telefone=@Telefone, Logradouro=@Logradouro, Numero=@Numero, Cep=@Cep, Bairro=@Bairro, Cidade=@Cidade, Uf=@Uf, Pais=@Pais where Id=@Id", con);
            cmd.Parameters.AddWithValue("@Nome", clientInfo.Nome);
            cmd.Parameters.AddWithValue("@CpfCnpj", clientInfo.CpfCnpj);
            cmd.Parameters.AddWithValue("@Telefone", clientInfo.Telefone);
            cmd.Parameters.AddWithValue("@Logradouro", clientInfo.Logradouro);
            cmd.Parameters.AddWithValue("@Numero", clientInfo.Numero);
            cmd.Parameters.AddWithValue("@Cep", clientInfo.Cep);
            cmd.Parameters.AddWithValue("@Bairro", clientInfo.Cep);
            cmd.Parameters.AddWithValue("@Cidade", clientInfo.Cidade);
            cmd.Parameters.AddWithValue("@Uf", clientInfo.Uf);
            cmd.Parameters.AddWithValue("@Pais", clientInfo.Pais);
            
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion

        #region Insert
        public string InsertClientDetails(ClientDetails clientInfo)
        {
            string message;
            // Validação dos campos obrigatórios.
            if (!VerificarCamposObrigatorios(clientInfo))
                return message = "Verificar campos obrigatórios.";

            // Validação de CPF ou CNPJ
            if (!VerificarCpfCnpj(clientInfo.CpfCnpj)) 
                return message = "CPF/CNPJ Inválido.";

            // O certo seria buscar do Web.config, como é apenas um exemplo. Esta seria a forma correta.
            // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=registration;User ID=sa;Password=123456");
            // Testa se a conexão com o BD está fechada.
            if (con.State == ConnectionState.Closed)
                con.Open();
            
            SqlCommand cmd = new SqlCommand("insert into RegistrationTable(Nome, CpfCnpj, Telefone, Logradouro, Numero, Cep, Bairro, Cidade, Uf, Pais) values(@Nome, @CpfCnpj, @Telefone, @Logradouro, @Numero, @Cep, @Bairro, @Cidade, @Uf, @Pais)", con);
            cmd.Parameters.AddWithValue("@Nome", clientInfo.Nome);
            cmd.Parameters.AddWithValue("@CpfCnpj", clientInfo.CpfCnpj);
            cmd.Parameters.AddWithValue("@Telefone", clientInfo.Telefone);
            cmd.Parameters.AddWithValue("@Logradouro", clientInfo.Logradouro);
            cmd.Parameters.AddWithValue("@Numero", clientInfo.Numero);
            cmd.Parameters.AddWithValue("@Cep", clientInfo.Cep);
            cmd.Parameters.AddWithValue("@Bairro", clientInfo.Cep);
            cmd.Parameters.AddWithValue("@Cidade", clientInfo.Cidade);
            cmd.Parameters.AddWithValue("@Uf", clientInfo.Uf);
            cmd.Parameters.AddWithValue("@Pais", clientInfo.Pais);
            int result = cmd.ExecuteNonQuery();
            // Se igual a 1 ocorreu tudo certo.
            if (result.Equals(1))
                message = string.Concat(clientInfo.Nome, ", cliente registrado com sucesso.");
            else
                message = string.Concat(clientInfo.Nome, ", problema ao inserir. Cliente não pode ser registrado.");

            con.Close();
            return message;
        }
        #endregion

        #region Validações
        private bool VerificarCpfCnpj(string cpfCnpj)
        {
            // Estiver em branco ou nulo.
            if (string.IsNullOrEmpty(cpfCnpj))
                return false;

            // Tira a formatação
            string returnCpfCnpj = cpfCnpj.Replace(".", "").Replace("/", "").Replace("-", "");
            
            // Verifica se é CPF
            if (returnCpfCnpj.Length.Equals(11)) { 
                if (Utils.Utils.ValidaCpf(returnCpfCnpj))
                    return true;
            }
            // Verifica se é CNPJ
            else if (returnCpfCnpj.Length.Equals(14))
                if (Utils.Utils.ValidaCnpj(returnCpfCnpj))
                    return true;
            
            // Se não achar nada com tamanho 11 ou 14, retorna falso, pois não foi totalmente preenchido o campo.
            return false;
        }

        private bool VerificarCamposObrigatorios(ClientDetails cliente)
        {
            // Nome e CPF ou CNPJ são obrigatórios.
            if (String.IsNullOrEmpty(cliente.Nome) || String.IsNullOrEmpty(cliente.CpfCnpj))
                return false;
            else
                return true;
        }
        #endregion
    }
}
