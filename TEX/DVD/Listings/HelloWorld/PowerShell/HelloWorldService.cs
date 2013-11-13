﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// Dieser Quellcode wurde automatisch generiert von wsdl, Version=2.0.50727.42.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="HelloWorldSOAP11Binding", Namespace="http://ws.apache.org/axis2")]
public partial class HelloWorld : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback SayHelloOperationCompleted;
    
    /// <remarks/>
    public HelloWorld() {
        this.Url = "http://192.168.68.107:8080/axis2/services/HelloWorld";
    }
    
    /// <remarks/>
    public event SayHelloCompletedEventHandler SayHelloCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:SayHello", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
    [return: System.Xml.Serialization.XmlElementAttribute("SayHelloResponse", Namespace="http://ws.apache.org/axis2/xsd")]
    public SayHelloResponse SayHello() {
        object[] results = this.Invoke("SayHello", new object[0]);
        return ((SayHelloResponse)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginSayHello(System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("SayHello", new object[0], callback, asyncState);
    }
    
    /// <remarks/>
    public SayHelloResponse EndSayHello(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((SayHelloResponse)(results[0]));
    }
    
    /// <remarks/>
    public void SayHelloAsync() {
        this.SayHelloAsync(null);
    }
    
    /// <remarks/>
    public void SayHelloAsync(object userState) {
        if ((this.SayHelloOperationCompleted == null)) {
            this.SayHelloOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSayHelloOperationCompleted);
        }
        this.InvokeAsync("SayHello", new object[0], this.SayHelloOperationCompleted, userState);
    }
    
    private void OnSayHelloOperationCompleted(object arg) {
        if ((this.SayHelloCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.SayHelloCompleted(this, new SayHelloCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class SayHelloResponse {
    
    private string returnField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string @return {
        get {
            return this.returnField;
        }
        set {
            this.returnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
public delegate void SayHelloCompletedEventHandler(object sender, SayHelloCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class SayHelloCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal SayHelloCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public SayHelloResponse Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((SayHelloResponse)(this.results[0]));
        }
    }
}
