﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoTiendita.ServicioUsuarios {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Usuario", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Usuario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string contrasenaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string apellidosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string telefonoField;
        
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
        public string usuario {
            get {
                return this.usuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.usuarioField, value) != true)) {
                    this.usuarioField = value;
                    this.RaisePropertyChanged("usuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioUsuarios.ServicioUsuarioSoap")]
    public interface ServicioUsuarioSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento ObtenerTodosResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerTodos", ReplyAction="*")]
        ProyectoTiendita.ServicioUsuarios.ObtenerTodosResponse ObtenerTodos(ProyectoTiendita.ServicioUsuarios.ObtenerTodosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerTodos", ReplyAction="*")]
        System.Threading.Tasks.Task<ProyectoTiendita.ServicioUsuarios.ObtenerTodosResponse> ObtenerTodosAsync(ProyectoTiendita.ServicioUsuarios.ObtenerTodosRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento idUser del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerUno", ReplyAction="*")]
        ProyectoTiendita.ServicioUsuarios.ObtenerUnoResponse ObtenerUno(ProyectoTiendita.ServicioUsuarios.ObtenerUnoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerUno", ReplyAction="*")]
        System.Threading.Tasks.Task<ProyectoTiendita.ServicioUsuarios.ObtenerUnoResponse> ObtenerUnoAsync(ProyectoTiendita.ServicioUsuarios.ObtenerUnoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento prod del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarUsuario", ReplyAction="*")]
        ProyectoTiendita.ServicioUsuarios.AgregarUsuarioResponse AgregarUsuario(ProyectoTiendita.ServicioUsuarios.AgregarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task<ProyectoTiendita.ServicioUsuarios.AgregarUsuarioResponse> AgregarUsuarioAsync(ProyectoTiendita.ServicioUsuarios.AgregarUsuarioRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento prod del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ModificarUsuario", ReplyAction="*")]
        ProyectoTiendita.ServicioUsuarios.ModificarUsuarioResponse ModificarUsuario(ProyectoTiendita.ServicioUsuarios.ModificarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ModificarUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task<ProyectoTiendita.ServicioUsuarios.ModificarUsuarioResponse> ModificarUsuarioAsync(ProyectoTiendita.ServicioUsuarios.ModificarUsuarioRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento idUser del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarUsuario", ReplyAction="*")]
        ProyectoTiendita.ServicioUsuarios.EliminarUsuarioResponse EliminarUsuario(ProyectoTiendita.ServicioUsuarios.EliminarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task<ProyectoTiendita.ServicioUsuarios.EliminarUsuarioResponse> EliminarUsuarioAsync(ProyectoTiendita.ServicioUsuarios.EliminarUsuarioRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerTodosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerTodos", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServicioUsuarios.ObtenerTodosRequestBody Body;
        
        public ObtenerTodosRequest() {
        }
        
        public ObtenerTodosRequest(ProyectoTiendita.ServicioUsuarios.ObtenerTodosRequestBody Body) {
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
        public ProyectoTiendita.ServicioUsuarios.ObtenerTodosResponseBody Body;
        
        public ObtenerTodosResponse() {
        }
        
        public ObtenerTodosResponse(ProyectoTiendita.ServicioUsuarios.ObtenerTodosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerTodosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ProyectoTiendita.ServicioUsuarios.Usuario[] ObtenerTodosResult;
        
        public ObtenerTodosResponseBody() {
        }
        
        public ObtenerTodosResponseBody(ProyectoTiendita.ServicioUsuarios.Usuario[] ObtenerTodosResult) {
            this.ObtenerTodosResult = ObtenerTodosResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerUnoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerUno", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServicioUsuarios.ObtenerUnoRequestBody Body;
        
        public ObtenerUnoRequest() {
        }
        
        public ObtenerUnoRequest(ProyectoTiendita.ServicioUsuarios.ObtenerUnoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerUnoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string idUser;
        
        public ObtenerUnoRequestBody() {
        }
        
        public ObtenerUnoRequestBody(string idUser) {
            this.idUser = idUser;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerUnoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerUnoResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServicioUsuarios.ObtenerUnoResponseBody Body;
        
        public ObtenerUnoResponse() {
        }
        
        public ObtenerUnoResponse(ProyectoTiendita.ServicioUsuarios.ObtenerUnoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerUnoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ProyectoTiendita.ServicioUsuarios.Usuario ObtenerUnoResult;
        
        public ObtenerUnoResponseBody() {
        }
        
        public ObtenerUnoResponseBody(ProyectoTiendita.ServicioUsuarios.Usuario ObtenerUnoResult) {
            this.ObtenerUnoResult = ObtenerUnoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarUsuario", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServicioUsuarios.AgregarUsuarioRequestBody Body;
        
        public AgregarUsuarioRequest() {
        }
        
        public AgregarUsuarioRequest(ProyectoTiendita.ServicioUsuarios.AgregarUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ProyectoTiendita.ServicioUsuarios.Usuario prod;
        
        public AgregarUsuarioRequestBody() {
        }
        
        public AgregarUsuarioRequestBody(ProyectoTiendita.ServicioUsuarios.Usuario prod) {
            this.prod = prod;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarUsuarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServicioUsuarios.AgregarUsuarioResponseBody Body;
        
        public AgregarUsuarioResponse() {
        }
        
        public AgregarUsuarioResponse(ProyectoTiendita.ServicioUsuarios.AgregarUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool AgregarUsuarioResult;
        
        public AgregarUsuarioResponseBody() {
        }
        
        public AgregarUsuarioResponseBody(bool AgregarUsuarioResult) {
            this.AgregarUsuarioResult = AgregarUsuarioResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ModificarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ModificarUsuario", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServicioUsuarios.ModificarUsuarioRequestBody Body;
        
        public ModificarUsuarioRequest() {
        }
        
        public ModificarUsuarioRequest(ProyectoTiendita.ServicioUsuarios.ModificarUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ModificarUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ProyectoTiendita.ServicioUsuarios.Usuario prod;
        
        public ModificarUsuarioRequestBody() {
        }
        
        public ModificarUsuarioRequestBody(ProyectoTiendita.ServicioUsuarios.Usuario prod) {
            this.prod = prod;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ModificarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ModificarUsuarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServicioUsuarios.ModificarUsuarioResponseBody Body;
        
        public ModificarUsuarioResponse() {
        }
        
        public ModificarUsuarioResponse(ProyectoTiendita.ServicioUsuarios.ModificarUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ModificarUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool ModificarUsuarioResult;
        
        public ModificarUsuarioResponseBody() {
        }
        
        public ModificarUsuarioResponseBody(bool ModificarUsuarioResult) {
            this.ModificarUsuarioResult = ModificarUsuarioResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EliminarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EliminarUsuario", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServicioUsuarios.EliminarUsuarioRequestBody Body;
        
        public EliminarUsuarioRequest() {
        }
        
        public EliminarUsuarioRequest(ProyectoTiendita.ServicioUsuarios.EliminarUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EliminarUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string idUser;
        
        public EliminarUsuarioRequestBody() {
        }
        
        public EliminarUsuarioRequestBody(string idUser) {
            this.idUser = idUser;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EliminarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EliminarUsuarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServicioUsuarios.EliminarUsuarioResponseBody Body;
        
        public EliminarUsuarioResponse() {
        }
        
        public EliminarUsuarioResponse(ProyectoTiendita.ServicioUsuarios.EliminarUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EliminarUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool EliminarUsuarioResult;
        
        public EliminarUsuarioResponseBody() {
        }
        
        public EliminarUsuarioResponseBody(bool EliminarUsuarioResult) {
            this.EliminarUsuarioResult = EliminarUsuarioResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicioUsuarioSoapChannel : ProyectoTiendita.ServicioUsuarios.ServicioUsuarioSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioUsuarioSoapClient : System.ServiceModel.ClientBase<ProyectoTiendita.ServicioUsuarios.ServicioUsuarioSoap>, ProyectoTiendita.ServicioUsuarios.ServicioUsuarioSoap {
        
        public ServicioUsuarioSoapClient() {
        }
        
        public ServicioUsuarioSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioUsuarioSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioUsuarioSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioUsuarioSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoTiendita.ServicioUsuarios.ObtenerTodosResponse ProyectoTiendita.ServicioUsuarios.ServicioUsuarioSoap.ObtenerTodos(ProyectoTiendita.ServicioUsuarios.ObtenerTodosRequest request) {
            return base.Channel.ObtenerTodos(request);
        }
        
        public ProyectoTiendita.ServicioUsuarios.Usuario[] ObtenerTodos() {
            ProyectoTiendita.ServicioUsuarios.ObtenerTodosRequest inValue = new ProyectoTiendita.ServicioUsuarios.ObtenerTodosRequest();
            inValue.Body = new ProyectoTiendita.ServicioUsuarios.ObtenerTodosRequestBody();
            ProyectoTiendita.ServicioUsuarios.ObtenerTodosResponse retVal = ((ProyectoTiendita.ServicioUsuarios.ServicioUsuarioSoap)(this)).ObtenerTodos(inValue);
            return retVal.Body.ObtenerTodosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoTiendita.ServicioUsuarios.ObtenerTodosResponse> ProyectoTiendita.ServicioUsuarios.ServicioUsuarioSoap.ObtenerTodosAsync(ProyectoTiendita.ServicioUsuarios.ObtenerTodosRequest request) {
            return base.Channel.ObtenerTodosAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoTiendita.ServicioUsuarios.ObtenerTodosResponse> ObtenerTodosAsync() {
            ProyectoTiendita.ServicioUsuarios.ObtenerTodosRequest inValue = new ProyectoTiendita.ServicioUsuarios.ObtenerTodosRequest();
            inValue.Body = new ProyectoTiendita.ServicioUsuarios.ObtenerTodosRequestBody();
            return ((ProyectoTiendita.ServicioUsuarios.ServicioUsuarioSoap)(this)).ObtenerTodosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoTiendita.ServicioUsuarios.ObtenerUnoResponse ProyectoTiendita.ServicioUsuarios.ServicioUsuarioSoap.ObtenerUno(ProyectoTiendita.ServicioUsuarios.ObtenerUnoRequest request) {
            return base.Channel.ObtenerUno(request);
        }
        
        public ProyectoTiendita.ServicioUsuarios.Usuario ObtenerUno(string idUser) {
            ProyectoTiendita.ServicioUsuarios.ObtenerUnoRequest inValue = new ProyectoTiendita.ServicioUsuarios.ObtenerUnoRequest();
            inValue.Body = new ProyectoTiendita.ServicioUsuarios.ObtenerUnoRequestBody();
            inValue.Body.idUser = idUser;
            ProyectoTiendita.ServicioUsuarios.ObtenerUnoResponse retVal = ((ProyectoTiendita.ServicioUsuarios.ServicioUsuarioSoap)(this)).ObtenerUno(inValue);
            return retVal.Body.ObtenerUnoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoTiendita.ServicioUsuarios.ObtenerUnoResponse> ProyectoTiendita.ServicioUsuarios.ServicioUsuarioSoap.ObtenerUnoAsync(ProyectoTiendita.ServicioUsuarios.ObtenerUnoRequest request) {
            return base.Channel.ObtenerUnoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoTiendita.ServicioUsuarios.ObtenerUnoResponse> ObtenerUnoAsync(string idUser) {
            ProyectoTiendita.ServicioUsuarios.ObtenerUnoRequest inValue = new ProyectoTiendita.ServicioUsuarios.ObtenerUnoRequest();
            inValue.Body = new ProyectoTiendita.ServicioUsuarios.ObtenerUnoRequestBody();
            inValue.Body.idUser = idUser;
            return ((ProyectoTiendita.ServicioUsuarios.ServicioUsuarioSoap)(this)).ObtenerUnoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoTiendita.ServicioUsuarios.AgregarUsuarioResponse ProyectoTiendita.ServicioUsuarios.ServicioUsuarioSoap.AgregarUsuario(ProyectoTiendita.ServicioUsuarios.AgregarUsuarioRequest request) {
            return base.Channel.AgregarUsuario(request);
        }
        
        public bool AgregarUsuario(ProyectoTiendita.ServicioUsuarios.Usuario prod) {
            ProyectoTiendita.ServicioUsuarios.AgregarUsuarioRequest inValue = new ProyectoTiendita.ServicioUsuarios.AgregarUsuarioRequest();
            inValue.Body = new ProyectoTiendita.ServicioUsuarios.AgregarUsuarioRequestBody();
            inValue.Body.prod = prod;
            ProyectoTiendita.ServicioUsuarios.AgregarUsuarioResponse retVal = ((ProyectoTiendita.ServicioUsuarios.ServicioUsuarioSoap)(this)).AgregarUsuario(inValue);
            return retVal.Body.AgregarUsuarioResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoTiendita.ServicioUsuarios.AgregarUsuarioResponse> ProyectoTiendita.ServicioUsuarios.ServicioUsuarioSoap.AgregarUsuarioAsync(ProyectoTiendita.ServicioUsuarios.AgregarUsuarioRequest request) {
            return base.Channel.AgregarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoTiendita.ServicioUsuarios.AgregarUsuarioResponse> AgregarUsuarioAsync(ProyectoTiendita.ServicioUsuarios.Usuario prod) {
            ProyectoTiendita.ServicioUsuarios.AgregarUsuarioRequest inValue = new ProyectoTiendita.ServicioUsuarios.AgregarUsuarioRequest();
            inValue.Body = new ProyectoTiendita.ServicioUsuarios.AgregarUsuarioRequestBody();
            inValue.Body.prod = prod;
            return ((ProyectoTiendita.ServicioUsuarios.ServicioUsuarioSoap)(this)).AgregarUsuarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoTiendita.ServicioUsuarios.ModificarUsuarioResponse ProyectoTiendita.ServicioUsuarios.ServicioUsuarioSoap.ModificarUsuario(ProyectoTiendita.ServicioUsuarios.ModificarUsuarioRequest request) {
            return base.Channel.ModificarUsuario(request);
        }
        
        public bool ModificarUsuario(ProyectoTiendita.ServicioUsuarios.Usuario prod) {
            ProyectoTiendita.ServicioUsuarios.ModificarUsuarioRequest inValue = new ProyectoTiendita.ServicioUsuarios.ModificarUsuarioRequest();
            inValue.Body = new ProyectoTiendita.ServicioUsuarios.ModificarUsuarioRequestBody();
            inValue.Body.prod = prod;
            ProyectoTiendita.ServicioUsuarios.ModificarUsuarioResponse retVal = ((ProyectoTiendita.ServicioUsuarios.ServicioUsuarioSoap)(this)).ModificarUsuario(inValue);
            return retVal.Body.ModificarUsuarioResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoTiendita.ServicioUsuarios.ModificarUsuarioResponse> ProyectoTiendita.ServicioUsuarios.ServicioUsuarioSoap.ModificarUsuarioAsync(ProyectoTiendita.ServicioUsuarios.ModificarUsuarioRequest request) {
            return base.Channel.ModificarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoTiendita.ServicioUsuarios.ModificarUsuarioResponse> ModificarUsuarioAsync(ProyectoTiendita.ServicioUsuarios.Usuario prod) {
            ProyectoTiendita.ServicioUsuarios.ModificarUsuarioRequest inValue = new ProyectoTiendita.ServicioUsuarios.ModificarUsuarioRequest();
            inValue.Body = new ProyectoTiendita.ServicioUsuarios.ModificarUsuarioRequestBody();
            inValue.Body.prod = prod;
            return ((ProyectoTiendita.ServicioUsuarios.ServicioUsuarioSoap)(this)).ModificarUsuarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoTiendita.ServicioUsuarios.EliminarUsuarioResponse ProyectoTiendita.ServicioUsuarios.ServicioUsuarioSoap.EliminarUsuario(ProyectoTiendita.ServicioUsuarios.EliminarUsuarioRequest request) {
            return base.Channel.EliminarUsuario(request);
        }
        
        public bool EliminarUsuario(string idUser) {
            ProyectoTiendita.ServicioUsuarios.EliminarUsuarioRequest inValue = new ProyectoTiendita.ServicioUsuarios.EliminarUsuarioRequest();
            inValue.Body = new ProyectoTiendita.ServicioUsuarios.EliminarUsuarioRequestBody();
            inValue.Body.idUser = idUser;
            ProyectoTiendita.ServicioUsuarios.EliminarUsuarioResponse retVal = ((ProyectoTiendita.ServicioUsuarios.ServicioUsuarioSoap)(this)).EliminarUsuario(inValue);
            return retVal.Body.EliminarUsuarioResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoTiendita.ServicioUsuarios.EliminarUsuarioResponse> ProyectoTiendita.ServicioUsuarios.ServicioUsuarioSoap.EliminarUsuarioAsync(ProyectoTiendita.ServicioUsuarios.EliminarUsuarioRequest request) {
            return base.Channel.EliminarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoTiendita.ServicioUsuarios.EliminarUsuarioResponse> EliminarUsuarioAsync(string idUser) {
            ProyectoTiendita.ServicioUsuarios.EliminarUsuarioRequest inValue = new ProyectoTiendita.ServicioUsuarios.EliminarUsuarioRequest();
            inValue.Body = new ProyectoTiendita.ServicioUsuarios.EliminarUsuarioRequestBody();
            inValue.Body.idUser = idUser;
            return ((ProyectoTiendita.ServicioUsuarios.ServicioUsuarioSoap)(this)).EliminarUsuarioAsync(inValue);
        }
    }
}
