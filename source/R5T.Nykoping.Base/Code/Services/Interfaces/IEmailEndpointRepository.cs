using System;

using R5T.Endalia;


namespace R5T.Nykoping
{
    public interface IEmailEndpointRepository
    {
        void SetEmailAddress(EndpointIdentity endpoint, string emailAddress);
        string GetEmailAddress(EndpointIdentity endpoint);
    }
}
