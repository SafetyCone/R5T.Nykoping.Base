using System;
using System.Linq;
using System.Threading.Tasks;

using R5T.Endalia;
using R5T.Magyar;


namespace R5T.Nykoping
{
    public static class IPhoneEndpointRepositoryExtensions
    {
        public static async Task SetPhoneNumberAddIfNeccessary(this IPhoneEndpointRepository repository, EndpointIdentity endpointIdentity, string phoneNumber)
        {
            var hasPhoneNumber = await repository.HasPhoneNumber(endpointIdentity);
            if(hasPhoneNumber)
            {
                await repository.SetPhoneNumber(endpointIdentity, phoneNumber);
            }
            else
            {
                await repository.Add(endpointIdentity, phoneNumber);
            }
        }

        public static async Task<string> GetPhoneNumber(this IPhoneEndpointRepository phoneEndpointRepository, EndpointIdentity endpointIdentity)
        {
            var endpointIdentities = EnumerableHelper.From(endpointIdentity);

            var phoneNumbers = await phoneEndpointRepository.GetPhoneNumbersByEndpointIdentity(endpointIdentities);

            var phoneNumber = phoneNumbers.Single().Value;
            return phoneNumber;
        }

        public static async Task<string> GetPhoneNumber(this IPhoneEndpointRepository repository, Guid endpointIdentityValue)
        {
            var phoneNumber = await repository.GetPhoneNumber(new EndpointIdentity(endpointIdentityValue));
            return phoneNumber;
        }
    }
}
