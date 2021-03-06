﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RedProyectos.ServicioMensaje {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://servicios/", ConfigurationName="ServicioMensaje.Mensajes")]
    public interface Mensajes {
        
        // CODEGEN: Generating message contract since element name descripcion from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios/Mensajes/setMensajeRequest", ReplyAction="http://servicios/Mensajes/setMensajeResponse")]
        RedProyectos.ServicioMensaje.setMensajeResponse setMensaje(RedProyectos.ServicioMensaje.setMensajeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class setMensajeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="setMensaje", Namespace="http://servicios/", Order=0)]
        public RedProyectos.ServicioMensaje.setMensajeRequestBody Body;
        
        public setMensajeRequest() {
        }
        
        public setMensajeRequest(RedProyectos.ServicioMensaje.setMensajeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class setMensajeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string descripcion;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string usuario;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string amigo;
        
        public setMensajeRequestBody() {
        }
        
        public setMensajeRequestBody(string descripcion, string usuario, string amigo) {
            this.descripcion = descripcion;
            this.usuario = usuario;
            this.amigo = amigo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class setMensajeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="setMensajeResponse", Namespace="http://servicios/", Order=0)]
        public RedProyectos.ServicioMensaje.setMensajeResponseBody Body;
        
        public setMensajeResponse() {
        }
        
        public setMensajeResponse(RedProyectos.ServicioMensaje.setMensajeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class setMensajeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool @return;
        
        public setMensajeResponseBody() {
        }
        
        public setMensajeResponseBody(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MensajesChannel : RedProyectos.ServicioMensaje.Mensajes, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MensajesClient : System.ServiceModel.ClientBase<RedProyectos.ServicioMensaje.Mensajes>, RedProyectos.ServicioMensaje.Mensajes {
        
        public MensajesClient() {
        }
        
        public MensajesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MensajesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MensajesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MensajesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RedProyectos.ServicioMensaje.setMensajeResponse RedProyectos.ServicioMensaje.Mensajes.setMensaje(RedProyectos.ServicioMensaje.setMensajeRequest request) {
            return base.Channel.setMensaje(request);
        }
        
        public bool setMensaje(string descripcion, string usuario, string amigo) {
            RedProyectos.ServicioMensaje.setMensajeRequest inValue = new RedProyectos.ServicioMensaje.setMensajeRequest();
            inValue.Body = new RedProyectos.ServicioMensaje.setMensajeRequestBody();
            inValue.Body.descripcion = descripcion;
            inValue.Body.usuario = usuario;
            inValue.Body.amigo = amigo;
            RedProyectos.ServicioMensaje.setMensajeResponse retVal = ((RedProyectos.ServicioMensaje.Mensajes)(this)).setMensaje(inValue);
            return retVal.Body.@return;
        }
    }
}
