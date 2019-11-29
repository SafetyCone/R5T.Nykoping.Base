using System;

using R5T.Endalia;


namespace R5T.Nykoping
{
    public interface IEmailEndpointRepository
    {
        void Add(EndpointIdentity endpoint, string emailAddress);

        bool Exists(EndpointIdentity endpoint);

        bool HasEmailAddress(EndpointIdentity endpoint);
        void SetEmailAddress(EndpointIdentity endpoint, string emailAddress);
        string GetEmailAddress(EndpointIdentity endpoint);
    }
}
