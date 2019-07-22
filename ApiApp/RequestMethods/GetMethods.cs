using RestSharp;

namespace ApiApp.RequestMethods
{
    class GetMethods
    {
        public ResponseStatus GetHttpCode(string httpReq)
        {
            var client = new RestClient(httpReq);
            var request = new RestRequest(httpReq, Method.GET);
            string content = client.Execute(request).Content;
            char[] actualContent = content.ToCharArray();

            IRestResponse response = client.Execute(request);

            return response.ResponseStatus;
        }

        public string GetHttpBody(string httpReqURL)
        {
            var client = new RestClient(httpReqURL);
            var request = new RestRequest(httpReqURL, Method.GET);
            string content = client.Execute(request).Content;
            char[] actualContent = content.ToCharArray();

            IRestResponse response = client.Execute(request);

            return response.Content;
        }
    }
}
