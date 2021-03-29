using System;

using R5T.Sundsvall;


namespace R5T.Nykoping
{
    public class PhoneEndpointTypeSpecificDescriptor : IEndpointTypeSpecificDescriptor
    {
        public string EndpointTypeName => PhoneEndpoint.Name;

        public string PhoneNumber { get; set; }
    }
}
