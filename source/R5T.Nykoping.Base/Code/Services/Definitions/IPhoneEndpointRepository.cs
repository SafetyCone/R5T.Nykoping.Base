using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Endalia;

using R5T.T0064;


namespace R5T.Nykoping
{
    [ServiceDefinitionMarker]
    public interface IPhoneEndpointRepository : IServiceDefinition
    {
        Task Add(EndpointIdentity endpoint, string phoneNumber);

        Task<List<EndpointIdentity>> GetEndpointIdentitiesByPhoneNumber(string phoneNumber);

        Task<bool> Exists(EndpointIdentity endpoint);

        Task<bool> HasPhoneNumber(EndpointIdentity endpoint);
        Task SetPhoneNumber(EndpointIdentity endpoint, string phoneNumber);

        Task<Dictionary<EndpointIdentity, string>> GetPhoneNumbersByEndpointIdentity(IEnumerable<EndpointIdentity> endpointIdentities);
    }
}
