﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoTiendita.ServiceReference3 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Producto", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Producto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int idProductoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        private double precioField;
        
        private int estadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string fotoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int idProducto {
            get {
                return this.idProductoField;
            }
            set {
                if ((this.idProductoField.Equals(value) != true)) {
                    this.idProductoField = value;
                    this.RaisePropertyChanged("idProducto");
                }
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public double precio {
            get {
                return this.precioField;
            }
            set {
                if ((this.precioField.Equals(value) != true)) {
                    this.precioField = value;
                    this.RaisePropertyChanged("precio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int estado {
            get {
                return this.estadoField;
            }
            set {
                if ((this.estadoField.Equals(value) != true)) {
                    this.estadoField = value;
                    this.RaisePropertyChanged("estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string foto {
            get {
                return this.fotoField;
            }
            set {
                if ((object.ReferenceEquals(this.fotoField, value) != true)) {
                    this.fotoField = value;
                    this.RaisePropertyChanged("foto");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference3.ServicioProductoSoap")]
    public interface ServicioProductoSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        ProyectoTiendita.ServiceReference3.HelloWorldResponse HelloWorld(ProyectoTiendita.ServiceReference3.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<ProyectoTiendita.ServiceReference3.HelloWorldResponse> HelloWorldAsync(ProyectoTiendita.ServiceReference3.HelloWorldRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento ObtenerTodosResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerTodos", ReplyAction="*")]
        ProyectoTiendita.ServiceReference3.ObtenerTodosResponse ObtenerTodos(ProyectoTiendita.ServiceReference3.ObtenerTodosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerTodos", ReplyAction="*")]
        System.Threading.Tasks.Task<ProyectoTiendita.ServiceReference3.ObtenerTodosResponse> ObtenerTodosAsync(ProyectoTiendita.ServiceReference3.ObtenerTodosRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento ObtenerUnoResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerUno", ReplyAction="*")]
        ProyectoTiendita.ServiceReference3.ObtenerUnoResponse ObtenerUno(ProyectoTiendita.ServiceReference3.ObtenerUnoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerUno", ReplyAction="*")]
        System.Threading.Tasks.Task<ProyectoTiendita.ServiceReference3.ObtenerUnoResponse> ObtenerUnoAsync(ProyectoTiendita.ServiceReference3.ObtenerUnoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento prod del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarProducto", ReplyAction="*")]
        ProyectoTiendita.ServiceReference3.AgregarProductoResponse AgregarProducto(ProyectoTiendita.ServiceReference3.AgregarProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarProducto", ReplyAction="*")]
        System.Threading.Tasks.Task<ProyectoTiendita.ServiceReference3.AgregarProductoResponse> AgregarProductoAsync(ProyectoTiendita.ServiceReference3.AgregarProductoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento prod del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ModificarProducto", ReplyAction="*")]
        ProyectoTiendita.ServiceReference3.ModificarProductoResponse ModificarProducto(ProyectoTiendita.ServiceReference3.ModificarProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ModificarProducto", ReplyAction="*")]
        System.Threading.Tasks.Task<ProyectoTiendita.ServiceReference3.ModificarProductoResponse> ModificarProductoAsync(ProyectoTiendita.ServiceReference3.ModificarProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarProducto", ReplyAction="*")]
        bool EliminarProducto(int idProd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarProducto", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> EliminarProductoAsync(int idProd);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServiceReference3.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(ProyectoTiendita.ServiceReference3.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServiceReference3.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(ProyectoTiendita.ServiceReference3.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerTodosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerTodos", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServiceReference3.ObtenerTodosRequestBody Body;
        
        public ObtenerTodosRequest() {
        }
        
        public ObtenerTodosRequest(ProyectoTiendita.ServiceReference3.ObtenerTodosRequestBody Body) {
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
        public ProyectoTiendita.ServiceReference3.ObtenerTodosResponseBody Body;
        
        public ObtenerTodosResponse() {
        }
        
        public ObtenerTodosResponse(ProyectoTiendita.ServiceReference3.ObtenerTodosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerTodosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ProyectoTiendita.ServiceReference3.Producto[] ObtenerTodosResult;
        
        public ObtenerTodosResponseBody() {
        }
        
        public ObtenerTodosResponseBody(ProyectoTiendita.ServiceReference3.Producto[] ObtenerTodosResult) {
            this.ObtenerTodosResult = ObtenerTodosResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerUnoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerUno", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServiceReference3.ObtenerUnoRequestBody Body;
        
        public ObtenerUnoRequest() {
        }
        
        public ObtenerUnoRequest(ProyectoTiendita.ServiceReference3.ObtenerUnoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerUnoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int idProd;
        
        public ObtenerUnoRequestBody() {
        }
        
        public ObtenerUnoRequestBody(int idProd) {
            this.idProd = idProd;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerUnoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerUnoResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServiceReference3.ObtenerUnoResponseBody Body;
        
        public ObtenerUnoResponse() {
        }
        
        public ObtenerUnoResponse(ProyectoTiendita.ServiceReference3.ObtenerUnoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerUnoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ProyectoTiendita.ServiceReference3.Producto ObtenerUnoResult;
        
        public ObtenerUnoResponseBody() {
        }
        
        public ObtenerUnoResponseBody(ProyectoTiendita.ServiceReference3.Producto ObtenerUnoResult) {
            this.ObtenerUnoResult = ObtenerUnoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarProductoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarProducto", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServiceReference3.AgregarProductoRequestBody Body;
        
        public AgregarProductoRequest() {
        }
        
        public AgregarProductoRequest(ProyectoTiendita.ServiceReference3.AgregarProductoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarProductoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ProyectoTiendita.ServiceReference3.Producto prod;
        
        public AgregarProductoRequestBody() {
        }
        
        public AgregarProductoRequestBody(ProyectoTiendita.ServiceReference3.Producto prod) {
            this.prod = prod;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarProductoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarProductoResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServiceReference3.AgregarProductoResponseBody Body;
        
        public AgregarProductoResponse() {
        }
        
        public AgregarProductoResponse(ProyectoTiendita.ServiceReference3.AgregarProductoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarProductoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool AgregarProductoResult;
        
        public AgregarProductoResponseBody() {
        }
        
        public AgregarProductoResponseBody(bool AgregarProductoResult) {
            this.AgregarProductoResult = AgregarProductoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ModificarProductoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ModificarProducto", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServiceReference3.ModificarProductoRequestBody Body;
        
        public ModificarProductoRequest() {
        }
        
        public ModificarProductoRequest(ProyectoTiendita.ServiceReference3.ModificarProductoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ModificarProductoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ProyectoTiendita.ServiceReference3.Producto prod;
        
        public ModificarProductoRequestBody() {
        }
        
        public ModificarProductoRequestBody(ProyectoTiendita.ServiceReference3.Producto prod) {
            this.prod = prod;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ModificarProductoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ModificarProductoResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTiendita.ServiceReference3.ModificarProductoResponseBody Body;
        
        public ModificarProductoResponse() {
        }
        
        public ModificarProductoResponse(ProyectoTiendita.ServiceReference3.ModificarProductoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ModificarProductoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool ModificarProductoResult;
        
        public ModificarProductoResponseBody() {
        }
        
        public ModificarProductoResponseBody(bool ModificarProductoResult) {
            this.ModificarProductoResult = ModificarProductoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicioProductoSoapChannel : ProyectoTiendita.ServiceReference3.ServicioProductoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioProductoSoapClient : System.ServiceModel.ClientBase<ProyectoTiendita.ServiceReference3.ServicioProductoSoap>, ProyectoTiendita.ServiceReference3.ServicioProductoSoap {
        
        public ServicioProductoSoapClient() {
        }
        
        public ServicioProductoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioProductoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioProductoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioProductoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoTiendita.ServiceReference3.HelloWorldResponse ProyectoTiendita.ServiceReference3.ServicioProductoSoap.HelloWorld(ProyectoTiendita.ServiceReference3.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            ProyectoTiendita.ServiceReference3.HelloWorldRequest inValue = new ProyectoTiendita.ServiceReference3.HelloWorldRequest();
            inValue.Body = new ProyectoTiendita.ServiceReference3.HelloWorldRequestBody();
            ProyectoTiendita.ServiceReference3.HelloWorldResponse retVal = ((ProyectoTiendita.ServiceReference3.ServicioProductoSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoTiendita.ServiceReference3.HelloWorldResponse> ProyectoTiendita.ServiceReference3.ServicioProductoSoap.HelloWorldAsync(ProyectoTiendita.ServiceReference3.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoTiendita.ServiceReference3.HelloWorldResponse> HelloWorldAsync() {
            ProyectoTiendita.ServiceReference3.HelloWorldRequest inValue = new ProyectoTiendita.ServiceReference3.HelloWorldRequest();
            inValue.Body = new ProyectoTiendita.ServiceReference3.HelloWorldRequestBody();
            return ((ProyectoTiendita.ServiceReference3.ServicioProductoSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoTiendita.ServiceReference3.ObtenerTodosResponse ProyectoTiendita.ServiceReference3.ServicioProductoSoap.ObtenerTodos(ProyectoTiendita.ServiceReference3.ObtenerTodosRequest request) {
            return base.Channel.ObtenerTodos(request);
        }
        
        public ProyectoTiendita.ServiceReference3.Producto[] ObtenerTodos() {
            ProyectoTiendita.ServiceReference3.ObtenerTodosRequest inValue = new ProyectoTiendita.ServiceReference3.ObtenerTodosRequest();
            inValue.Body = new ProyectoTiendita.ServiceReference3.ObtenerTodosRequestBody();
            ProyectoTiendita.ServiceReference3.ObtenerTodosResponse retVal = ((ProyectoTiendita.ServiceReference3.ServicioProductoSoap)(this)).ObtenerTodos(inValue);
            return retVal.Body.ObtenerTodosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoTiendita.ServiceReference3.ObtenerTodosResponse> ProyectoTiendita.ServiceReference3.ServicioProductoSoap.ObtenerTodosAsync(ProyectoTiendita.ServiceReference3.ObtenerTodosRequest request) {
            return base.Channel.ObtenerTodosAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoTiendita.ServiceReference3.ObtenerTodosResponse> ObtenerTodosAsync() {
            ProyectoTiendita.ServiceReference3.ObtenerTodosRequest inValue = new ProyectoTiendita.ServiceReference3.ObtenerTodosRequest();
            inValue.Body = new ProyectoTiendita.ServiceReference3.ObtenerTodosRequestBody();
            return ((ProyectoTiendita.ServiceReference3.ServicioProductoSoap)(this)).ObtenerTodosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoTiendita.ServiceReference3.ObtenerUnoResponse ProyectoTiendita.ServiceReference3.ServicioProductoSoap.ObtenerUno(ProyectoTiendita.ServiceReference3.ObtenerUnoRequest request) {
            return base.Channel.ObtenerUno(request);
        }
        
        public ProyectoTiendita.ServiceReference3.Producto ObtenerUno(int idProd) {
            ProyectoTiendita.ServiceReference3.ObtenerUnoRequest inValue = new ProyectoTiendita.ServiceReference3.ObtenerUnoRequest();
            inValue.Body = new ProyectoTiendita.ServiceReference3.ObtenerUnoRequestBody();
            inValue.Body.idProd = idProd;
            ProyectoTiendita.ServiceReference3.ObtenerUnoResponse retVal = ((ProyectoTiendita.ServiceReference3.ServicioProductoSoap)(this)).ObtenerUno(inValue);
            return retVal.Body.ObtenerUnoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoTiendita.ServiceReference3.ObtenerUnoResponse> ProyectoTiendita.ServiceReference3.ServicioProductoSoap.ObtenerUnoAsync(ProyectoTiendita.ServiceReference3.ObtenerUnoRequest request) {
            return base.Channel.ObtenerUnoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoTiendita.ServiceReference3.ObtenerUnoResponse> ObtenerUnoAsync(int idProd) {
            ProyectoTiendita.ServiceReference3.ObtenerUnoRequest inValue = new ProyectoTiendita.ServiceReference3.ObtenerUnoRequest();
            inValue.Body = new ProyectoTiendita.ServiceReference3.ObtenerUnoRequestBody();
            inValue.Body.idProd = idProd;
            return ((ProyectoTiendita.ServiceReference3.ServicioProductoSoap)(this)).ObtenerUnoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoTiendita.ServiceReference3.AgregarProductoResponse ProyectoTiendita.ServiceReference3.ServicioProductoSoap.AgregarProducto(ProyectoTiendita.ServiceReference3.AgregarProductoRequest request) {
            return base.Channel.AgregarProducto(request);
        }
        
        public bool AgregarProducto(ProyectoTiendita.ServiceReference3.Producto prod) {
            ProyectoTiendita.ServiceReference3.AgregarProductoRequest inValue = new ProyectoTiendita.ServiceReference3.AgregarProductoRequest();
            inValue.Body = new ProyectoTiendita.ServiceReference3.AgregarProductoRequestBody();
            inValue.Body.prod = prod;
            ProyectoTiendita.ServiceReference3.AgregarProductoResponse retVal = ((ProyectoTiendita.ServiceReference3.ServicioProductoSoap)(this)).AgregarProducto(inValue);
            return retVal.Body.AgregarProductoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoTiendita.ServiceReference3.AgregarProductoResponse> ProyectoTiendita.ServiceReference3.ServicioProductoSoap.AgregarProductoAsync(ProyectoTiendita.ServiceReference3.AgregarProductoRequest request) {
            return base.Channel.AgregarProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoTiendita.ServiceReference3.AgregarProductoResponse> AgregarProductoAsync(ProyectoTiendita.ServiceReference3.Producto prod) {
            ProyectoTiendita.ServiceReference3.AgregarProductoRequest inValue = new ProyectoTiendita.ServiceReference3.AgregarProductoRequest();
            inValue.Body = new ProyectoTiendita.ServiceReference3.AgregarProductoRequestBody();
            inValue.Body.prod = prod;
            return ((ProyectoTiendita.ServiceReference3.ServicioProductoSoap)(this)).AgregarProductoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoTiendita.ServiceReference3.ModificarProductoResponse ProyectoTiendita.ServiceReference3.ServicioProductoSoap.ModificarProducto(ProyectoTiendita.ServiceReference3.ModificarProductoRequest request) {
            return base.Channel.ModificarProducto(request);
        }
        
        public bool ModificarProducto(ProyectoTiendita.ServiceReference3.Producto prod) {
            ProyectoTiendita.ServiceReference3.ModificarProductoRequest inValue = new ProyectoTiendita.ServiceReference3.ModificarProductoRequest();
            inValue.Body = new ProyectoTiendita.ServiceReference3.ModificarProductoRequestBody();
            inValue.Body.prod = prod;
            ProyectoTiendita.ServiceReference3.ModificarProductoResponse retVal = ((ProyectoTiendita.ServiceReference3.ServicioProductoSoap)(this)).ModificarProducto(inValue);
            return retVal.Body.ModificarProductoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoTiendita.ServiceReference3.ModificarProductoResponse> ProyectoTiendita.ServiceReference3.ServicioProductoSoap.ModificarProductoAsync(ProyectoTiendita.ServiceReference3.ModificarProductoRequest request) {
            return base.Channel.ModificarProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoTiendita.ServiceReference3.ModificarProductoResponse> ModificarProductoAsync(ProyectoTiendita.ServiceReference3.Producto prod) {
            ProyectoTiendita.ServiceReference3.ModificarProductoRequest inValue = new ProyectoTiendita.ServiceReference3.ModificarProductoRequest();
            inValue.Body = new ProyectoTiendita.ServiceReference3.ModificarProductoRequestBody();
            inValue.Body.prod = prod;
            return ((ProyectoTiendita.ServiceReference3.ServicioProductoSoap)(this)).ModificarProductoAsync(inValue);
        }
        
        public bool EliminarProducto(int idProd) {
            return base.Channel.EliminarProducto(idProd);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarProductoAsync(int idProd) {
            return base.Channel.EliminarProductoAsync(idProd);
        }
    }
}
