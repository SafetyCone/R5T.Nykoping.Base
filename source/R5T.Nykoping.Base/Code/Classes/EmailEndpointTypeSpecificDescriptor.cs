using System;

using R5T.Sundsvall;


namespace R5T.Nykoping
{
    public class EmailEndpointTypeSpecificDescriptor : IEndpointTypeSpecificDescriptor
    {
        public string EndpointTypeName => EmailEndpoint.Name;

        public string EmailAddress { get; set; }
    }
}
