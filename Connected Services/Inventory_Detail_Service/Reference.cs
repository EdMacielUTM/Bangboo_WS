﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bangboo_WS.Inventory_Detail_Service {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfAnyType", Namespace="http://tempuri.org/", ItemName="anyType")]
    [System.SerializableAttribute()]
    public class ArrayOfAnyType : System.Collections.Generic.List<object> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VO_Inventory_Details", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class VO_Inventory_Details : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int ID_BangbooField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        private int PriceField;
        
        private int QuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastRestockDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PictureURLField;
        
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
        public int ID_Bangboo {
            get {
                return this.ID_BangbooField;
            }
            set {
                if ((this.ID_BangbooField.Equals(value) != true)) {
                    this.ID_BangbooField = value;
                    this.RaisePropertyChanged("ID_Bangboo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string LastRestockDate {
            get {
                return this.LastRestockDateField;
            }
            set {
                if ((object.ReferenceEquals(this.LastRestockDateField, value) != true)) {
                    this.LastRestockDateField = value;
                    this.RaisePropertyChanged("LastRestockDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string PictureURL {
            get {
                return this.PictureURLField;
            }
            set {
                if ((object.ReferenceEquals(this.PictureURLField, value) != true)) {
                    this.PictureURLField = value;
                    this.RaisePropertyChanged("PictureURL");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Inventory_Detail_Service.Inventory_Detail_ServiceSoap")]
    public interface Inventory_Detail_ServiceSoap {
        
        // CODEGEN: Generating message contract since element name parameters from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetInventoryDetails", ReplyAction="*")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Bangboo_WS.Inventory_Detail_Service.ArrayOfAnyType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Bangboo_WS.Inventory_Detail_Service.VO_Inventory_Details))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Bangboo_WS.Inventory_Detail_Service.VO_Inventory_Details[]))]
        Bangboo_WS.Inventory_Detail_Service.GetInventoryDetailsResponse GetInventoryDetails(Bangboo_WS.Inventory_Detail_Service.GetInventoryDetailsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetInventoryDetails", ReplyAction="*")]
        System.Threading.Tasks.Task<Bangboo_WS.Inventory_Detail_Service.GetInventoryDetailsResponse> GetInventoryDetailsAsync(Bangboo_WS.Inventory_Detail_Service.GetInventoryDetailsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetInventoryDetailsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetInventoryDetails", Namespace="http://tempuri.org/", Order=0)]
        public Bangboo_WS.Inventory_Detail_Service.GetInventoryDetailsRequestBody Body;
        
        public GetInventoryDetailsRequest() {
        }
        
        public GetInventoryDetailsRequest(Bangboo_WS.Inventory_Detail_Service.GetInventoryDetailsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetInventoryDetailsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Bangboo_WS.Inventory_Detail_Service.ArrayOfAnyType parameters;
        
        public GetInventoryDetailsRequestBody() {
        }
        
        public GetInventoryDetailsRequestBody(Bangboo_WS.Inventory_Detail_Service.ArrayOfAnyType parameters) {
            this.parameters = parameters;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetInventoryDetailsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetInventoryDetailsResponse", Namespace="http://tempuri.org/", Order=0)]
        public Bangboo_WS.Inventory_Detail_Service.GetInventoryDetailsResponseBody Body;
        
        public GetInventoryDetailsResponse() {
        }
        
        public GetInventoryDetailsResponse(Bangboo_WS.Inventory_Detail_Service.GetInventoryDetailsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetInventoryDetailsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Bangboo_WS.Inventory_Detail_Service.VO_Inventory_Details[] GetInventoryDetailsResult;
        
        public GetInventoryDetailsResponseBody() {
        }
        
        public GetInventoryDetailsResponseBody(Bangboo_WS.Inventory_Detail_Service.VO_Inventory_Details[] GetInventoryDetailsResult) {
            this.GetInventoryDetailsResult = GetInventoryDetailsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Inventory_Detail_ServiceSoapChannel : Bangboo_WS.Inventory_Detail_Service.Inventory_Detail_ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Inventory_Detail_ServiceSoapClient : System.ServiceModel.ClientBase<Bangboo_WS.Inventory_Detail_Service.Inventory_Detail_ServiceSoap>, Bangboo_WS.Inventory_Detail_Service.Inventory_Detail_ServiceSoap {
        
        public Inventory_Detail_ServiceSoapClient() {
        }
        
        public Inventory_Detail_ServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Inventory_Detail_ServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Inventory_Detail_ServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Inventory_Detail_ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Bangboo_WS.Inventory_Detail_Service.GetInventoryDetailsResponse Bangboo_WS.Inventory_Detail_Service.Inventory_Detail_ServiceSoap.GetInventoryDetails(Bangboo_WS.Inventory_Detail_Service.GetInventoryDetailsRequest request) {
            return base.Channel.GetInventoryDetails(request);
        }
        
        public Bangboo_WS.Inventory_Detail_Service.VO_Inventory_Details[] GetInventoryDetails(Bangboo_WS.Inventory_Detail_Service.ArrayOfAnyType parameters) {
            Bangboo_WS.Inventory_Detail_Service.GetInventoryDetailsRequest inValue = new Bangboo_WS.Inventory_Detail_Service.GetInventoryDetailsRequest();
            inValue.Body = new Bangboo_WS.Inventory_Detail_Service.GetInventoryDetailsRequestBody();
            inValue.Body.parameters = parameters;
            Bangboo_WS.Inventory_Detail_Service.GetInventoryDetailsResponse retVal = ((Bangboo_WS.Inventory_Detail_Service.Inventory_Detail_ServiceSoap)(this)).GetInventoryDetails(inValue);
            return retVal.Body.GetInventoryDetailsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Bangboo_WS.Inventory_Detail_Service.GetInventoryDetailsResponse> Bangboo_WS.Inventory_Detail_Service.Inventory_Detail_ServiceSoap.GetInventoryDetailsAsync(Bangboo_WS.Inventory_Detail_Service.GetInventoryDetailsRequest request) {
            return base.Channel.GetInventoryDetailsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Bangboo_WS.Inventory_Detail_Service.GetInventoryDetailsResponse> GetInventoryDetailsAsync(Bangboo_WS.Inventory_Detail_Service.ArrayOfAnyType parameters) {
            Bangboo_WS.Inventory_Detail_Service.GetInventoryDetailsRequest inValue = new Bangboo_WS.Inventory_Detail_Service.GetInventoryDetailsRequest();
            inValue.Body = new Bangboo_WS.Inventory_Detail_Service.GetInventoryDetailsRequestBody();
            inValue.Body.parameters = parameters;
            return ((Bangboo_WS.Inventory_Detail_Service.Inventory_Detail_ServiceSoap)(this)).GetInventoryDetailsAsync(inValue);
        }
    }
}
