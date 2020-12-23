using System.Net.Sockets;

namespace CloudflareDDNSHelper
{
    public class DnsRecord
    {
        public string ZoneId { get; set; }
        public string RecordId { get; set; }
        public string Hostname { get; set; }
        public string OAuthToken { get; set; }
        public AddressFamily RecordType { get; set; }

        public DnsRecord()
        {
            ZoneId = "";
            RecordId = "";
            Hostname = "";
            OAuthToken = "";
            RecordType = AddressFamily.InterNetworkV6;
        }
    }
}
