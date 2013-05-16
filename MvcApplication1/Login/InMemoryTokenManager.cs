using DotNetOpenAuth.OAuth.ChannelElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcApplication1.Login
{
    class InMemoryTokenManager : IConsumerTokenManager
    {
        public InMemoryTokenManager(string consumerKey, string consumerSecret)
        {
            if (string.IsNullOrEmpty(consumerKey)) {
				throw new ArgumentNullException("consumerKey");
			}

			this.ConsumerKey = consumerKey;
			this.ConsumerSecret = consumerSecret;
		}

		/// <summary>
		/// Gets the consumer key.
		/// </summary>
		/// <value>The consumer key.</value>
		public string ConsumerKey { get; private set; }

		/// <summary>
		/// Gets the consumer secret.
		/// </summary>
		/// <value>The consumer secret.</value>
		public string ConsumerSecret { get; private set; }
    }
}
