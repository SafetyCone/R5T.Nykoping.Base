using System;
using System.Threading.Tasks;

using R5T.Endalia;


namespace R5T.Nykoping
{
    public static class IEmailEndpointRepositoryExtensions
    {
        public static async Task SetEmailAddressAddIfNeccessary(this IEmailEndpointRepository repository, EndpointIdentity endpointIdentity, string emailAddress)
        {
            var hasEmailAddress = await repository.HasEmailAddress(endpointIdentity);
            if(hasEmailAddress)
            {
                await repository.SetEmailAddress(endpointIdentity, emailAddress);
            }
            else
            {
                await repository.Add(endpointIdentity, emailAddress);
            }
        }

        public static async Task<string> GetEmailAddress(this IEmailEndpointRepository repository, Guid endpointIdentityValue)
        {
            var emailAddress = await repository.GetEmailAddress(new EndpointIdentity(endpointIdentityValue));
            return emailAddress;
        }
    }
}
