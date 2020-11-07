using System;

namespace ch1seL.TonClientBlazor.Attributes
{
    public class GraphQlNamespaceAttribute : Attribute
    {
        public string Namespace { get; set; }
    }
}