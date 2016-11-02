using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Red_Folder.WebCrawl.Data
{
    [DataContract]
    public class CrawlResults
    {
        [DataMember(Name="id")]
        public string Id { get; private set; }

        [DataMember(Name = "host")]
        public string Host { get; private set; }

        [DataMember(Name = "timestamp")]
        public DateTime Timestamp { get; private set; }

        [DataMember(Name = "urls")]
        public IReadOnlyList<Url> Urls { get; private set; }

        [DataMember(Name = "links")]
        public IReadOnlyList<Link> Links { get; private set; }

        public CrawlResults(string id, string host, List<Url> urls, List<Link> links)
        {
            Id = id;
            Host = host;
            Timestamp = DateTime.UtcNow;
            Urls = urls;
            Links = links;
        }
    }
}
