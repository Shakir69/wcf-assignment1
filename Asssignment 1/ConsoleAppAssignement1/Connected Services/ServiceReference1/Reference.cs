﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleAppAssignement1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPrime_Number", ReplyAction="http://tempuri.org/IService1/GetPrime_NumberResponse")]
        string GetPrime_Number(int pn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPrime_Number", ReplyAction="http://tempuri.org/IService1/GetPrime_NumberResponse")]
        System.Threading.Tasks.Task<string> GetPrime_NumberAsync(int pn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getSum_of_digits", ReplyAction="http://tempuri.org/IService1/getSum_of_digitsResponse")]
        string getSum_of_digits(int num);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getSum_of_digits", ReplyAction="http://tempuri.org/IService1/getSum_of_digitsResponse")]
        System.Threading.Tasks.Task<string> getSum_of_digitsAsync(int num);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/reverse_String", ReplyAction="http://tempuri.org/IService1/reverse_StringResponse")]
        string reverse_String(string val);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/reverse_String", ReplyAction="http://tempuri.org/IService1/reverse_StringResponse")]
        System.Threading.Tasks.Task<string> reverse_StringAsync(string val);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/html_tags", ReplyAction="http://tempuri.org/IService1/html_tagsResponse")]
        string html_tags(string value, string val);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/html_tags", ReplyAction="http://tempuri.org/IService1/html_tagsResponse")]
        System.Threading.Tasks.Task<string> html_tagsAsync(string value, string val);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/sort_Numbers", ReplyAction="http://tempuri.org/IService1/sort_NumbersResponse")]
        string sort_Numbers(string asc_desc, int number, int val, int value, int num, int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/sort_Numbers", ReplyAction="http://tempuri.org/IService1/sort_NumbersResponse")]
        System.Threading.Tasks.Task<string> sort_NumbersAsync(string asc_desc, int number, int val, int value, int num, int n);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ConsoleAppAssignement1.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ConsoleAppAssignement1.ServiceReference1.IService1>, ConsoleAppAssignement1.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetPrime_Number(int pn) {
            return base.Channel.GetPrime_Number(pn);
        }
        
        public System.Threading.Tasks.Task<string> GetPrime_NumberAsync(int pn) {
            return base.Channel.GetPrime_NumberAsync(pn);
        }
        
        public string getSum_of_digits(int num) {
            return base.Channel.getSum_of_digits(num);
        }
        
        public System.Threading.Tasks.Task<string> getSum_of_digitsAsync(int num) {
            return base.Channel.getSum_of_digitsAsync(num);
        }
        
        public string reverse_String(string val) {
            return base.Channel.reverse_String(val);
        }
        
        public System.Threading.Tasks.Task<string> reverse_StringAsync(string val) {
            return base.Channel.reverse_StringAsync(val);
        }
        
        public string html_tags(string value, string val) {
            return base.Channel.html_tags(value, val);
        }
        
        public System.Threading.Tasks.Task<string> html_tagsAsync(string value, string val) {
            return base.Channel.html_tagsAsync(value, val);
        }
        
        public string sort_Numbers(string asc_desc, int number, int val, int value, int num, int n) {
            return base.Channel.sort_Numbers(asc_desc, number, val, value, num, n);
        }
        
        public System.Threading.Tasks.Task<string> sort_NumbersAsync(string asc_desc, int number, int val, int value, int num, int n) {
            return base.Channel.sort_NumbersAsync(asc_desc, number, val, value, num, n);
        }
    }
}