using DotNetOpenAuth.Messaging;
using DotNetOpenAuth.OAuth;
using DotNetOpenAuth.OAuth2;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Membership.OpenAuth;


namespace MvcApplication1.Login
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string authServer = "";
        string tokenServer = "";

        private InMemoryTokenManager TokenManager
        {
            get
            {
                var tokenManager = (InMemoryTokenManager)Application["TokenManager"];
                if (tokenManager == null)
                {
                    string consumerKey = ConfigurationManager.AppSettings["ConsumerKey"];
                    string consumerSecret = ConfigurationManager.AppSettings["ConsumerSecret"];
                    if (!string.IsNullOrEmpty(consumerKey))
                    {
                        tokenManager = new InMemoryTokenManager(consumerKey, consumerSecret);
                        Application["TokenManager"] = tokenManager;
                    }
                }

                return tokenManager;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            var client = new WebConsumer(OauthClient.description,this.TokenManager);
            string accessToken = client.RequestNewClientAccount();
            MessageReceivingEndpoint ep = null;
            client.PrepareAuthorizedRequest(ep,accessToken);

            IAuthorizationState authorization = client.ProcessUserAuthorization();
            if (authorization == null)
            {
                //auth failed
            }
            else
            {
                //auth suceeded
                var request System.Net.WebRequest.Create(
            }
        }
    }
}