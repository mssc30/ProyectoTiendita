﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoTiendita.ServicioExterno {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.sdde.bccr.fi.cr", ConfigurationName="ServicioExterno.wsindicadoreseconomicosSoap")]
    public interface wsindicadoreseconomicosSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.sdde.bccr.fi.cr/ObtenerIndicadoresEconomicos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ObtenerIndicadoresEconomicos(string Indicador, string FechaInicio, string FechaFinal, string Nombre, string SubNiveles, string CorreoElectronico, string Token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.sdde.bccr.fi.cr/ObtenerIndicadoresEconomicos", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ObtenerIndicadoresEconomicosAsync(string Indicador, string FechaInicio, string FechaFinal, string Nombre, string SubNiveles, string CorreoElectronico, string Token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.sdde.bccr.fi.cr/ObtenerIndicadoresEconomicosXML", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string ObtenerIndicadoresEconomicosXML(string Indicador, string FechaInicio, string FechaFinal, string Nombre, string SubNiveles, string CorreoElectronico, string Token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.sdde.bccr.fi.cr/ObtenerIndicadoresEconomicosXML", ReplyAction="*")]
        System.Threading.Tasks.Task<string> ObtenerIndicadoresEconomicosXMLAsync(string Indicador, string FechaInicio, string FechaFinal, string Nombre, string SubNiveles, string CorreoElectronico, string Token);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsindicadoreseconomicosSoapChannel : ProyectoTiendita.ServicioExterno.wsindicadoreseconomicosSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsindicadoreseconomicosSoapClient : System.ServiceModel.ClientBase<ProyectoTiendita.ServicioExterno.wsindicadoreseconomicosSoap>, ProyectoTiendita.ServicioExterno.wsindicadoreseconomicosSoap {
        
        public wsindicadoreseconomicosSoapClient() {
        }
        
        public wsindicadoreseconomicosSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsindicadoreseconomicosSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsindicadoreseconomicosSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsindicadoreseconomicosSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet ObtenerIndicadoresEconomicos(string Indicador, string FechaInicio, string FechaFinal, string Nombre, string SubNiveles, string CorreoElectronico, string Token) {
            return base.Channel.ObtenerIndicadoresEconomicos(Indicador, FechaInicio, FechaFinal, Nombre, SubNiveles, CorreoElectronico, Token);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ObtenerIndicadoresEconomicosAsync(string Indicador, string FechaInicio, string FechaFinal, string Nombre, string SubNiveles, string CorreoElectronico, string Token) {
            return base.Channel.ObtenerIndicadoresEconomicosAsync(Indicador, FechaInicio, FechaFinal, Nombre, SubNiveles, CorreoElectronico, Token);
        }
        
        public string ObtenerIndicadoresEconomicosXML(string Indicador, string FechaInicio, string FechaFinal, string Nombre, string SubNiveles, string CorreoElectronico, string Token) {
            return base.Channel.ObtenerIndicadoresEconomicosXML(Indicador, FechaInicio, FechaFinal, Nombre, SubNiveles, CorreoElectronico, Token);
        }
        
        public System.Threading.Tasks.Task<string> ObtenerIndicadoresEconomicosXMLAsync(string Indicador, string FechaInicio, string FechaFinal, string Nombre, string SubNiveles, string CorreoElectronico, string Token) {
            return base.Channel.ObtenerIndicadoresEconomicosXMLAsync(Indicador, FechaInicio, FechaFinal, Nombre, SubNiveles, CorreoElectronico, Token);
        }
    }
}
