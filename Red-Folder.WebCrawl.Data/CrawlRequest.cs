using System.Runtime.Serialization;

namespace Red_Folder.WebCrawl.Data
{
    [DataContract]
    public class CrawlRequest
    {
        [DataMember(Name = "id")]
        public string Id { get; private set; }

        [DataMember(Name = "host")]
        public string Host { get; private set; }

        public CrawlRequest(string id, string host)
        {
            Id = id;
            Host = host;
        }
    }
}
