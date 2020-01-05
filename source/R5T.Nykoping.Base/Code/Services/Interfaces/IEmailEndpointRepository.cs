using System;
using System.Threading.Tasks;

using R5T.Endalia;


namespace R5T.Nykoping
{
    public interface IEmailEndpointRepository
    {
        Task Add(EndpointIdentity endpoint, string emailAddress);

        Task<bool> Exists(EndpointIdentity endpoint);

        Task<bool> HasEmailAddress(EndpointIdentity endpoint);
        Task SetEmailAddress(EndpointIdentity endpoint, string emailAddress);
        Task<string> GetEmailAddress(EndpointIdentity endpoint);
    }
}
