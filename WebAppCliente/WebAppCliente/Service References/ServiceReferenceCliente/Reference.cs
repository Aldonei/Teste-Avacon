﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppCliente.ServiceReferenceCliente {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceCliente.IServiceCliente")]
    public interface IServiceCliente {
        
        // CODEGEN: Parameter 'InsertClientDetailsResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/InsertClientDetails", ReplyAction="http://tempuri.org/IServiceCliente/InsertClientDetailsResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WebAppCliente.ServiceReferenceCliente.InsertClientDetailsResponse InsertClientDetails(WebAppCliente.ServiceReferenceCliente.InsertClientDetailsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/InsertClientDetails", ReplyAction="http://tempuri.org/IServiceCliente/InsertClientDetailsResponse")]
        System.Threading.Tasks.Task<WebAppCliente.ServiceReferenceCliente.InsertClientDetailsResponse> InsertClientDetailsAsync(WebAppCliente.ServiceReferenceCliente.InsertClientDetailsRequest request);
        
        // CODEGEN: Parameter 'SelectClientDetailsResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/SelectClientDetails", ReplyAction="http://tempuri.org/IServiceCliente/SelectClientDetailsResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WebAppCliente.ServiceReferenceCliente.SelectClientDetailsResponse SelectClientDetails(WebAppCliente.ServiceReferenceCliente.SelectClientDetailsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/SelectClientDetails", ReplyAction="http://tempuri.org/IServiceCliente/SelectClientDetailsResponse")]
        System.Threading.Tasks.Task<WebAppCliente.ServiceReferenceCliente.SelectClientDetailsResponse> SelectClientDetailsAsync(WebAppCliente.ServiceReferenceCliente.SelectClientDetailsRequest request);
        
        // CODEGEN: Parameter 'clientInfo' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/DeleteClientDetails", ReplyAction="http://tempuri.org/IServiceCliente/DeleteClientDetailsResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WebAppCliente.ServiceReferenceCliente.DeleteClientDetailsResponse DeleteClientDetails(WebAppCliente.ServiceReferenceCliente.DeleteClientDetailsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/DeleteClientDetails", ReplyAction="http://tempuri.org/IServiceCliente/DeleteClientDetailsResponse")]
        System.Threading.Tasks.Task<WebAppCliente.ServiceReferenceCliente.DeleteClientDetailsResponse> DeleteClientDetailsAsync(WebAppCliente.ServiceReferenceCliente.DeleteClientDetailsRequest request);
        
        // CODEGEN: Parameter 'UpdateClientDetailsResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/UpdateClientDetails", ReplyAction="http://tempuri.org/IServiceCliente/UpdateClientDetailsResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WebAppCliente.ServiceReferenceCliente.UpdateClientDetailsResponse UpdateClientDetails(WebAppCliente.ServiceReferenceCliente.UpdateClientDetailsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/UpdateClientDetails", ReplyAction="http://tempuri.org/IServiceCliente/UpdateClientDetailsResponse")]
        System.Threading.Tasks.Task<WebAppCliente.ServiceReferenceCliente.UpdateClientDetailsResponse> UpdateClientDetailsAsync(WebAppCliente.ServiceReferenceCliente.UpdateClientDetailsRequest request);
        
        // CODEGEN: Parameter 'clientInfo' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/UpdateRegistrationTable", ReplyAction="http://tempuri.org/IServiceCliente/UpdateRegistrationTableResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WebAppCliente.ServiceReferenceCliente.UpdateRegistrationTableResponse UpdateRegistrationTable(WebAppCliente.ServiceReferenceCliente.UpdateRegistrationTableRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/UpdateRegistrationTable", ReplyAction="http://tempuri.org/IServiceCliente/UpdateRegistrationTableResponse")]
        System.Threading.Tasks.Task<WebAppCliente.ServiceReferenceCliente.UpdateRegistrationTableResponse> UpdateRegistrationTableAsync(WebAppCliente.ServiceReferenceCliente.UpdateRegistrationTableRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfServiceCliente")]
    public partial class ClientDetails : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string bairroField;
        
        private string cepField;
        
        private string cidadeField;
        
        private string cpfCnpjField;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private string logradouroField;
        
        private string nomeField;
        
        private string numeroField;
        
        private string paisField;
        
        private string telefoneField;
        
        private int tipoPessoaField;
        
        private bool tipoPessoaFieldSpecified;
        
        private int ufField;
        
        private bool ufFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string Bairro {
            get {
                return this.bairroField;
            }
            set {
                this.bairroField = value;
                this.RaisePropertyChanged("Bairro");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string Cep {
            get {
                return this.cepField;
            }
            set {
                this.cepField = value;
                this.RaisePropertyChanged("Cep");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string Cidade {
            get {
                return this.cidadeField;
            }
            set {
                this.cidadeField = value;
                this.RaisePropertyChanged("Cidade");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public string CpfCnpj {
            get {
                return this.cpfCnpjField;
            }
            set {
                this.cpfCnpjField = value;
                this.RaisePropertyChanged("CpfCnpj");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
                this.RaisePropertyChanged("IdSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public string Logradouro {
            get {
                return this.logradouroField;
            }
            set {
                this.logradouroField = value;
                this.RaisePropertyChanged("Logradouro");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public string Nome {
            get {
                return this.nomeField;
            }
            set {
                this.nomeField = value;
                this.RaisePropertyChanged("Nome");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public string Numero {
            get {
                return this.numeroField;
            }
            set {
                this.numeroField = value;
                this.RaisePropertyChanged("Numero");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public string Pais {
            get {
                return this.paisField;
            }
            set {
                this.paisField = value;
                this.RaisePropertyChanged("Pais");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public string Telefone {
            get {
                return this.telefoneField;
            }
            set {
                this.telefoneField = value;
                this.RaisePropertyChanged("Telefone");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public int TipoPessoa {
            get {
                return this.tipoPessoaField;
            }
            set {
                this.tipoPessoaField = value;
                this.RaisePropertyChanged("TipoPessoa");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TipoPessoaSpecified {
            get {
                return this.tipoPessoaFieldSpecified;
            }
            set {
                this.tipoPessoaFieldSpecified = value;
                this.RaisePropertyChanged("TipoPessoaSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public int Uf {
            get {
                return this.ufField;
            }
            set {
                this.ufField = value;
                this.RaisePropertyChanged("Uf");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UfSpecified {
            get {
                return this.ufFieldSpecified;
            }
            set {
                this.ufFieldSpecified = value;
                this.RaisePropertyChanged("UfSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertClientDetails", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class InsertClientDetailsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public WebAppCliente.ServiceReferenceCliente.ClientDetails clientInfo;
        
        public InsertClientDetailsRequest() {
        }
        
        public InsertClientDetailsRequest(WebAppCliente.ServiceReferenceCliente.ClientDetails clientInfo) {
            this.clientInfo = clientInfo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertClientDetailsResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class InsertClientDetailsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string InsertClientDetailsResult;
        
        public InsertClientDetailsResponse() {
        }
        
        public InsertClientDetailsResponse(string InsertClientDetailsResult) {
            this.InsertClientDetailsResult = InsertClientDetailsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SelectClientDetails", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SelectClientDetailsRequest {
        
        public SelectClientDetailsRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SelectClientDetailsResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SelectClientDetailsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Data.DataSet SelectClientDetailsResult;
        
        public SelectClientDetailsResponse() {
        }
        
        public SelectClientDetailsResponse(System.Data.DataSet SelectClientDetailsResult) {
            this.SelectClientDetailsResult = SelectClientDetailsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteClientDetails", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DeleteClientDetailsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public WebAppCliente.ServiceReferenceCliente.ClientDetails clientInfo;
        
        public DeleteClientDetailsRequest() {
        }
        
        public DeleteClientDetailsRequest(WebAppCliente.ServiceReferenceCliente.ClientDetails clientInfo) {
            this.clientInfo = clientInfo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteClientDetailsResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DeleteClientDetailsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool DeleteClientDetailsResult;
        
        public DeleteClientDetailsResponse() {
        }
        
        public DeleteClientDetailsResponse(bool DeleteClientDetailsResult) {
            this.DeleteClientDetailsResult = DeleteClientDetailsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateClientDetails", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateClientDetailsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public WebAppCliente.ServiceReferenceCliente.ClientDetails clientInfo;
        
        public UpdateClientDetailsRequest() {
        }
        
        public UpdateClientDetailsRequest(WebAppCliente.ServiceReferenceCliente.ClientDetails clientInfo) {
            this.clientInfo = clientInfo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateClientDetailsResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateClientDetailsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Data.DataSet UpdateClientDetailsResult;
        
        public UpdateClientDetailsResponse() {
        }
        
        public UpdateClientDetailsResponse(System.Data.DataSet UpdateClientDetailsResult) {
            this.UpdateClientDetailsResult = UpdateClientDetailsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateRegistrationTable", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateRegistrationTableRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public WebAppCliente.ServiceReferenceCliente.ClientDetails clientInfo;
        
        public UpdateRegistrationTableRequest() {
        }
        
        public UpdateRegistrationTableRequest(WebAppCliente.ServiceReferenceCliente.ClientDetails clientInfo) {
            this.clientInfo = clientInfo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateRegistrationTableResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateRegistrationTableResponse {
        
        public UpdateRegistrationTableResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceClienteChannel : WebAppCliente.ServiceReferenceCliente.IServiceCliente, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClienteClient : System.ServiceModel.ClientBase<WebAppCliente.ServiceReferenceCliente.IServiceCliente>, WebAppCliente.ServiceReferenceCliente.IServiceCliente {
        
        public ServiceClienteClient() {
        }
        
        public ServiceClienteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClienteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClienteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClienteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebAppCliente.ServiceReferenceCliente.InsertClientDetailsResponse WebAppCliente.ServiceReferenceCliente.IServiceCliente.InsertClientDetails(WebAppCliente.ServiceReferenceCliente.InsertClientDetailsRequest request) {
            return base.Channel.InsertClientDetails(request);
        }
        
        public string InsertClientDetails(WebAppCliente.ServiceReferenceCliente.ClientDetails clientInfo) {
            WebAppCliente.ServiceReferenceCliente.InsertClientDetailsRequest inValue = new WebAppCliente.ServiceReferenceCliente.InsertClientDetailsRequest();
            inValue.clientInfo = clientInfo;
            WebAppCliente.ServiceReferenceCliente.InsertClientDetailsResponse retVal = ((WebAppCliente.ServiceReferenceCliente.IServiceCliente)(this)).InsertClientDetails(inValue);
            return retVal.InsertClientDetailsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebAppCliente.ServiceReferenceCliente.InsertClientDetailsResponse> WebAppCliente.ServiceReferenceCliente.IServiceCliente.InsertClientDetailsAsync(WebAppCliente.ServiceReferenceCliente.InsertClientDetailsRequest request) {
            return base.Channel.InsertClientDetailsAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebAppCliente.ServiceReferenceCliente.InsertClientDetailsResponse> InsertClientDetailsAsync(WebAppCliente.ServiceReferenceCliente.ClientDetails clientInfo) {
            WebAppCliente.ServiceReferenceCliente.InsertClientDetailsRequest inValue = new WebAppCliente.ServiceReferenceCliente.InsertClientDetailsRequest();
            inValue.clientInfo = clientInfo;
            return ((WebAppCliente.ServiceReferenceCliente.IServiceCliente)(this)).InsertClientDetailsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebAppCliente.ServiceReferenceCliente.SelectClientDetailsResponse WebAppCliente.ServiceReferenceCliente.IServiceCliente.SelectClientDetails(WebAppCliente.ServiceReferenceCliente.SelectClientDetailsRequest request) {
            return base.Channel.SelectClientDetails(request);
        }
        
        public System.Data.DataSet SelectClientDetails() {
            WebAppCliente.ServiceReferenceCliente.SelectClientDetailsRequest inValue = new WebAppCliente.ServiceReferenceCliente.SelectClientDetailsRequest();
            WebAppCliente.ServiceReferenceCliente.SelectClientDetailsResponse retVal = ((WebAppCliente.ServiceReferenceCliente.IServiceCliente)(this)).SelectClientDetails(inValue);
            return retVal.SelectClientDetailsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebAppCliente.ServiceReferenceCliente.SelectClientDetailsResponse> WebAppCliente.ServiceReferenceCliente.IServiceCliente.SelectClientDetailsAsync(WebAppCliente.ServiceReferenceCliente.SelectClientDetailsRequest request) {
            return base.Channel.SelectClientDetailsAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebAppCliente.ServiceReferenceCliente.SelectClientDetailsResponse> SelectClientDetailsAsync() {
            WebAppCliente.ServiceReferenceCliente.SelectClientDetailsRequest inValue = new WebAppCliente.ServiceReferenceCliente.SelectClientDetailsRequest();
            return ((WebAppCliente.ServiceReferenceCliente.IServiceCliente)(this)).SelectClientDetailsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebAppCliente.ServiceReferenceCliente.DeleteClientDetailsResponse WebAppCliente.ServiceReferenceCliente.IServiceCliente.DeleteClientDetails(WebAppCliente.ServiceReferenceCliente.DeleteClientDetailsRequest request) {
            return base.Channel.DeleteClientDetails(request);
        }
        
        public bool DeleteClientDetails(WebAppCliente.ServiceReferenceCliente.ClientDetails clientInfo) {
            WebAppCliente.ServiceReferenceCliente.DeleteClientDetailsRequest inValue = new WebAppCliente.ServiceReferenceCliente.DeleteClientDetailsRequest();
            inValue.clientInfo = clientInfo;
            WebAppCliente.ServiceReferenceCliente.DeleteClientDetailsResponse retVal = ((WebAppCliente.ServiceReferenceCliente.IServiceCliente)(this)).DeleteClientDetails(inValue);
            return retVal.DeleteClientDetailsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebAppCliente.ServiceReferenceCliente.DeleteClientDetailsResponse> WebAppCliente.ServiceReferenceCliente.IServiceCliente.DeleteClientDetailsAsync(WebAppCliente.ServiceReferenceCliente.DeleteClientDetailsRequest request) {
            return base.Channel.DeleteClientDetailsAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebAppCliente.ServiceReferenceCliente.DeleteClientDetailsResponse> DeleteClientDetailsAsync(WebAppCliente.ServiceReferenceCliente.ClientDetails clientInfo) {
            WebAppCliente.ServiceReferenceCliente.DeleteClientDetailsRequest inValue = new WebAppCliente.ServiceReferenceCliente.DeleteClientDetailsRequest();
            inValue.clientInfo = clientInfo;
            return ((WebAppCliente.ServiceReferenceCliente.IServiceCliente)(this)).DeleteClientDetailsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebAppCliente.ServiceReferenceCliente.UpdateClientDetailsResponse WebAppCliente.ServiceReferenceCliente.IServiceCliente.UpdateClientDetails(WebAppCliente.ServiceReferenceCliente.UpdateClientDetailsRequest request) {
            return base.Channel.UpdateClientDetails(request);
        }
        
        public System.Data.DataSet UpdateClientDetails(WebAppCliente.ServiceReferenceCliente.ClientDetails clientInfo) {
            WebAppCliente.ServiceReferenceCliente.UpdateClientDetailsRequest inValue = new WebAppCliente.ServiceReferenceCliente.UpdateClientDetailsRequest();
            inValue.clientInfo = clientInfo;
            WebAppCliente.ServiceReferenceCliente.UpdateClientDetailsResponse retVal = ((WebAppCliente.ServiceReferenceCliente.IServiceCliente)(this)).UpdateClientDetails(inValue);
            return retVal.UpdateClientDetailsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebAppCliente.ServiceReferenceCliente.UpdateClientDetailsResponse> WebAppCliente.ServiceReferenceCliente.IServiceCliente.UpdateClientDetailsAsync(WebAppCliente.ServiceReferenceCliente.UpdateClientDetailsRequest request) {
            return base.Channel.UpdateClientDetailsAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebAppCliente.ServiceReferenceCliente.UpdateClientDetailsResponse> UpdateClientDetailsAsync(WebAppCliente.ServiceReferenceCliente.ClientDetails clientInfo) {
            WebAppCliente.ServiceReferenceCliente.UpdateClientDetailsRequest inValue = new WebAppCliente.ServiceReferenceCliente.UpdateClientDetailsRequest();
            inValue.clientInfo = clientInfo;
            return ((WebAppCliente.ServiceReferenceCliente.IServiceCliente)(this)).UpdateClientDetailsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebAppCliente.ServiceReferenceCliente.UpdateRegistrationTableResponse WebAppCliente.ServiceReferenceCliente.IServiceCliente.UpdateRegistrationTable(WebAppCliente.ServiceReferenceCliente.UpdateRegistrationTableRequest request) {
            return base.Channel.UpdateRegistrationTable(request);
        }
        
        public void UpdateRegistrationTable(WebAppCliente.ServiceReferenceCliente.ClientDetails clientInfo) {
            WebAppCliente.ServiceReferenceCliente.UpdateRegistrationTableRequest inValue = new WebAppCliente.ServiceReferenceCliente.UpdateRegistrationTableRequest();
            inValue.clientInfo = clientInfo;
            WebAppCliente.ServiceReferenceCliente.UpdateRegistrationTableResponse retVal = ((WebAppCliente.ServiceReferenceCliente.IServiceCliente)(this)).UpdateRegistrationTable(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebAppCliente.ServiceReferenceCliente.UpdateRegistrationTableResponse> WebAppCliente.ServiceReferenceCliente.IServiceCliente.UpdateRegistrationTableAsync(WebAppCliente.ServiceReferenceCliente.UpdateRegistrationTableRequest request) {
            return base.Channel.UpdateRegistrationTableAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebAppCliente.ServiceReferenceCliente.UpdateRegistrationTableResponse> UpdateRegistrationTableAsync(WebAppCliente.ServiceReferenceCliente.ClientDetails clientInfo) {
            WebAppCliente.ServiceReferenceCliente.UpdateRegistrationTableRequest inValue = new WebAppCliente.ServiceReferenceCliente.UpdateRegistrationTableRequest();
            inValue.clientInfo = clientInfo;
            return ((WebAppCliente.ServiceReferenceCliente.IServiceCliente)(this)).UpdateRegistrationTableAsync(inValue);
        }
    }
}
