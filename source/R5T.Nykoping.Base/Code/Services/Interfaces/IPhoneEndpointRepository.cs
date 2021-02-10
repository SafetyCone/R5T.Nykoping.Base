using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Endalia;


namespace R5T.Nykoping
{
    public interface IPhoneEndpointRepository
    {
        Task Add(EndpointIdentity endpoint, string phoneNumber);

        Task<List<EndpointIdentity>> GetEndpointIdentitiesByPhoneNumber(string phoneNumber);

        Task<bool> Exists(EndpointIdentity endpoint);

        Task<bool> HasPhoneNumber(EndpointIdentity endpoint);
        Task SetPhoneNumber(EndpointIdentity endpoint, string phoneNumber);

        Task<Dictionary<EndpointIdentity, string>> GetPhoneNumbersByEndpointIdentity(IEnumerable<EndpointIdentity> endpointIdentities);
    }
}
