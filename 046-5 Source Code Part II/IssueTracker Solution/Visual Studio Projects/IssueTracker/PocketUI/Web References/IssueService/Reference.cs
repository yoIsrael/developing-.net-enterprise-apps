﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 1.1.4322.573.
// 
namespace PocketUI.IssueService {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="IssueServicesSoap", Namespace="http://tempuri.org/")]
    public class IssueServices : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public IssueServices() {
            this.Url = "http://127.0.0.1/IssueTracker/IssueTracker_WebService/IssueServices.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetSpecificIssue", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetSpecificIssue(string strKey, int argIssueID) {
            object[] results = this.Invoke("GetSpecificIssue", new object[] {
                        strKey,
                        argIssueID});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetSpecificIssue(string strKey, int argIssueID, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetSpecificIssue", new object[] {
                        strKey,
                        argIssueID}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetSpecificIssue(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
    }
}
