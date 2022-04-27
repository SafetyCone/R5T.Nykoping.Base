using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Endalia;

using R5T.T0064;


namespace R5T.Nykoping
{
    [ServiceDefinitionMarker]
    public interface IEmailEndpointRepository : IServiceDefinition
    {
        Task Add(EndpointIdentity endpoint, string emailAddress);

        Task<List<EndpointIdentity>> GetEndpointIdentitiesByEmailAddress(string emailAddress);

        Task<bool> Exists(EndpointIdentity endpoint);

        Task<bool> HasEmailAddress(EndpointIdentity endpoint);
        Task SetEmailAddress(EndpointIdentity endpoint, string emailAddress);

        Task<Dictionary<EndpointIdentity, string>> GetEmailAddressesByEndpointIdentity(IEnumerable<EndpointIdentity> endpointIdentities);
    }
}
