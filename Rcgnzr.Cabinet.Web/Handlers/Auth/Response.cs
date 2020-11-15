using System;

namespace Rcgnzr.Cabinet.Web.Handlers.Auth
{
    public class Response
    {
        private Response(bool ok, string token)
        {
            Ok = ok;
            Token = token;
        }

        public static Response Success(string token)
        {
            if (string.IsNullOrEmpty(token))
            {
                throw new ArgumentNullException(nameof(token));
            }
            return new Response(true, token);
        }


        public static Response Fail() => new Response(false, "");

        public bool Ok { get; }
        public string Token { get; }
    }
}