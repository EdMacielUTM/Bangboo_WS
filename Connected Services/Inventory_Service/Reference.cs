﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bangboo_WS.Inventory_Service {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="VO_Inventory", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class VO_Inventory : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int ID_InventoryField;
        
        private int Bangboo_IDField;
        
        private int QuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastRestockDateField;
        
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
        public int ID_Inventory {
            get {
                return this.ID_InventoryField;
            }
            set {
                if ((this.ID_InventoryField.Equals(value) != true)) {
                    this.ID_InventoryField = value;
                    this.RaisePropertyChanged("ID_Inventory");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public int Bangboo_ID {
            get {
                return this.Bangboo_IDField;
            }
            set {
                if ((this.Bangboo_IDField.Equals(value) != true)) {
                    this.Bangboo_IDField = value;
                    this.RaisePropertyChanged("Bangboo_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Inventory_Service.Inventory_ServiceSoap")]
    public interface Inventory_ServiceSoap {
        
        // CODEGEN: Generating message contract since element name parameters from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetInventory", ReplyAction="*")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Bangboo_WS.Inventory_Service.ArrayOfAnyType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Bangboo_WS.Inventory_Service.VO_Inventory))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Bangboo_WS.Inventory_Service.VO_Inventory[]))]
        Bangboo_WS.Inventory_Service.GetInventoryResponse GetInventory(Bangboo_WS.Inventory_Service.GetInventoryRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetInventory", ReplyAction="*")]
        System.Threading.Tasks.Task<Bangboo_WS.Inventory_Service.GetInventoryResponse> GetInventoryAsync(Bangboo_WS.Inventory_Service.GetInventoryRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetInventoryRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetInventory", Namespace="http://tempuri.org/", Order=0)]
        public Bangboo_WS.Inventory_Service.GetInventoryRequestBody Body;
        
        public GetInventoryRequest() {
        }
        
        public GetInventoryRequest(Bangboo_WS.Inventory_Service.GetInventoryRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetInventoryRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Bangboo_WS.Inventory_Service.ArrayOfAnyType parameters;
        
        public GetInventoryRequestBody() {
        }
        
        public GetInventoryRequestBody(Bangboo_WS.Inventory_Service.ArrayOfAnyType parameters) {
            this.parameters = parameters;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetInventoryResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetInventoryResponse", Namespace="http://tempuri.org/", Order=0)]
        public Bangboo_WS.Inventory_Service.GetInventoryResponseBody Body;
        
        public GetInventoryResponse() {
        }
        
        public GetInventoryResponse(Bangboo_WS.Inventory_Service.GetInventoryResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetInventoryResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Bangboo_WS.Inventory_Service.VO_Inventory[] GetInventoryResult;
        
        public GetInventoryResponseBody() {
        }
        
        public GetInventoryResponseBody(Bangboo_WS.Inventory_Service.VO_Inventory[] GetInventoryResult) {
            this.GetInventoryResult = GetInventoryResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Inventory_ServiceSoapChannel : Bangboo_WS.Inventory_Service.Inventory_ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Inventory_ServiceSoapClient : System.ServiceModel.ClientBase<Bangboo_WS.Inventory_Service.Inventory_ServiceSoap>, Bangboo_WS.Inventory_Service.Inventory_ServiceSoap {
        
        public Inventory_ServiceSoapClient() {
        }
        
        public Inventory_ServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Inventory_ServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Inventory_ServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Inventory_ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Bangboo_WS.Inventory_Service.GetInventoryResponse Bangboo_WS.Inventory_Service.Inventory_ServiceSoap.GetInventory(Bangboo_WS.Inventory_Service.GetInventoryRequest request) {
            return base.Channel.GetInventory(request);
        }
        
        public Bangboo_WS.Inventory_Service.VO_Inventory[] GetInventory(Bangboo_WS.Inventory_Service.ArrayOfAnyType parameters) {
            Bangboo_WS.Inventory_Service.GetInventoryRequest inValue = new Bangboo_WS.Inventory_Service.GetInventoryRequest();
            inValue.Body = new Bangboo_WS.Inventory_Service.GetInventoryRequestBody();
            inValue.Body.parameters = parameters;
            Bangboo_WS.Inventory_Service.GetInventoryResponse retVal = ((Bangboo_WS.Inventory_Service.Inventory_ServiceSoap)(this)).GetInventory(inValue);
            return retVal.Body.GetInventoryResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Bangboo_WS.Inventory_Service.GetInventoryResponse> Bangboo_WS.Inventory_Service.Inventory_ServiceSoap.GetInventoryAsync(Bangboo_WS.Inventory_Service.GetInventoryRequest request) {
            return base.Channel.GetInventoryAsync(request);
        }
        
        public System.Threading.Tasks.Task<Bangboo_WS.Inventory_Service.GetInventoryResponse> GetInventoryAsync(Bangboo_WS.Inventory_Service.ArrayOfAnyType parameters) {
            Bangboo_WS.Inventory_Service.GetInventoryRequest inValue = new Bangboo_WS.Inventory_Service.GetInventoryRequest();
            inValue.Body = new Bangboo_WS.Inventory_Service.GetInventoryRequestBody();
            inValue.Body.parameters = parameters;
            return ((Bangboo_WS.Inventory_Service.Inventory_ServiceSoap)(this)).GetInventoryAsync(inValue);
        }
    }
}
