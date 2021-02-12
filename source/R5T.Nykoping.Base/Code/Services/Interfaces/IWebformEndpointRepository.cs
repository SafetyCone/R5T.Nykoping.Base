using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Endalia;


namespace R5T.Nykoping
{
    public interface IWebformEndpointRepository
    {
        Task Add(EndpointIdentity endpoint, string webformUrl);

        Task<List<EndpointIdentity>> GetEndpointIdentitiesByWebformUrl(string WebformUrl);

        Task<bool> Exists(EndpointIdentity endpoint);

        Task<bool> HasWebformUrl(EndpointIdentity endpoint);
        Task SetWebformUrl(EndpointIdentity endpoint, string WebformUrl);

        Task<Dictionary<EndpointIdentity, string>> GetWebformUrlsByEndpointIdentity(IEnumerable<EndpointIdentity> endpointIdentities);
    }
}
