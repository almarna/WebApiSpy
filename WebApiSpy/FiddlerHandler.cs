using System;
using Fiddler;

namespace WebApiSpy
{

    public class FiddlerHandler: IDisposable
    {
        public class WebApiInfo
        {
            public string Url { get; set; }
            public string Method { get; set; }
            public string Request { get; set; }
            public string Response { get; set; }
            public DateTime StartTime { get; set; }
            public TimeSpan Timer { get; set; }

            public string PrettyRequest
            {
                get { return JsonFormatter.PrettyPrint(Request); }
            }

            public string PrettyResponse
            {
                get { return JsonFormatter.PrettyPrint(Response); }
            }
        }

        public Action<WebApiInfo> OnDataRecieved;

        public FiddlerHandler()
        {
            FiddlerApplication.AfterSessionComplete += OnAfterSessionComplete;
        }

        private void OnAfterSessionComplete(Session fiddlerSession)
        {
            if (IsWebApiCall(fiddlerSession))
            {
                var fiddlerWebApiInfo = CreateFiddlerWebApiInfo(fiddlerSession);

                TriggerOnDataReceivedAction(fiddlerWebApiInfo);
            }
        }

        private static bool IsWebApiCall(Session fiddlerSession)
        {
            HTTPResponseHeaders responseHeaders = fiddlerSession.oResponse.headers;
            bool responseIsJson = responseHeaders.ExistsAndContains("Content-Type", "application/json");

            HTTPRequestHeaders requestHeaders = fiddlerSession.oRequest.headers;
            bool requestIsJson = requestHeaders.ExistsAndContains("Content-Type", "application/json");

            bool resp = requestIsJson || responseIsJson;
            return resp;
        }

        private void TriggerOnDataReceivedAction(WebApiInfo fiddlerWebApiInfo)
        {
            var localOnDataRecieved = OnDataRecieved;
            if (localOnDataRecieved != null)
            {
                localOnDataRecieved(fiddlerWebApiInfo);
            }
        }

        private static WebApiInfo CreateFiddlerWebApiInfo(Session fiddlerSession)
        {
           return new WebApiInfo
            {
                Url = fiddlerSession.url,
                Method = fiddlerSession.RequestMethod,
                Request = fiddlerSession.GetRequestBodyAsString(),
                Response = fiddlerSession.GetResponseBodyAsString(),
                StartTime = fiddlerSession.Timers.ClientBeginRequest,
                Timer = fiddlerSession.Timers.ClientDoneResponse - fiddlerSession.Timers.ClientBeginRequest
            };
        }

        public void xy(Session osession)
        {
            string url = osession.url;
            string method = osession.RequestMethod;

            string requestBody = osession.GetRequestBodyAsString();
            string responseBody = osession.GetResponseBodyAsString();

            DateTime startTime = osession.Timers.ClientBeginRequest;
            DateTime endTime = osession.Timers.ClientDoneResponse;

            TimeSpan timeSpan = endTime - startTime;
        }

        public void Start()
        {
            if (!FiddlerApplication.IsStarted())
            {
                FiddlerApplication.Startup(8888, true, false);
            }
        }

        public void Stop()
        {
            if (FiddlerApplication.IsStarted())
            {
                FiddlerApplication.Shutdown();  
            }
        }

        public void Dispose()
        {
            Stop();
        }

    }
}
