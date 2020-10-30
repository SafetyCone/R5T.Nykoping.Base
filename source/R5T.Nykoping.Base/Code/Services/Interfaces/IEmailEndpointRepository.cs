using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Endalia;


namespace R5T.Nykoping
{
    public interface IEmailEndpointRepository
    {
        Task Add(EndpointIdentity endpoint, string emailAddress);

        Task<List<EndpointIdentity>> GetEndpointIdentitiesByEmailAddress(string emailAddress);

        Task<bool> Exists(EndpointIdentity endpoint);

        Task<bool> HasEmailAddress(EndpointIdentity endpoint);
        Task SetEmailAddress(EndpointIdentity endpoint, string emailAddress);

        Task<Dictionary<EndpointIdentity, string>> GetEmailAddressesByEndpointIdentity(IEnumerable<EndpointIdentity> endpointIdentities);
    }
}
