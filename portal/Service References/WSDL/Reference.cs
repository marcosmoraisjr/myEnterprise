﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace portal.WSDL {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://system.human.com.br/GatewayIntegration/services/Sms", ConfigurationName="WSDL.Sms_BindingImpl")]
    public interface Sms_BindingImpl {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://Sms.ws.gateway.human.com) of message sendSmsRequest does not match the default value (http://system.human.com.br/GatewayIntegration/services/Sms)
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        portal.WSDL.sendSmsResponse sendSms(portal.WSDL.sendSmsRequest1 request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://system.human.com.br/GatewayIntegration/services/Sms")]
    public partial class SendSmsRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string accountField;
        
        private string codeField;
        
        private string msgField;
        
        private string fromField;
        
        private string mobileField;
        
        private string idField;
        
        private System.Nullable<System.DateTime> scheduleField;
        
        private int callbackOptionField;
        
        /// <remarks/>
        public string account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
                this.RaisePropertyChanged("account");
            }
        }
        
        /// <remarks/>
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }
        
        /// <remarks/>
        public string msg {
            get {
                return this.msgField;
            }
            set {
                this.msgField = value;
                this.RaisePropertyChanged("msg");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string from {
            get {
                return this.fromField;
            }
            set {
                this.fromField = value;
                this.RaisePropertyChanged("from");
            }
        }
        
        /// <remarks/>
        public string mobile {
            get {
                return this.mobileField;
            }
            set {
                this.mobileField = value;
                this.RaisePropertyChanged("mobile");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> schedule {
            get {
                return this.scheduleField;
            }
            set {
                this.scheduleField = value;
                this.RaisePropertyChanged("schedule");
            }
        }
        
        /// <remarks/>
        public int callbackOption {
            get {
                return this.callbackOptionField;
            }
            set {
                this.callbackOptionField = value;
                this.RaisePropertyChanged("callbackOption");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendSms", WrapperNamespace="http://Sms.ws.gateway.human.com", IsWrapped=true)]
    public partial class sendSmsRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public portal.WSDL.SendSmsRequest sendSmsRequest;
        
        public sendSmsRequest1() {
        }
        
        public sendSmsRequest1(portal.WSDL.SendSmsRequest sendSmsRequest) {
            this.sendSmsRequest = sendSmsRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendSmsResponse", WrapperNamespace="http://system.human.com.br/GatewayIntegration/services/Sms", IsWrapped=true)]
    public partial class sendSmsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string sendSmsReturn;
        
        public sendSmsResponse() {
        }
        
        public sendSmsResponse(string sendSmsReturn) {
            this.sendSmsReturn = sendSmsReturn;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface Sms_BindingImplChannel : portal.WSDL.Sms_BindingImpl, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class Sms_BindingImplClient : System.ServiceModel.ClientBase<portal.WSDL.Sms_BindingImpl>, portal.WSDL.Sms_BindingImpl {
        
        public Sms_BindingImplClient() {
        }
        
        public Sms_BindingImplClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Sms_BindingImplClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Sms_BindingImplClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Sms_BindingImplClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        portal.WSDL.sendSmsResponse portal.WSDL.Sms_BindingImpl.sendSms(portal.WSDL.sendSmsRequest1 request) {
            return base.Channel.sendSms(request);
        }
        
        public string sendSms(portal.WSDL.SendSmsRequest sendSmsRequest) {
            portal.WSDL.sendSmsRequest1 inValue = new portal.WSDL.sendSmsRequest1();
            inValue.sendSmsRequest = sendSmsRequest;
            portal.WSDL.sendSmsResponse retVal = ((portal.WSDL.Sms_BindingImpl)(this)).sendSms(inValue);
            return retVal.sendSmsReturn;
        }
    }
}
