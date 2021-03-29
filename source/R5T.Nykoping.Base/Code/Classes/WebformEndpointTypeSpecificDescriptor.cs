using System;

using R5T.Sundsvall;


namespace R5T.Nykoping
{
    public class WebformEndpointTypeSpecificDescriptor : IEndpointTypeSpecificDescriptor
    {
        public string EndpointTypeName => WebformEndpoint.Name;

        public string WebformUrl { get; set; }
    }
}
