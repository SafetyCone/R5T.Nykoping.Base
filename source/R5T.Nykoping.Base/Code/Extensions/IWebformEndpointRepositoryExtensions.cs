using System;
using System.Linq;
using System.Threading.Tasks;

using R5T.Endalia;
using R5T.Magyar;


namespace R5T.Nykoping
{
    public static class IWebformEndpointRepositoryExtensions
    {
        public static async Task SetWebformUrlAddIfNeccessary(this IWebformEndpointRepository repository, EndpointIdentity endpointIdentity, string webformUrl)
        {
            var hasWebformUrl = await repository.HasWebformUrl(endpointIdentity);
            if(hasWebformUrl)
            {
                await repository.SetWebformUrl(endpointIdentity, webformUrl);
            }
            else
            {
                await repository.Add(endpointIdentity, webformUrl);
            }
        }

        public static async Task<string> GetWebformUrl(this IWebformEndpointRepository webformEndpointRepository, EndpointIdentity endpointIdentity)
        {
            var endpointIdentities = EnumerableHelper.From(endpointIdentity);

            var webformUrls = await webformEndpointRepository.GetWebformUrlsByEndpointIdentity(endpointIdentities);

            var webformUrl = webformUrls.Single().Value;
            return webformUrl;
        }

        public static async Task<string> GetWebformUrl(this IWebformEndpointRepository repository, Guid endpointIdentityValue)
        {
            var webformUrl = await repository.GetWebformUrl(new EndpointIdentity(endpointIdentityValue));
            return webformUrl;
        }
    }
}
