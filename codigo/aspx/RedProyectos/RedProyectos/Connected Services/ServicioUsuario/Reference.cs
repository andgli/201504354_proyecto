﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RedProyectos.ServicioUsuario {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://servicios/", ConfigurationName="ServicioUsuario.Usuarios")]
    public interface Usuarios {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios/Usuarios/AgregarUsuarioRequest", ReplyAction="http://servicios/Usuarios/AgregarUsuarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        RedProyectos.ServicioUsuario.AgregarUsuarioResponse AgregarUsuario(RedProyectos.ServicioUsuario.AgregarUsuarioRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios/Usuarios/ExistenteRequest", ReplyAction="http://servicios/Usuarios/ExistenteResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        RedProyectos.ServicioUsuario.ExistenteResponse Existente(RedProyectos.ServicioUsuario.ExistenteRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios/Usuarios/getDatosRequest", ReplyAction="http://servicios/Usuarios/getDatosResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        RedProyectos.ServicioUsuario.getDatosResponse getDatos(RedProyectos.ServicioUsuario.getDatosRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios/Usuarios/puntarMasKarmaRequest", ReplyAction="http://servicios/Usuarios/puntarMasKarmaResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        RedProyectos.ServicioUsuario.puntarMasKarmaResponse puntarMasKarma(RedProyectos.ServicioUsuario.puntarMasKarmaRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios/Usuarios/AddConocimientoRequest", ReplyAction="http://servicios/Usuarios/AddConocimientoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        RedProyectos.ServicioUsuario.AddConocimientoResponse AddConocimiento(RedProyectos.ServicioUsuario.AddConocimientoRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios/Usuarios/AddAmigoRequest", ReplyAction="http://servicios/Usuarios/AddAmigoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        RedProyectos.ServicioUsuario.AddAmigoResponse AddAmigo(RedProyectos.ServicioUsuario.AddAmigoRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios/Usuarios/deleteAmigoRequest", ReplyAction="http://servicios/Usuarios/deleteAmigoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        RedProyectos.ServicioUsuario.deleteAmigoResponse deleteAmigo(RedProyectos.ServicioUsuario.deleteAmigoRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios/Usuarios/aplicarAsociacionRequest", ReplyAction="http://servicios/Usuarios/aplicarAsociacionResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        RedProyectos.ServicioUsuario.aplicarAsociacionResponse aplicarAsociacion(RedProyectos.ServicioUsuario.aplicarAsociacionRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios/Usuarios/puntarMenosKarmaRequest", ReplyAction="http://servicios/Usuarios/puntarMenosKarmaResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        RedProyectos.ServicioUsuario.puntarMenosKarmaResponse puntarMenosKarma(RedProyectos.ServicioUsuario.puntarMenosKarmaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AgregarUsuario", WrapperNamespace="http://servicios/", IsWrapped=true)]
    public partial class AgregarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nombre;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string correo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string fecha_nacimiento;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nick_name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string contrasenia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int dinero;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tipo;
        
        public AgregarUsuarioRequest() {
        }
        
        public AgregarUsuarioRequest(string nombre, string correo, string fecha_nacimiento, string nick_name, string contrasenia, int dinero, string tipo) {
            this.nombre = nombre;
            this.correo = correo;
            this.fecha_nacimiento = fecha_nacimiento;
            this.nick_name = nick_name;
            this.contrasenia = contrasenia;
            this.dinero = dinero;
            this.tipo = tipo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AgregarUsuarioResponse", WrapperNamespace="http://servicios/", IsWrapped=true)]
    public partial class AgregarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public AgregarUsuarioResponse() {
        }
        
        public AgregarUsuarioResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Existente", WrapperNamespace="http://servicios/", IsWrapped=true)]
    public partial class ExistenteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nick_name;
        
        public ExistenteRequest() {
        }
        
        public ExistenteRequest(string nick_name) {
            this.nick_name = nick_name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ExistenteResponse", WrapperNamespace="http://servicios/", IsWrapped=true)]
    public partial class ExistenteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public ExistenteResponse() {
        }
        
        public ExistenteResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getDatos", WrapperNamespace="http://servicios/", IsWrapped=true)]
    public partial class getDatosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nick_name;
        
        public getDatosRequest() {
        }
        
        public getDatosRequest(string nick_name) {
            this.nick_name = nick_name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getDatosResponse", WrapperNamespace="http://servicios/", IsWrapped=true)]
    public partial class getDatosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string[] @return;
        
        public getDatosResponse() {
        }
        
        public getDatosResponse(string[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="puntarMasKarma", WrapperNamespace="http://servicios/", IsWrapped=true)]
    public partial class puntarMasKarmaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string conocimiento;
        
        public puntarMasKarmaRequest() {
        }
        
        public puntarMasKarmaRequest(string usuario, string conocimiento) {
            this.usuario = usuario;
            this.conocimiento = conocimiento;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="puntarMasKarmaResponse", WrapperNamespace="http://servicios/", IsWrapped=true)]
    public partial class puntarMasKarmaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public puntarMasKarmaResponse() {
        }
        
        public puntarMasKarmaResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddConocimiento", WrapperNamespace="http://servicios/", IsWrapped=true)]
    public partial class AddConocimientoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int karma;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string conocimiento;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        public AddConocimientoRequest() {
        }
        
        public AddConocimientoRequest(int karma, string conocimiento, string usuario) {
            this.karma = karma;
            this.conocimiento = conocimiento;
            this.usuario = usuario;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddConocimientoResponse", WrapperNamespace="http://servicios/", IsWrapped=true)]
    public partial class AddConocimientoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public AddConocimientoResponse() {
        }
        
        public AddConocimientoResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddAmigo", WrapperNamespace="http://servicios/", IsWrapped=true)]
    public partial class AddAmigoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string amigo;
        
        public AddAmigoRequest() {
        }
        
        public AddAmigoRequest(string usuario, string amigo) {
            this.usuario = usuario;
            this.amigo = amigo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddAmigoResponse", WrapperNamespace="http://servicios/", IsWrapped=true)]
    public partial class AddAmigoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public AddAmigoResponse() {
        }
        
        public AddAmigoResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="deleteAmigo", WrapperNamespace="http://servicios/", IsWrapped=true)]
    public partial class deleteAmigoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string user;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string amigo;
        
        public deleteAmigoRequest() {
        }
        
        public deleteAmigoRequest(string user, string amigo) {
            this.user = user;
            this.amigo = amigo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="deleteAmigoResponse", WrapperNamespace="http://servicios/", IsWrapped=true)]
    public partial class deleteAmigoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public deleteAmigoResponse() {
        }
        
        public deleteAmigoResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="aplicarAsociacion", WrapperNamespace="http://servicios/", IsWrapped=true)]
    public partial class aplicarAsociacionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tipo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string asociacion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        public aplicarAsociacionRequest() {
        }
        
        public aplicarAsociacionRequest(string tipo, string asociacion, string usuario) {
            this.tipo = tipo;
            this.asociacion = asociacion;
            this.usuario = usuario;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="aplicarAsociacionResponse", WrapperNamespace="http://servicios/", IsWrapped=true)]
    public partial class aplicarAsociacionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public aplicarAsociacionResponse() {
        }
        
        public aplicarAsociacionResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="puntarMenosKarma", WrapperNamespace="http://servicios/", IsWrapped=true)]
    public partial class puntarMenosKarmaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string conocimiento;
        
        public puntarMenosKarmaRequest() {
        }
        
        public puntarMenosKarmaRequest(string usuario, string conocimiento) {
            this.usuario = usuario;
            this.conocimiento = conocimiento;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="puntarMenosKarmaResponse", WrapperNamespace="http://servicios/", IsWrapped=true)]
    public partial class puntarMenosKarmaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public puntarMenosKarmaResponse() {
        }
        
        public puntarMenosKarmaResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UsuariosChannel : RedProyectos.ServicioUsuario.Usuarios, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsuariosClient : System.ServiceModel.ClientBase<RedProyectos.ServicioUsuario.Usuarios>, RedProyectos.ServicioUsuario.Usuarios {
        
        public UsuariosClient() {
        }
        
        public UsuariosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsuariosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuariosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuariosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RedProyectos.ServicioUsuario.AgregarUsuarioResponse RedProyectos.ServicioUsuario.Usuarios.AgregarUsuario(RedProyectos.ServicioUsuario.AgregarUsuarioRequest request) {
            return base.Channel.AgregarUsuario(request);
        }
        
        public bool AgregarUsuario(string nombre, string correo, string fecha_nacimiento, string nick_name, string contrasenia, int dinero, string tipo) {
            RedProyectos.ServicioUsuario.AgregarUsuarioRequest inValue = new RedProyectos.ServicioUsuario.AgregarUsuarioRequest();
            inValue.nombre = nombre;
            inValue.correo = correo;
            inValue.fecha_nacimiento = fecha_nacimiento;
            inValue.nick_name = nick_name;
            inValue.contrasenia = contrasenia;
            inValue.dinero = dinero;
            inValue.tipo = tipo;
            RedProyectos.ServicioUsuario.AgregarUsuarioResponse retVal = ((RedProyectos.ServicioUsuario.Usuarios)(this)).AgregarUsuario(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RedProyectos.ServicioUsuario.ExistenteResponse RedProyectos.ServicioUsuario.Usuarios.Existente(RedProyectos.ServicioUsuario.ExistenteRequest request) {
            return base.Channel.Existente(request);
        }
        
        public string Existente(string nick_name) {
            RedProyectos.ServicioUsuario.ExistenteRequest inValue = new RedProyectos.ServicioUsuario.ExistenteRequest();
            inValue.nick_name = nick_name;
            RedProyectos.ServicioUsuario.ExistenteResponse retVal = ((RedProyectos.ServicioUsuario.Usuarios)(this)).Existente(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RedProyectos.ServicioUsuario.getDatosResponse RedProyectos.ServicioUsuario.Usuarios.getDatos(RedProyectos.ServicioUsuario.getDatosRequest request) {
            return base.Channel.getDatos(request);
        }
        
        public string[] getDatos(string nick_name) {
            RedProyectos.ServicioUsuario.getDatosRequest inValue = new RedProyectos.ServicioUsuario.getDatosRequest();
            inValue.nick_name = nick_name;
            RedProyectos.ServicioUsuario.getDatosResponse retVal = ((RedProyectos.ServicioUsuario.Usuarios)(this)).getDatos(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RedProyectos.ServicioUsuario.puntarMasKarmaResponse RedProyectos.ServicioUsuario.Usuarios.puntarMasKarma(RedProyectos.ServicioUsuario.puntarMasKarmaRequest request) {
            return base.Channel.puntarMasKarma(request);
        }
        
        public bool puntarMasKarma(string usuario, string conocimiento) {
            RedProyectos.ServicioUsuario.puntarMasKarmaRequest inValue = new RedProyectos.ServicioUsuario.puntarMasKarmaRequest();
            inValue.usuario = usuario;
            inValue.conocimiento = conocimiento;
            RedProyectos.ServicioUsuario.puntarMasKarmaResponse retVal = ((RedProyectos.ServicioUsuario.Usuarios)(this)).puntarMasKarma(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RedProyectos.ServicioUsuario.AddConocimientoResponse RedProyectos.ServicioUsuario.Usuarios.AddConocimiento(RedProyectos.ServicioUsuario.AddConocimientoRequest request) {
            return base.Channel.AddConocimiento(request);
        }
        
        public bool AddConocimiento(int karma, string conocimiento, string usuario) {
            RedProyectos.ServicioUsuario.AddConocimientoRequest inValue = new RedProyectos.ServicioUsuario.AddConocimientoRequest();
            inValue.karma = karma;
            inValue.conocimiento = conocimiento;
            inValue.usuario = usuario;
            RedProyectos.ServicioUsuario.AddConocimientoResponse retVal = ((RedProyectos.ServicioUsuario.Usuarios)(this)).AddConocimiento(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RedProyectos.ServicioUsuario.AddAmigoResponse RedProyectos.ServicioUsuario.Usuarios.AddAmigo(RedProyectos.ServicioUsuario.AddAmigoRequest request) {
            return base.Channel.AddAmigo(request);
        }
        
        public bool AddAmigo(string usuario, string amigo) {
            RedProyectos.ServicioUsuario.AddAmigoRequest inValue = new RedProyectos.ServicioUsuario.AddAmigoRequest();
            inValue.usuario = usuario;
            inValue.amigo = amigo;
            RedProyectos.ServicioUsuario.AddAmigoResponse retVal = ((RedProyectos.ServicioUsuario.Usuarios)(this)).AddAmigo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RedProyectos.ServicioUsuario.deleteAmigoResponse RedProyectos.ServicioUsuario.Usuarios.deleteAmigo(RedProyectos.ServicioUsuario.deleteAmigoRequest request) {
            return base.Channel.deleteAmigo(request);
        }
        
        public bool deleteAmigo(string user, string amigo) {
            RedProyectos.ServicioUsuario.deleteAmigoRequest inValue = new RedProyectos.ServicioUsuario.deleteAmigoRequest();
            inValue.user = user;
            inValue.amigo = amigo;
            RedProyectos.ServicioUsuario.deleteAmigoResponse retVal = ((RedProyectos.ServicioUsuario.Usuarios)(this)).deleteAmigo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RedProyectos.ServicioUsuario.aplicarAsociacionResponse RedProyectos.ServicioUsuario.Usuarios.aplicarAsociacion(RedProyectos.ServicioUsuario.aplicarAsociacionRequest request) {
            return base.Channel.aplicarAsociacion(request);
        }
        
        public bool aplicarAsociacion(string tipo, string asociacion, string usuario) {
            RedProyectos.ServicioUsuario.aplicarAsociacionRequest inValue = new RedProyectos.ServicioUsuario.aplicarAsociacionRequest();
            inValue.tipo = tipo;
            inValue.asociacion = asociacion;
            inValue.usuario = usuario;
            RedProyectos.ServicioUsuario.aplicarAsociacionResponse retVal = ((RedProyectos.ServicioUsuario.Usuarios)(this)).aplicarAsociacion(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RedProyectos.ServicioUsuario.puntarMenosKarmaResponse RedProyectos.ServicioUsuario.Usuarios.puntarMenosKarma(RedProyectos.ServicioUsuario.puntarMenosKarmaRequest request) {
            return base.Channel.puntarMenosKarma(request);
        }
        
        public bool puntarMenosKarma(string usuario, string conocimiento) {
            RedProyectos.ServicioUsuario.puntarMenosKarmaRequest inValue = new RedProyectos.ServicioUsuario.puntarMenosKarmaRequest();
            inValue.usuario = usuario;
            inValue.conocimiento = conocimiento;
            RedProyectos.ServicioUsuario.puntarMenosKarmaResponse retVal = ((RedProyectos.ServicioUsuario.Usuarios)(this)).puntarMenosKarma(inValue);
            return retVal.@return;
        }
    }
}
