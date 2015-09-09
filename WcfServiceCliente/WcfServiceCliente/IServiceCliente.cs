using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceCliente
{
    // O OperationContract é usado para adicionar operações de serviço.
    // O DataContract é usado para adicionar tipos operações de serviço.
    #region Service Contract
    [ServiceContract]
    public interface IServiceCliente
    {
        [OperationContract]
        string InsertClientDetails(ClientDetails clientInfo);

        [OperationContract]
        DataSet SelectClientDetails();

        [OperationContract]
        bool DeleteClientDetails(ClientDetails clientInfo);

        [OperationContract]
        DataSet UpdateClientDetails(ClientDetails clientInfo);

        [OperationContract]
        void UpdateRegistrationTable(ClientDetails clientInfo);
    }
    #endregion

    #region Detalhes do Cliente
    [DataContract]
    public class ClientDetails
    {
        int id;
        char tipoPessoa;
        string nome;
        string cpfCnpj;
        string telefone;
        string logradouro;
        string numero;
        string cep;
        string bairro;
        string cidade;
        char uf;
        string pais;

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public char TipoPessoa
        {
            get { return tipoPessoa; }
            set { tipoPessoa = value; }
        }

        [DataMember]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        [DataMember]
        public string CpfCnpj
        {
            get { return cpfCnpj; }
            set { cpfCnpj = value; }
        }

        [DataMember]
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        [DataMember]
        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }

        [DataMember]
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        [DataMember]
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        [DataMember]
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        [DataMember]
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        [DataMember]
        public char Uf
        {
            get { return uf; }
            set { uf = value; }
        }
        
        [DataMember]
        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }
    }
    #endregion 
}
