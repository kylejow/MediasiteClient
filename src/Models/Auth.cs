using System;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;

namespace MediasiteUtil.Models
{
	public class Auth : AuthenticatorBase
	{
		private string userName, password, apiKey;

		public Auth(string userName, string password, string apiKey) : base("")
		{
			this.userName = userName;
			this.password = password;
			this.apiKey = apiKey;
		}

		protected override async ValueTask<Parameter> GetAuthenticationParameter(string accessToken)
		{
            Token = string.IsNullOrEmpty(Token) ? string.Format("Basic {0}", Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:{1}", userName, password)))) : Token;
			return new HeaderParameter(KnownHeaders.Authorization, Token);
        }

        public new async ValueTask Authenticate(RestClient client, RestRequest request)
		{
			request.AddOrUpdateParameter(await GetAuthenticationParameter(Token).ConfigureAwait(false))
				.AddOrUpdateParameter("sfapikey", apiKey);
		}
	}
}