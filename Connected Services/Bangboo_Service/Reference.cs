﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bangboo_WS.Bangboo_Service {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VO_Bangboos", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class VO_Bangboos : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int ID_BangbooField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ElementField;
        
        private bool RankField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PictureURLField;
        
        private int PriceField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Element {
            get {
                return this.ElementField;
            }
            set {
                if ((object.ReferenceEquals(this.ElementField, value) != true)) {
                    this.ElementField = value;
                    this.RaisePropertyChanged("Element");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public bool Rank {
            get {
                return this.RankField;
            }
            set {
                if ((this.RankField.Equals(value) != true)) {
                    this.RankField = value;
                    this.RaisePropertyChanged("Rank");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfAnyType", Namespace="http://tempuri.org/", ItemName="anyType")]
    [System.SerializableAttribute()]
    public class ArrayOfAnyType : System.Collections.Generic.List<object> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Bangboo_Service.Bangboo_ServiceSoap")]
    public interface Bangboo_ServiceSoap {
        
        // CODEGEN: Generating message contract since element name bangboo from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateBangboo", ReplyAction="*")]
        Bangboo_WS.Bangboo_Service.CreateBangbooResponse CreateBangboo(Bangboo_WS.Bangboo_Service.CreateBangbooRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateBangboo", ReplyAction="*")]
        System.Threading.Tasks.Task<Bangboo_WS.Bangboo_Service.CreateBangbooResponse> CreateBangbooAsync(Bangboo_WS.Bangboo_Service.CreateBangbooRequest request);
        
        // CODEGEN: Generating message contract since element name parameters from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBangboos", ReplyAction="*")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Bangboo_WS.Bangboo_Service.VO_Bangboos))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Bangboo_WS.Bangboo_Service.ArrayOfAnyType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Bangboo_WS.Bangboo_Service.VO_Bangboos[]))]
        Bangboo_WS.Bangboo_Service.GetBangboosResponse GetBangboos(Bangboo_WS.Bangboo_Service.GetBangboosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBangboos", ReplyAction="*")]
        System.Threading.Tasks.Task<Bangboo_WS.Bangboo_Service.GetBangboosResponse> GetBangboosAsync(Bangboo_WS.Bangboo_Service.GetBangboosRequest request);
        
        // CODEGEN: Generating message contract since element name bangboo from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateBangboo", ReplyAction="*")]
        Bangboo_WS.Bangboo_Service.UpdateBangbooResponse UpdateBangboo(Bangboo_WS.Bangboo_Service.UpdateBangbooRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateBangboo", ReplyAction="*")]
        System.Threading.Tasks.Task<Bangboo_WS.Bangboo_Service.UpdateBangbooResponse> UpdateBangbooAsync(Bangboo_WS.Bangboo_Service.UpdateBangbooRequest request);
        
        // CODEGEN: Generating message contract since element name DeleteBangbooResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteBangboo", ReplyAction="*")]
        Bangboo_WS.Bangboo_Service.DeleteBangbooResponse DeleteBangboo(Bangboo_WS.Bangboo_Service.DeleteBangbooRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteBangboo", ReplyAction="*")]
        System.Threading.Tasks.Task<Bangboo_WS.Bangboo_Service.DeleteBangbooResponse> DeleteBangbooAsync(Bangboo_WS.Bangboo_Service.DeleteBangbooRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateBangbooRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateBangboo", Namespace="http://tempuri.org/", Order=0)]
        public Bangboo_WS.Bangboo_Service.CreateBangbooRequestBody Body;
        
        public CreateBangbooRequest() {
        }
        
        public CreateBangbooRequest(Bangboo_WS.Bangboo_Service.CreateBangbooRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreateBangbooRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Bangboo_WS.Bangboo_Service.VO_Bangboos bangboo;
        
        public CreateBangbooRequestBody() {
        }
        
        public CreateBangbooRequestBody(Bangboo_WS.Bangboo_Service.VO_Bangboos bangboo) {
            this.bangboo = bangboo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateBangbooResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateBangbooResponse", Namespace="http://tempuri.org/", Order=0)]
        public Bangboo_WS.Bangboo_Service.CreateBangbooResponseBody Body;
        
        public CreateBangbooResponse() {
        }
        
        public CreateBangbooResponse(Bangboo_WS.Bangboo_Service.CreateBangbooResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreateBangbooResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CreateBangbooResult;
        
        public CreateBangbooResponseBody() {
        }
        
        public CreateBangbooResponseBody(string CreateBangbooResult) {
            this.CreateBangbooResult = CreateBangbooResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetBangboosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetBangboos", Namespace="http://tempuri.org/", Order=0)]
        public Bangboo_WS.Bangboo_Service.GetBangboosRequestBody Body;
        
        public GetBangboosRequest() {
        }
        
        public GetBangboosRequest(Bangboo_WS.Bangboo_Service.GetBangboosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetBangboosRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Bangboo_WS.Bangboo_Service.ArrayOfAnyType parameters;
        
        public GetBangboosRequestBody() {
        }
        
        public GetBangboosRequestBody(Bangboo_WS.Bangboo_Service.ArrayOfAnyType parameters) {
            this.parameters = parameters;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetBangboosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetBangboosResponse", Namespace="http://tempuri.org/", Order=0)]
        public Bangboo_WS.Bangboo_Service.GetBangboosResponseBody Body;
        
        public GetBangboosResponse() {
        }
        
        public GetBangboosResponse(Bangboo_WS.Bangboo_Service.GetBangboosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetBangboosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Bangboo_WS.Bangboo_Service.VO_Bangboos[] GetBangboosResult;
        
        public GetBangboosResponseBody() {
        }
        
        public GetBangboosResponseBody(Bangboo_WS.Bangboo_Service.VO_Bangboos[] GetBangboosResult) {
            this.GetBangboosResult = GetBangboosResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateBangbooRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateBangboo", Namespace="http://tempuri.org/", Order=0)]
        public Bangboo_WS.Bangboo_Service.UpdateBangbooRequestBody Body;
        
        public UpdateBangbooRequest() {
        }
        
        public UpdateBangbooRequest(Bangboo_WS.Bangboo_Service.UpdateBangbooRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateBangbooRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Bangboo_WS.Bangboo_Service.VO_Bangboos bangboo;
        
        public UpdateBangbooRequestBody() {
        }
        
        public UpdateBangbooRequestBody(Bangboo_WS.Bangboo_Service.VO_Bangboos bangboo) {
            this.bangboo = bangboo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateBangbooResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateBangbooResponse", Namespace="http://tempuri.org/", Order=0)]
        public Bangboo_WS.Bangboo_Service.UpdateBangbooResponseBody Body;
        
        public UpdateBangbooResponse() {
        }
        
        public UpdateBangbooResponse(Bangboo_WS.Bangboo_Service.UpdateBangbooResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateBangbooResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string UpdateBangbooResult;
        
        public UpdateBangbooResponseBody() {
        }
        
        public UpdateBangbooResponseBody(string UpdateBangbooResult) {
            this.UpdateBangbooResult = UpdateBangbooResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteBangbooRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteBangboo", Namespace="http://tempuri.org/", Order=0)]
        public Bangboo_WS.Bangboo_Service.DeleteBangbooRequestBody Body;
        
        public DeleteBangbooRequest() {
        }
        
        public DeleteBangbooRequest(Bangboo_WS.Bangboo_Service.DeleteBangbooRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeleteBangbooRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public DeleteBangbooRequestBody() {
        }
        
        public DeleteBangbooRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteBangbooResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteBangbooResponse", Namespace="http://tempuri.org/", Order=0)]
        public Bangboo_WS.Bangboo_Service.DeleteBangbooResponseBody Body;
        
        public DeleteBangbooResponse() {
        }
        
        public DeleteBangbooResponse(Bangboo_WS.Bangboo_Service.DeleteBangbooResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeleteBangbooResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string DeleteBangbooResult;
        
        public DeleteBangbooResponseBody() {
        }
        
        public DeleteBangbooResponseBody(string DeleteBangbooResult) {
            this.DeleteBangbooResult = DeleteBangbooResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Bangboo_ServiceSoapChannel : Bangboo_WS.Bangboo_Service.Bangboo_ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Bangboo_ServiceSoapClient : System.ServiceModel.ClientBase<Bangboo_WS.Bangboo_Service.Bangboo_ServiceSoap>, Bangboo_WS.Bangboo_Service.Bangboo_ServiceSoap {
        
        public Bangboo_ServiceSoapClient() {
        }
        
        public Bangboo_ServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Bangboo_ServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Bangboo_ServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Bangboo_ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Bangboo_WS.Bangboo_Service.CreateBangbooResponse Bangboo_WS.Bangboo_Service.Bangboo_ServiceSoap.CreateBangboo(Bangboo_WS.Bangboo_Service.CreateBangbooRequest request) {
            return base.Channel.CreateBangboo(request);
        }
        
        public string CreateBangboo(Bangboo_WS.Bangboo_Service.VO_Bangboos bangboo) {
            Bangboo_WS.Bangboo_Service.CreateBangbooRequest inValue = new Bangboo_WS.Bangboo_Service.CreateBangbooRequest();
            inValue.Body = new Bangboo_WS.Bangboo_Service.CreateBangbooRequestBody();
            inValue.Body.bangboo = bangboo;
            Bangboo_WS.Bangboo_Service.CreateBangbooResponse retVal = ((Bangboo_WS.Bangboo_Service.Bangboo_ServiceSoap)(this)).CreateBangboo(inValue);
            return retVal.Body.CreateBangbooResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Bangboo_WS.Bangboo_Service.CreateBangbooResponse> Bangboo_WS.Bangboo_Service.Bangboo_ServiceSoap.CreateBangbooAsync(Bangboo_WS.Bangboo_Service.CreateBangbooRequest request) {
            return base.Channel.CreateBangbooAsync(request);
        }
        
        public System.Threading.Tasks.Task<Bangboo_WS.Bangboo_Service.CreateBangbooResponse> CreateBangbooAsync(Bangboo_WS.Bangboo_Service.VO_Bangboos bangboo) {
            Bangboo_WS.Bangboo_Service.CreateBangbooRequest inValue = new Bangboo_WS.Bangboo_Service.CreateBangbooRequest();
            inValue.Body = new Bangboo_WS.Bangboo_Service.CreateBangbooRequestBody();
            inValue.Body.bangboo = bangboo;
            return ((Bangboo_WS.Bangboo_Service.Bangboo_ServiceSoap)(this)).CreateBangbooAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Bangboo_WS.Bangboo_Service.GetBangboosResponse Bangboo_WS.Bangboo_Service.Bangboo_ServiceSoap.GetBangboos(Bangboo_WS.Bangboo_Service.GetBangboosRequest request) {
            return base.Channel.GetBangboos(request);
        }
        
        public Bangboo_WS.Bangboo_Service.VO_Bangboos[] GetBangboos(Bangboo_WS.Bangboo_Service.ArrayOfAnyType parameters) {
            Bangboo_WS.Bangboo_Service.GetBangboosRequest inValue = new Bangboo_WS.Bangboo_Service.GetBangboosRequest();
            inValue.Body = new Bangboo_WS.Bangboo_Service.GetBangboosRequestBody();
            inValue.Body.parameters = parameters;
            Bangboo_WS.Bangboo_Service.GetBangboosResponse retVal = ((Bangboo_WS.Bangboo_Service.Bangboo_ServiceSoap)(this)).GetBangboos(inValue);
            return retVal.Body.GetBangboosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Bangboo_WS.Bangboo_Service.GetBangboosResponse> Bangboo_WS.Bangboo_Service.Bangboo_ServiceSoap.GetBangboosAsync(Bangboo_WS.Bangboo_Service.GetBangboosRequest request) {
            return base.Channel.GetBangboosAsync(request);
        }
        
        public System.Threading.Tasks.Task<Bangboo_WS.Bangboo_Service.GetBangboosResponse> GetBangboosAsync(Bangboo_WS.Bangboo_Service.ArrayOfAnyType parameters) {
            Bangboo_WS.Bangboo_Service.GetBangboosRequest inValue = new Bangboo_WS.Bangboo_Service.GetBangboosRequest();
            inValue.Body = new Bangboo_WS.Bangboo_Service.GetBangboosRequestBody();
            inValue.Body.parameters = parameters;
            return ((Bangboo_WS.Bangboo_Service.Bangboo_ServiceSoap)(this)).GetBangboosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Bangboo_WS.Bangboo_Service.UpdateBangbooResponse Bangboo_WS.Bangboo_Service.Bangboo_ServiceSoap.UpdateBangboo(Bangboo_WS.Bangboo_Service.UpdateBangbooRequest request) {
            return base.Channel.UpdateBangboo(request);
        }
        
        public string UpdateBangboo(Bangboo_WS.Bangboo_Service.VO_Bangboos bangboo) {
            Bangboo_WS.Bangboo_Service.UpdateBangbooRequest inValue = new Bangboo_WS.Bangboo_Service.UpdateBangbooRequest();
            inValue.Body = new Bangboo_WS.Bangboo_Service.UpdateBangbooRequestBody();
            inValue.Body.bangboo = bangboo;
            Bangboo_WS.Bangboo_Service.UpdateBangbooResponse retVal = ((Bangboo_WS.Bangboo_Service.Bangboo_ServiceSoap)(this)).UpdateBangboo(inValue);
            return retVal.Body.UpdateBangbooResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Bangboo_WS.Bangboo_Service.UpdateBangbooResponse> Bangboo_WS.Bangboo_Service.Bangboo_ServiceSoap.UpdateBangbooAsync(Bangboo_WS.Bangboo_Service.UpdateBangbooRequest request) {
            return base.Channel.UpdateBangbooAsync(request);
        }
        
        public System.Threading.Tasks.Task<Bangboo_WS.Bangboo_Service.UpdateBangbooResponse> UpdateBangbooAsync(Bangboo_WS.Bangboo_Service.VO_Bangboos bangboo) {
            Bangboo_WS.Bangboo_Service.UpdateBangbooRequest inValue = new Bangboo_WS.Bangboo_Service.UpdateBangbooRequest();
            inValue.Body = new Bangboo_WS.Bangboo_Service.UpdateBangbooRequestBody();
            inValue.Body.bangboo = bangboo;
            return ((Bangboo_WS.Bangboo_Service.Bangboo_ServiceSoap)(this)).UpdateBangbooAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Bangboo_WS.Bangboo_Service.DeleteBangbooResponse Bangboo_WS.Bangboo_Service.Bangboo_ServiceSoap.DeleteBangboo(Bangboo_WS.Bangboo_Service.DeleteBangbooRequest request) {
            return base.Channel.DeleteBangboo(request);
        }
        
        public string DeleteBangboo(int id) {
            Bangboo_WS.Bangboo_Service.DeleteBangbooRequest inValue = new Bangboo_WS.Bangboo_Service.DeleteBangbooRequest();
            inValue.Body = new Bangboo_WS.Bangboo_Service.DeleteBangbooRequestBody();
            inValue.Body.id = id;
            Bangboo_WS.Bangboo_Service.DeleteBangbooResponse retVal = ((Bangboo_WS.Bangboo_Service.Bangboo_ServiceSoap)(this)).DeleteBangboo(inValue);
            return retVal.Body.DeleteBangbooResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Bangboo_WS.Bangboo_Service.DeleteBangbooResponse> Bangboo_WS.Bangboo_Service.Bangboo_ServiceSoap.DeleteBangbooAsync(Bangboo_WS.Bangboo_Service.DeleteBangbooRequest request) {
            return base.Channel.DeleteBangbooAsync(request);
        }
        
        public System.Threading.Tasks.Task<Bangboo_WS.Bangboo_Service.DeleteBangbooResponse> DeleteBangbooAsync(int id) {
            Bangboo_WS.Bangboo_Service.DeleteBangbooRequest inValue = new Bangboo_WS.Bangboo_Service.DeleteBangbooRequest();
            inValue.Body = new Bangboo_WS.Bangboo_Service.DeleteBangbooRequestBody();
            inValue.Body.id = id;
            return ((Bangboo_WS.Bangboo_Service.Bangboo_ServiceSoap)(this)).DeleteBangbooAsync(inValue);
        }
    }
}
