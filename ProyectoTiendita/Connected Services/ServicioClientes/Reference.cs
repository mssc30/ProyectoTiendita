﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoTiendita.ServicioClientes {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string apellidosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string direccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string telefonoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string contrasenaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string apellidos {
            get {
                return this.apellidosField;
            }
            set {
                if ((object.ReferenceEquals(this.apellidosField, value) != true)) {
                    this.apellidosField = value;
                    this.RaisePropertyChanged("apellidos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string direccion {
            get {
                return this.direccionField;
            }
            set {
                if ((object.ReferenceEquals(this.direccionField, value) != true)) {
                    this.direccionField = value;
                    this.RaisePropertyChanged("direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string telefono {
            get {
                return this.telefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.telefonoField, value) != true)) {
                    this.telefonoField = value;
                    this.RaisePropertyChanged("telefono");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string contrasena {
            get {
                return this.contrasenaField;
            }
            set {
                if ((object.ReferenceEquals(this.contrasenaField, value) != true)) {
                    this.contrasenaField = value;
                    this.RaisePropertyChanged("contrasena");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioClientes.ServicioClienteSoap")]
    public interface ServicioClienteSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento ObtenerTodosResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerTodos", ReplyAction="*")]
        ProyectoTiendita.ServicioClientes.ObtenerTodosResponse ObtenerTodos(ProyectoTiendita.ServicioClientes.ObtenerTodosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerTodos", ReplyAction="*")]
        System.Threading.Tasks.Task<ProyectoTiendita.ServicioClientes.ObtenerTodosResponse> ObtenerTodosAsync(ProyectoTiendita.ServicioClientes.ObtenerTodosRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento idCliente del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerUno", ReplyAction="*")]
        ProyectoTiendita.ServicioClientes.ObtenerUnoResponse ObtenerUno(ProyectoTiendita.ServicioClientes.ObtenerUnoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerUno", ReplyAction="*")]
        System.Threading.Tasks.Task<ProyectoTiendita.ServicioClientes.ObtenerUnoResponse> ObtenerUnoAsync(ProyectoTiendita.ServicioClientes.ObtenerUnoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento prod del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarCliente", ReplyAction="*")]
        ProyectoTiendita.ServicioClientes.AgregarClienteResponse AgregarCliente(ProyectoTiendita.ServicioClientes.AgregarClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarCliente", ReplyAction="*")]
        System.Threading.Tasks.Task<ProyectoTiendita.ServicioClientes.AgregarClienteResponse> AgregarClienteAsync(ProyectoTiendita.ServicioClientes.AgregarClienteRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento prod del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ModificarCliente", ReplyAction="*")]
        ProyectoTiendita.ServicioClientes.ModificarClienteResponse ModificarCliente(ProyectoTiendita.ServicioClientes.ModificarClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ModificarCliente", ReplyAction="*")]
        System.Threading.Tasks.Task<ProyectoTiendita.ServicioClientes.ModificarClienteResponse> ModificarClienteAsync(ProyectoTiendita.ServicioClientes.ModificarClienteRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento idCliente del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarCliente", ReplyAction="*")]
        ProyectoTiendita.ServicioClientes.EliminarClienteResponse EliminarCliente(ProyectoTiendita.ServicioClientes.EliminarClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarCliente", ReplyAction="*")]
        System.Threading.Tasks.Task<ProyectoTiendita.ServicioClientes.EliminarClienteResponse> EliminarClienteAsync(ProyectoTiendita.ServicioClientes.EliminarClienteRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerTodosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerTodos", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServicioClientes.ObtenerTodosRequestBody Body;
        
        public ObtenerTodosRequest() {
        }
        
        public ObtenerTodosRequest(ProyectoTiendita.ServicioClientes.ObtenerTodosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ObtenerTodosRequestBody {
        
        public ObtenerTodosRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerTodosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerTodosResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServicioClientes.ObtenerTodosResponseBody Body;
        
        public ObtenerTodosResponse() {
        }
        
        public ObtenerTodosResponse(ProyectoTiendita.ServicioClientes.ObtenerTodosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerTodosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ProyectoTiendita.ServicioClientes.Cliente[] ObtenerTodosResult;
        
        public ObtenerTodosResponseBody() {
        }
        
        public ObtenerTodosResponseBody(ProyectoTiendita.ServicioClientes.Cliente[] ObtenerTodosResult) {
            this.ObtenerTodosResult = ObtenerTodosResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerUnoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerUno", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServicioClientes.ObtenerUnoRequestBody Body;
        
        public ObtenerUnoRequest() {
        }
        
        public ObtenerUnoRequest(ProyectoTiendita.ServicioClientes.ObtenerUnoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerUnoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string idCliente;
        
        public ObtenerUnoRequestBody() {
        }
        
        public ObtenerUnoRequestBody(string idCliente) {
            this.idCliente = idCliente;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerUnoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerUnoResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServicioClientes.ObtenerUnoResponseBody Body;
        
        public ObtenerUnoResponse() {
        }
        
        public ObtenerUnoResponse(ProyectoTiendita.ServicioClientes.ObtenerUnoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerUnoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ProyectoTiendita.ServicioClientes.Cliente ObtenerUnoResult;
        
        public ObtenerUnoResponseBody() {
        }
        
        public ObtenerUnoResponseBody(ProyectoTiendita.ServicioClientes.Cliente ObtenerUnoResult) {
            this.ObtenerUnoResult = ObtenerUnoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarCliente", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServicioClientes.AgregarClienteRequestBody Body;
        
        public AgregarClienteRequest() {
        }
        
        public AgregarClienteRequest(ProyectoTiendita.ServicioClientes.AgregarClienteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarClienteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ProyectoTiendita.ServicioClientes.Cliente prod;
        
        public AgregarClienteRequestBody() {
        }
        
        public AgregarClienteRequestBody(ProyectoTiendita.ServicioClientes.Cliente prod) {
            this.prod = prod;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarClienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarClienteResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServicioClientes.AgregarClienteResponseBody Body;
        
        public AgregarClienteResponse() {
        }
        
        public AgregarClienteResponse(ProyectoTiendita.ServicioClientes.AgregarClienteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarClienteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool AgregarClienteResult;
        
        public AgregarClienteResponseBody() {
        }
        
        public AgregarClienteResponseBody(bool AgregarClienteResult) {
            this.AgregarClienteResult = AgregarClienteResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ModificarClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ModificarCliente", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServicioClientes.ModificarClienteRequestBody Body;
        
        public ModificarClienteRequest() {
        }
        
        public ModificarClienteRequest(ProyectoTiendita.ServicioClientes.ModificarClienteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ModificarClienteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ProyectoTiendita.ServicioClientes.Cliente prod;
        
        public ModificarClienteRequestBody() {
        }
        
        public ModificarClienteRequestBody(ProyectoTiendita.ServicioClientes.Cliente prod) {
            this.prod = prod;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ModificarClienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ModificarClienteResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServicioClientes.ModificarClienteResponseBody Body;
        
        public ModificarClienteResponse() {
        }
        
        public ModificarClienteResponse(ProyectoTiendita.ServicioClientes.ModificarClienteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ModificarClienteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool ModificarClienteResult;
        
        public ModificarClienteResponseBody() {
        }
        
        public ModificarClienteResponseBody(bool ModificarClienteResult) {
            this.ModificarClienteResult = ModificarClienteResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EliminarClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EliminarCliente", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServicioClientes.EliminarClienteRequestBody Body;
        
        public EliminarClienteRequest() {
        }
        
        public EliminarClienteRequest(ProyectoTiendita.ServicioClientes.EliminarClienteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EliminarClienteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string idCliente;
        
        public EliminarClienteRequestBody() {
        }
        
        public EliminarClienteRequestBody(string idCliente) {
            this.idCliente = idCliente;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EliminarClienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EliminarClienteResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServicioClientes.EliminarClienteResponseBody Body;
        
        public EliminarClienteResponse() {
        }
        
        public EliminarClienteResponse(ProyectoTiendita.ServicioClientes.EliminarClienteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EliminarClienteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool EliminarClienteResult;
        
        public EliminarClienteResponseBody() {
        }
        
        public EliminarClienteResponseBody(bool EliminarClienteResult) {
            this.EliminarClienteResult = EliminarClienteResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicioClienteSoapChannel : ProyectoTiendita.ServicioClientes.ServicioClienteSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioClienteSoapClient : System.ServiceModel.ClientBase<ProyectoTiendita.ServicioClientes.ServicioClienteSoap>, ProyectoTiendita.ServicioClientes.ServicioClienteSoap {
        
        public ServicioClienteSoapClient() {
        }
        
        public ServicioClienteSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioClienteSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioClienteSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioClienteSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoTiendita.ServicioClientes.ObtenerTodosResponse ProyectoTiendita.ServicioClientes.ServicioClienteSoap.ObtenerTodos(ProyectoTiendita.ServicioClientes.ObtenerTodosRequest request) {
            return base.Channel.ObtenerTodos(request);
        }
        
        public ProyectoTiendita.ServicioClientes.Cliente[] ObtenerTodos() {
            ProyectoTiendita.ServicioClientes.ObtenerTodosRequest inValue = new ProyectoTiendita.ServicioClientes.ObtenerTodosRequest();
            inValue.Body = new ProyectoTiendita.ServicioClientes.ObtenerTodosRequestBody();
            ProyectoTiendita.ServicioClientes.ObtenerTodosResponse retVal = ((ProyectoTiendita.ServicioClientes.ServicioClienteSoap)(this)).ObtenerTodos(inValue);
            return retVal.Body.ObtenerTodosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoTiendita.ServicioClientes.ObtenerTodosResponse> ProyectoTiendita.ServicioClientes.ServicioClienteSoap.ObtenerTodosAsync(ProyectoTiendita.ServicioClientes.ObtenerTodosRequest request) {
            return base.Channel.ObtenerTodosAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoTiendita.ServicioClientes.ObtenerTodosResponse> ObtenerTodosAsync() {
            ProyectoTiendita.ServicioClientes.ObtenerTodosRequest inValue = new ProyectoTiendita.ServicioClientes.ObtenerTodosRequest();
            inValue.Body = new ProyectoTiendita.ServicioClientes.ObtenerTodosRequestBody();
            return ((ProyectoTiendita.ServicioClientes.ServicioClienteSoap)(this)).ObtenerTodosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoTiendita.ServicioClientes.ObtenerUnoResponse ProyectoTiendita.ServicioClientes.ServicioClienteSoap.ObtenerUno(ProyectoTiendita.ServicioClientes.ObtenerUnoRequest request) {
            return base.Channel.ObtenerUno(request);
        }
        
        public ProyectoTiendita.ServicioClientes.Cliente ObtenerUno(string idCliente) {
            ProyectoTiendita.ServicioClientes.ObtenerUnoRequest inValue = new ProyectoTiendita.ServicioClientes.ObtenerUnoRequest();
            inValue.Body = new ProyectoTiendita.ServicioClientes.ObtenerUnoRequestBody();
            inValue.Body.idCliente = idCliente;
            ProyectoTiendita.ServicioClientes.ObtenerUnoResponse retVal = ((ProyectoTiendita.ServicioClientes.ServicioClienteSoap)(this)).ObtenerUno(inValue);
            return retVal.Body.ObtenerUnoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoTiendita.ServicioClientes.ObtenerUnoResponse> ProyectoTiendita.ServicioClientes.ServicioClienteSoap.ObtenerUnoAsync(ProyectoTiendita.ServicioClientes.ObtenerUnoRequest request) {
            return base.Channel.ObtenerUnoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoTiendita.ServicioClientes.ObtenerUnoResponse> ObtenerUnoAsync(string idCliente) {
            ProyectoTiendita.ServicioClientes.ObtenerUnoRequest inValue = new ProyectoTiendita.ServicioClientes.ObtenerUnoRequest();
            inValue.Body = new ProyectoTiendita.ServicioClientes.ObtenerUnoRequestBody();
            inValue.Body.idCliente = idCliente;
            return ((ProyectoTiendita.ServicioClientes.ServicioClienteSoap)(this)).ObtenerUnoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoTiendita.ServicioClientes.AgregarClienteResponse ProyectoTiendita.ServicioClientes.ServicioClienteSoap.AgregarCliente(ProyectoTiendita.ServicioClientes.AgregarClienteRequest request) {
            return base.Channel.AgregarCliente(request);
        }
        
        public bool AgregarCliente(ProyectoTiendita.ServicioClientes.Cliente prod) {
            ProyectoTiendita.ServicioClientes.AgregarClienteRequest inValue = new ProyectoTiendita.ServicioClientes.AgregarClienteRequest();
            inValue.Body = new ProyectoTiendita.ServicioClientes.AgregarClienteRequestBody();
            inValue.Body.prod = prod;
            ProyectoTiendita.ServicioClientes.AgregarClienteResponse retVal = ((ProyectoTiendita.ServicioClientes.ServicioClienteSoap)(this)).AgregarCliente(inValue);
            return retVal.Body.AgregarClienteResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoTiendita.ServicioClientes.AgregarClienteResponse> ProyectoTiendita.ServicioClientes.ServicioClienteSoap.AgregarClienteAsync(ProyectoTiendita.ServicioClientes.AgregarClienteRequest request) {
            return base.Channel.AgregarClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoTiendita.ServicioClientes.AgregarClienteResponse> AgregarClienteAsync(ProyectoTiendita.ServicioClientes.Cliente prod) {
            ProyectoTiendita.ServicioClientes.AgregarClienteRequest inValue = new ProyectoTiendita.ServicioClientes.AgregarClienteRequest();
            inValue.Body = new ProyectoTiendita.ServicioClientes.AgregarClienteRequestBody();
            inValue.Body.prod = prod;
            return ((ProyectoTiendita.ServicioClientes.ServicioClienteSoap)(this)).AgregarClienteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoTiendita.ServicioClientes.ModificarClienteResponse ProyectoTiendita.ServicioClientes.ServicioClienteSoap.ModificarCliente(ProyectoTiendita.ServicioClientes.ModificarClienteRequest request) {
            return base.Channel.ModificarCliente(request);
        }
        
        public bool ModificarCliente(ProyectoTiendita.ServicioClientes.Cliente prod) {
            ProyectoTiendita.ServicioClientes.ModificarClienteRequest inValue = new ProyectoTiendita.ServicioClientes.ModificarClienteRequest();
            inValue.Body = new ProyectoTiendita.ServicioClientes.ModificarClienteRequestBody();
            inValue.Body.prod = prod;
            ProyectoTiendita.ServicioClientes.ModificarClienteResponse retVal = ((ProyectoTiendita.ServicioClientes.ServicioClienteSoap)(this)).ModificarCliente(inValue);
            return retVal.Body.ModificarClienteResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoTiendita.ServicioClientes.ModificarClienteResponse> ProyectoTiendita.ServicioClientes.ServicioClienteSoap.ModificarClienteAsync(ProyectoTiendita.ServicioClientes.ModificarClienteRequest request) {
            return base.Channel.ModificarClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoTiendita.ServicioClientes.ModificarClienteResponse> ModificarClienteAsync(ProyectoTiendita.ServicioClientes.Cliente prod) {
            ProyectoTiendita.ServicioClientes.ModificarClienteRequest inValue = new ProyectoTiendita.ServicioClientes.ModificarClienteRequest();
            inValue.Body = new ProyectoTiendita.ServicioClientes.ModificarClienteRequestBody();
            inValue.Body.prod = prod;
            return ((ProyectoTiendita.ServicioClientes.ServicioClienteSoap)(this)).ModificarClienteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoTiendita.ServicioClientes.EliminarClienteResponse ProyectoTiendita.ServicioClientes.ServicioClienteSoap.EliminarCliente(ProyectoTiendita.ServicioClientes.EliminarClienteRequest request) {
            return base.Channel.EliminarCliente(request);
        }
        
        public bool EliminarCliente(string idCliente) {
            ProyectoTiendita.ServicioClientes.EliminarClienteRequest inValue = new ProyectoTiendita.ServicioClientes.EliminarClienteRequest();
            inValue.Body = new ProyectoTiendita.ServicioClientes.EliminarClienteRequestBody();
            inValue.Body.idCliente = idCliente;
            ProyectoTiendita.ServicioClientes.EliminarClienteResponse retVal = ((ProyectoTiendita.ServicioClientes.ServicioClienteSoap)(this)).EliminarCliente(inValue);
            return retVal.Body.EliminarClienteResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoTiendita.ServicioClientes.EliminarClienteResponse> ProyectoTiendita.ServicioClientes.ServicioClienteSoap.EliminarClienteAsync(ProyectoTiendita.ServicioClientes.EliminarClienteRequest request) {
            return base.Channel.EliminarClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoTiendita.ServicioClientes.EliminarClienteResponse> EliminarClienteAsync(string idCliente) {
            ProyectoTiendita.ServicioClientes.EliminarClienteRequest inValue = new ProyectoTiendita.ServicioClientes.EliminarClienteRequest();
            inValue.Body = new ProyectoTiendita.ServicioClientes.EliminarClienteRequestBody();
            inValue.Body.idCliente = idCliente;
            return ((ProyectoTiendita.ServicioClientes.ServicioClienteSoap)(this)).EliminarClienteAsync(inValue);
        }
    }
}