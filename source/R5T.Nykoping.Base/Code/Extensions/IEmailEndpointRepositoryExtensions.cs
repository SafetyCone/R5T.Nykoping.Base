using System;

using R5T.Endalia;


namespace R5T.Nykoping
{
    public static class IEmailEndpointRepositoryExtensions
    {
        public static string GetEmailAddress(this IEmailEndpointRepository repository, Guid identityValue)
        {
            var emailAddress = repository.GetEmailAddress(new EndpointIdentity(identityValue));
            return emailAddress;
        }
    }
}
