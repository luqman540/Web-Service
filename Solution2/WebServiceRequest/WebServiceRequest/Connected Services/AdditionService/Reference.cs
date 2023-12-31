﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceRequest.AdditionService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AdditionService.WebServiceAdditionSoap")]
    public interface WebServiceAdditionSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Addition", ReplyAction="*")]
        double Addition(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Addition", ReplyAction="*")]
        System.Threading.Tasks.Task<double> AdditionAsync(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Difference", ReplyAction="*")]
        double Difference(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Difference", ReplyAction="*")]
        System.Threading.Tasks.Task<double> DifferenceAsync(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Product", ReplyAction="*")]
        double Product(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Product", ReplyAction="*")]
        System.Threading.Tasks.Task<double> ProductAsync(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Division", ReplyAction="*")]
        double Division(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Division", ReplyAction="*")]
        System.Threading.Tasks.Task<double> DivisionAsync(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Square", ReplyAction="*")]
        double Square(double num1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Square", ReplyAction="*")]
        System.Threading.Tasks.Task<double> SquareAsync(double num1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Cube", ReplyAction="*")]
        double Cube(double num1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Cube", ReplyAction="*")]
        System.Threading.Tasks.Task<double> CubeAsync(double num1);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceAdditionSoapChannel : WebServiceRequest.AdditionService.WebServiceAdditionSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceAdditionSoapClient : System.ServiceModel.ClientBase<WebServiceRequest.AdditionService.WebServiceAdditionSoap>, WebServiceRequest.AdditionService.WebServiceAdditionSoap {
        
        public WebServiceAdditionSoapClient() {
        }
        
        public WebServiceAdditionSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceAdditionSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceAdditionSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceAdditionSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Addition(double num1, double num2) {
            return base.Channel.Addition(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> AdditionAsync(double num1, double num2) {
            return base.Channel.AdditionAsync(num1, num2);
        }
        
        public double Difference(double num1, double num2) {
            return base.Channel.Difference(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> DifferenceAsync(double num1, double num2) {
            return base.Channel.DifferenceAsync(num1, num2);
        }
        
        public double Product(double num1, double num2) {
            return base.Channel.Product(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> ProductAsync(double num1, double num2) {
            return base.Channel.ProductAsync(num1, num2);
        }
        
        public double Division(double num1, double num2) {
            return base.Channel.Division(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> DivisionAsync(double num1, double num2) {
            return base.Channel.DivisionAsync(num1, num2);
        }
        
        public double Square(double num1) {
            return base.Channel.Square(num1);
        }
        
        public System.Threading.Tasks.Task<double> SquareAsync(double num1) {
            return base.Channel.SquareAsync(num1);
        }
        
        public double Cube(double num1) {
            return base.Channel.Cube(num1);
        }
        
        public System.Threading.Tasks.Task<double> CubeAsync(double num1) {
            return base.Channel.CubeAsync(num1);
        }
    }
}
