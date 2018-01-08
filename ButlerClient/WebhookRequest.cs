using System;

namespace ButlerClient
{
    public class WebhookRequest
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public DateTime When { get; set; }
        public object Data { get; set; }
    }
}
