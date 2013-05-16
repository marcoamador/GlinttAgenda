using DotNetOpenAuth.Messaging;
using DotNetOpenAuth.OAuth;
using DotNetOpenAuth.OAuth2;
using System.Collections.Generic;

namespace MvcApplication1.Login
{
    public class OauthClient : WebServerClient
    {
        public static readonly ServiceProviderDescription description = new ServiceProviderDescription
        {
            RequestTokenEndpoint = new MessageReceivingEndpoint("", HttpDeliveryMethods.AuthorizationHeaderRequest | HttpDeliveryMethods.GetRequest),
            UserAuthorizationEndpoint = new MessageReceivingEndpoint("", HttpDeliveryMethods.AuthorizationHeaderRequest | HttpDeliveryMethods.GetRequest),
            AccessTokenEndpoint = new MessageReceivingEndpoint("", HttpDeliveryMethods.AuthorizationHeaderRequest | HttpDeliveryMethods.GetRequest),

        };

        //Mapping between resources and their URI scope values

        private static readonly Dictionary<Resources, string> ScopeUris = new Dictionary<Resources, string> {
			{ Resources.Visit, "https://www.servidor.com/visit/" },
			{ Resources.Patient, "https://www.servidor.com/patient/" },
            { Resources.Practitioner, "https://www.servidor.com/practitioner/"},
		};

        public enum Resources : int
        {
            Visit = 1,
            Patient = 2,
            Practitioner = 3
        }

    }
}